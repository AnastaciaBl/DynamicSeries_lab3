using System.Collections.Generic;
using System.Linq;

namespace lab3
{
    public class BraunModel
    {
        private DynamicSeries Series { get; }
        public List<double> NewValues { get; }
        public double B { get; }
        public double AmountOfNewElements { get; }


        public BraunModel(DynamicSeries series, double b, int amountOfOldValues, int amountOfElements)
        {
            AmountOfNewElements = amountOfElements;
            NewValues = new List<double>();
            Series = series;
            B = b;

            for(int i=0;i<amountOfOldValues;i++)
                NewValues.Add(Series.Value[i]);

            CountValues(amountOfOldValues);
        }

        private void CountValues(int startIndex)
        {
            double a1k = NewValues.Average();
            double a2k = (Series.Value[startIndex] - Series.Value[0]) / (startIndex - 1);
            double predict = 0, ePrev = 0, e = 0;
            while (startIndex < Series.AmountOfElements - 1)
            {
                predict = a1k + a2k;
                NewValues.Add(predict);
                ePrev = e;
                e = Series.Value[startIndex] - predict;
                startIndex++;
                a1k = CountA1(e);
                a2k = CountA2(a2k, e);
            }
            PredictValues(a1k, a2k);
        }

        private void PredictValues(double a1, double a2)
        {
            for (int i = 0; i < AmountOfNewElements; i++)
                NewValues.Add(a1 + a2 * (i + 1));
        }

        private double CountA1(double e)
        {
            return NewValues.Last() + (1 - B * B) * e;
        }

        private double CountA2(double previousA2, double e)
        {
            return previousA2 + (1 - B * B) * e;
        }
    }
}
