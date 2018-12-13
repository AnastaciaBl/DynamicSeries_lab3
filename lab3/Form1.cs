using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public DynamicSeries Series { get; set; }
        public BraunModel BraunSeries { get; set; }
        public LinearModel LinearSeries { get; set; }
        public ExponentialModel ExponentialSeries { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (var openFile = new OpenFileDialog())
            {
                openFile.RestoreDirectory = true;
                openFile.Filter = "Text files (*.csv)|*.csv";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    using (var reader = new StreamReader(openFile.FileName))
                    {
                        var fields = reader.ReadLine();
                        var data = new List<string>();
                        while (!reader.EndOfStream)
                        {
                            data.Add(reader.ReadLine());
                        }
                        Series = new DynamicSeries(fields, data);
                        BraunSeries = new BraunModel(Series, (double)tbBeta.Value / 100, 10, 10);
                        LinearSeries = new LinearModel(Series, 0.3, 0.6, 0.8);
                        ExponentialSeries = new ExponentialModel(Series, 0.3, 0.6, 0.8);
                        ShowDynamicSeries();
                        ShowBrownModel();
                        ShowLinearModel();
                        ShowExponentialModel();
                    }
                }
            }
        }

        private void ShowDynamicSeries()
        {
            chDynamicSeries.Series[0].Points.Clear();
            chLinearModel.Series[0].Points.Clear();
            chExponentialModel.Series[0].Points.Clear();
            for (int i = 0; i < Series.AmountOfElements; i++)
            {
                chDynamicSeries.Series[0].Points.AddXY(i, Series.Value[i]);
                chLinearModel.Series[0].Points.AddXY(i, Series.Value[i]);
                chExponentialModel.Series[0].Points.AddXY(i, Series.Value[i]);
            }
        }

        private void ShowBrownModel()
        {
            chDynamicSeries.Series[1].Points.Clear();
            for (int i = 0; i < BraunSeries.NewValues.Count; i++)
            {
                chDynamicSeries.Series[1].Points.AddXY(i, BraunSeries.NewValues[i]);
            }
        }

        private void ShowLinearModel()
        {
            chLinearModel.Series[1].Points.Clear();
            for (int i = 0; i < BraunSeries.NewValues.Count; i++)
            {
                chLinearModel.Series[1].Points.AddXY(i, LinearSeries.NewValues[i]);
            }
        }

        private void ShowExponentialModel()
        {
            chExponentialModel.Series[1].Points.Clear();
            for (int i = 0; i < BraunSeries.NewValues.Count; i++)
            {
                chExponentialModel.Series[1].Points.AddXY(i, ExponentialSeries.NewValues[i]);
            }
        }

        private void tbBeta_ValueChanged(object sender, EventArgs e)
        {
            double beta = (double)tbBeta.Value / 100;
            BraunSeries = new BraunModel(Series, beta, 10, 10);
            ShowBrownModel();
        }

        private void tbLB1_ValueChanged(object sender, EventArgs e)
        {
            double b1 = (double)tbLB1.Value / 100;
            double b2 = (double)tbLB2.Value / 100;
            double b3 = (double)tbLB3.Value / 100;
            LinearSeries = new LinearModel(Series, b1, b2, b3);
            ShowLinearModel();
        }

        private void tbLB2_ValueChanged(object sender, EventArgs e)
        {
            double b1 = (double)tbLB1.Value / 100;
            double b2 = (double)tbLB2.Value / 100;
            double b3 = (double)tbLB3.Value / 100;
            LinearSeries = new LinearModel(Series, b1, b2, b3);
            ShowLinearModel();
        }

        private void tbLB3_ValueChanged(object sender, EventArgs e)
        {
            double b1 = (double)tbLB1.Value / 100;
            double b2 = (double)tbLB2.Value / 100;
            double b3 = (double)tbLB3.Value / 100;
            LinearSeries = new LinearModel(Series, b1, b2, b3);
            ShowLinearModel();
        }

        private void tbEB1_ValueChanged(object sender, EventArgs e)
        {
            double b1 = (double)tbEB1.Value / 100;
            double b2 = (double)tbEB2.Value / 100;
            double b3 = (double)tbEB3.Value / 100;
            ExponentialSeries = new ExponentialModel(Series, b1, b2, b3);
            ShowExponentialModel();
        }

        private void tbEB2_ValueChanged(object sender, EventArgs e)
        {
            double b1 = (double)tbEB1.Value / 100;
            double b2 = (double)tbEB2.Value / 100;
            double b3 = (double)tbEB3.Value / 100;
            ExponentialSeries = new ExponentialModel(Series, b1, b2, b3);
            ShowExponentialModel();
        }

        private void tbEB3_ValueChanged(object sender, EventArgs e)
        {
            double b1 = (double)tbEB1.Value / 100;
            double b2 = (double)tbEB2.Value / 100;
            double b3 = (double)tbEB3.Value / 100;
            ExponentialSeries = new ExponentialModel(Series, b1, b2, b3);
            ShowExponentialModel();
        }
    }
}
