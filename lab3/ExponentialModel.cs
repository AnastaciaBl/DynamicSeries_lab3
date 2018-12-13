using System;
using System.Collections.Generic;
using System.Linq;

namespace lab3
{
    public class ExponentialModel
    {
        private DynamicSeries Series { get; }
        public double B1 { get; }
        public double B2 { get; }
        public double B3 { get; }
        public int Period { get; } = 12;
        public List<double> A { get; }
        public List<double> R { get; }
        public List<double> G { get; }
        public List<double> NewValues { get; }

        private ExponentialModel()
        {
            A = new List<double>();
            R = new List<double>();
            G = new List<double>();
            NewValues = new List<double>();

            A.Add(1);
            R.Add(1);

            //TODO Find out how to set first values for those items
            for (int i = 0; i < Period; i++)
            {
                G.Add(0);
            }
        }

        public ExponentialModel(DynamicSeries series, double b1, double b2, double b3) : this()
        {
            Series = series;
            B1 = b1;
            B2 = b2;
            B3 = b3;
            CountCoefs();
        }

        private void CountCoefs()
        {
            for (int i = 0; i < Period; i++)
                NewValues.Add(Series.Value[i]);
            int startIndex = Period;
            A.Add(NewValues.Average());
            R.Add((Series.Value[startIndex] - Series.Value[0]) / (startIndex - 1));
            double predict = 0, ePrev = 0, e = 0;
            while (startIndex < Series.AmountOfElements - 1)
            {
                G.Add(CountG(startIndex, Period));
                predict = (A.Last() * Math.Pow(R.Last(), startIndex)) + G.Last();
                NewValues.Add(predict);
                ePrev = e;
                e = Series.Value[startIndex] - predict;
                startIndex++;
                A.Add(CountA(startIndex, Period));
                R.Add(CountR(startIndex));
            }
            PredictValues();
            //for (int i = 1; i < Period; i++)
            //{
            //    A.Add(CountA(i, Period));
            //    R.Add(CountR(i));
            //    NewValues.Add(A.Last() * Math.Pow(R.Last(), i));
            //}
            //for (int i = Period; i < Series.AmountOfElements; i++)
            //{
            //    A.Add(CountA(i, Period));
            //    R.Add(CountR(i));
            //    G.Add(CountG(i, Period));
            //    NewValues.Add((A.Last() * Math.Pow(R.Last(), i)) + G[i]);
            //}
            //PredictValues();
        }

        private double CountA(int index, int period)
        {
            double g = (index - period) <= 0 ? 0 : G[index - period];
            //return B1 * (Series.Value[index] - g) + (1 - B1) * (A[index - 1] * R[index - 1]);
            return B1 * (Series.Value[index] - g) + (1 - B1) * (A[A.Count - 1] * R[R.Count - 1]);
        }

        private double CountR(int index)
        {
            //return B2 * (A[index] / A[index - 1]) + (1 - B2) * R[index - 1];
            return B2 * (A.Last() / A[A.Count - 1]) + (1 - B2) * R[R.Count - 1];
        }

        private double CountG(int index, int period)
        {
            double g = (index - period) <= 0 ? 0 : G[index - period];
            //return B3 * (Series.Value[index] / A[index]) + (1 - B3) * g;
            return B3 * (Series.Value[index] / A.Last()) + (1 - B3) * g;
        }

        private void PredictValues()
        {
            for (int i = 0; i < Period; i++)
                NewValues.Add((A.Last() * Math.Pow(R.Last(),i)) + G[Series.AmountOfElements - 1 + i - Period]);
        }
    }
}
