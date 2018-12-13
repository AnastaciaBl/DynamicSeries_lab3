using System.Collections.Generic;
using System.Linq;

namespace lab3
{
    public class LinearModel
    {
        private DynamicSeries Series { get; }
        public double B1 { get; }
        public double B2 { get; }
        public double B3 { get; }
        public int Period { get; } = 12;
        public List<double> A1 { get; }
        public List<double> A2 { get; }
        public List<double> F { get; }
        public List<double> NewValues { get; }

        private LinearModel()
        {
            A1 = new List<double>();
            A2 = new List<double>();
            F = new List<double>();
            NewValues = new List<double>();

            A1.Add(1);
            A2.Add(1);

            //TODO Find out how to set first values for those items
            for (int i = 0; i < Period; i++)
                F.Add(1);
        }

        public LinearModel(DynamicSeries series, double b1, double b2, double b3) : this()
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
            A1.Add(NewValues.Average());
            A2.Add((Series.Value[startIndex] - Series.Value[0]) / (startIndex - 1));
            double predict = 0, ePrev = 0, e = 0;
            while (startIndex < Series.AmountOfElements - 1)
            {
                F.Add(CountF(startIndex, Period));
                predict = (A1.Last() + A2.Last()) * F.Last();
                NewValues.Add(predict);
                ePrev = e;
                e = Series.Value[startIndex] - predict;
                startIndex++;
                A1.Add(CountA1(startIndex, Period));
                A2.Add(CountA2(startIndex));
            }
            PredictValues();
            //for (int i = 1; i < Period; i++)
            //{
            //    A1.Add(CountA1(i, Period));
            //    A2.Add(CountA2(i));
            //    NewValues.Add((A1[i] + A2[i]));
            //}
            //for(int i=Period;i<Series.AmountOfElements;i++)
            //{
            //    A1.Add(CountA1(i, Period));
            //    A2.Add(CountA2(i));
            //    F.Add(CountF(i, Period));
            //    NewValues.Add((A1[i] + A2[i]) * F[i]);
            //}
            //PredictValues();
        }

        private double CountA1(int index, int period)
        {
            double f = (index - period) <= 0 ? 1 : F[index - period];
            //return B1 * (Series.Value[index] / f) + (1 - B1) * (A1[index - 1] + A2[index - 1]);
            return B1 * (Series.Value[index] / f) + (1 - B1) * (A1[A1.Count - 1] + A2[A2.Count - 1]);
        }

        private double CountA2(int index)
        {
            //return B2 * (A1[index] - A1[index - 1]) + (1 - B2) * A2[index - 1];
            return B2 * (A1.Last() - A1[A1.Count - 1]) + (1 - B2) * A2[A2.Count - 1];
        }

        private double CountF(int index, int period)
        {
            double f = (index - period) <= 0 ? 1 : F[index - period];
            //return B3 * (Series.Value[index] / A1[index]) + (1 - B3) * f;
            return B3 * (Series.Value[index] / A1.Last()) + (1 - B3) * f;
        }

        private void PredictValues()
        {
            for (int i = 0; i < Period; i++)
                NewValues.Add((A1.Last() + A2.Last()*i) * F[Series.AmountOfElements-1 + i - Period]);
        }
    }
}
