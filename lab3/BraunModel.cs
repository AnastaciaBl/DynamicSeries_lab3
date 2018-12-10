using System;
using System.Collections.Generic;
using System.Linq;

namespace lab3
{
    class BraunModel
    {
        private DynamicSeries Series { get; }
        public List<double> NewValues { get; }
        public double B { get; }
        public double B2 { get; }
        public double AmountOfElements { get; }


        public BraunModel(DynamicSeries series, double b, int amountOfOldValues, int amountOfElements)
        {
            AmountOfElements = amountOfElements;
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
            double predict = a1k + a2k;
            startIndex++;
            while (startIndex < AmountOfElements)
            {
                a1k = CountA1(predict);
                a2k = CountA2(a2k, predict);
                predict = a1k + a2k;
                NewValues.Add(predict);
                startIndex++;
            }
        }

        private double CountA1(double u)
        {
            return NewValues.Last() + (1 - B * B) * (NewValues.Last() - u);
        }

        private double CountA2(double previousA2, double u)
        {
            return previousA2 + (1 - B * B) * (NewValues.Last() - u);
        }
    }
}
