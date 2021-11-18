using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void USD_Click(object sender, EventArgs e)
        {
            int[] years = new int[21] { 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020 };
            double[] data = new double[21] { 28.16, 29.17, 31.36, 30.67, 28.81, 28.30, 27.19, 25.58, 24.85, 31.85, 30.34, 29.39, 31.09, 31.82, 38.33, 61.15, 66.96, 58.25, 62.78, 64.55, 72.13 };

            for (int i = 0; i < years.Length; i++)
                chart1.Series["Курс доллара"].Points.AddXY(years[i], data[i]);

            chart1.ChartAreas[0].AxisX.Minimum = 2000;
            chart1.ChartAreas[0].AxisX.Maximum = 2020;

            chart1.ChartAreas[0].AxisY.Minimum = 20;
            chart1.ChartAreas[0].AxisY.Maximum = 80;

        }

        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выберите кнопку со значением, график которого Вы хотите увидеть.\n\nSimpleGraphics\nver 1.0, 2021", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
