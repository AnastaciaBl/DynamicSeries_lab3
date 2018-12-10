using System.Collections.Generic;

namespace lab3
{
    public static class ExponentialSmoothing
    {
        private static double Al { get; } = 0.6;
        private static double Bt => 1 - Al;

        public static DynamicSeries SmoothOverDynamicSeries(DynamicSeries series)
        {
            var sList = new List<double>();
            sList.Add(series.Value[0]);
            for (int i = 1; i < series.AmountOfElements; i++)
            {
                double s = sList[i - 1] + Al * (series.Value[i] - sList[i - 1]);
                sList.Add(s);
            }
            return new DynamicSeries(series.Index, sList);
        }
    }
}
