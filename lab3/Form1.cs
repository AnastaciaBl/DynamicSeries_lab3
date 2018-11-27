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
                        ShowDynamicSeries();
                        BraunModel bm = new BraunModel(Series, 0.5, 0.5);
                    }
                }
            }
        }

        private void ShowDynamicSeries()
        {
            chDynamicSeries.Series[0].Points.Clear();
            for (int i = 0; i < Series.AmountOfElements; i++)
            {
                chDynamicSeries.Series[0].Points.AddXY(Series.Index[i], Series.Value[i]);
            }
        }
    }
}
