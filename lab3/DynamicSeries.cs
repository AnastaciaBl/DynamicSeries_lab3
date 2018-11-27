using System;
using System.Collections.Generic;

namespace lab3
{
    public class DynamicSeries
    {
        public List<string> Index { get; private set; }
        public List<double> Value { get; private set; }
        public int AmountOfElements { get; }

        public DynamicSeries()
        {
            Index = new List<string>();
            Value = new List<double>();
        }

        public DynamicSeries(string fields, List<string> data):this()
        {
            FillData(data);
            AmountOfElements = Value.Count;
        }

        private void FillData(List<string> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                var temp = data[i].Split(',');
                try
                {
                    temp[1] = temp[1].Replace('.', ',');
                    Value.Add(Convert.ToDouble(temp[1]));
                    Index.Add(temp[0]);
                }
                catch
                { }
            }
        }
    }
}
