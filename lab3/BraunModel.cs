using System;
using System.Collections.Generic;

namespace lab3
{
    class BraunModel
    {
        private DynamicSeries Series { get; }
        public double B { get; }
        public double Al { get; }
        private List<double> A0 { get; set; }
        private List<double> A1 { get; set; }
        //private List<double> _A0 { get; set; }
        //private List<double> _A1 { get; set; }

        private BraunModel()
        {
            A0 = new List<double>();
            A1 = new List<double>();
            //_A0 = new List<double>();
            //_A1 = new List<double>();

            //TODO Find out how to set first values for those items
            //_A1.Add(1);
            A0.Add(1);
            A1.Add(1);
        }

        public BraunModel(DynamicSeries series, double b, double al):this()
        {
            Series = series;
            B = b;
            Al = al;

            CountCoefs();
        }

        //(8.11) formulas
        private void CountCoefs()
        {
            for (int i = 1; i < Series.AmountOfElements; i++)
            {
                A0.Add(FindA0(i));
                A1.Add(FindA1(i));
            }
        }

        private double FindA0(int index)
        {
            double var = Math.Pow(1 - Al, 2);
            return (1 - var) * Series.Value[index] + var * A0[index - 1] + var * A1[index - 1];
        }

        private double FindA1(int index)
        {
            double Al2 = Al * Al;
            return Al2 * Series.Value[index] - Al2 * A1[index - 1] - Al2 * A0[index - 1] + A1[index - 1];
        }

        /*private double Find_A0(int index)
        {
            return Series.Value[index] + (1 + B * B) * E[index];
        }

        private double Find_A1(int index)
        {
            return _A1[index - 1] + (1 - B * B) * E[index];
        }*/
    }
}
