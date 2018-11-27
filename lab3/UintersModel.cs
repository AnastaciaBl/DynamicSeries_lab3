using System.Collections.Generic;

namespace lab3
{
    class UintersModel
    {
        private DynamicSeries Series { get; }
        public double B1 { get; } = 0.3;
        public double B2 { get; } = 0.6;
        public double B3 { get; } = 0.8;
        public int Period { get; } = 3;
        public List<double> A1 { get; }
        public List<double> A2 { get; }
        public List<double> F { get; }

        private UintersModel()
        {
            A1 = new List<double>();
            A2 = new List<double>();
            F = new List<double>();

            //TODO Find out how to set first values for those items
            //_A1.Add(1);
            A1.Add(1);
            A2.Add(1);
        }

        public UintersModel(DynamicSeries series):this()
        {
            Series = series;
            CountCoefs();
        }

        private void CountCoefs()
        {
            for (int i = 1; i < Series.AmountOfElements; i++)
            {
                A1.Add(CountA1(i, Period));
                A2.Add(CountA2(i));
                F.Add(CountF(i, Period));
            }
        }

        private double CountA1(int index, int period)
        {
            return B1 * (Series.Value[index] / F[index - period]) + (1 - B1) * (A1[index - 1] + A2[index - 1]);
        }

        private double CountA2(int index)
        {
            return B2 * (A1[index] - A1[index - 1]) + (1 - B2) * A2[index - 1];
        }

        private double CountF(int index, int period)
        {
            return B3 * (Series.Value[index] / A1[index]) + (1 - B3) * F[index - period];
        }
    }
}
