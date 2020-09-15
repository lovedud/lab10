using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab1CG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //возможные варианты функций на выбор пользователю
            comboBox1.Items.Add("sin");
            comboBox1.Items.Add("x^2");
        }

        //sqr
        public static double x2(double x)
        {
            return x * x;
        }

        //объявляем делегат функции,принимающий один аргумент типа double,возвращающий double
        public delegate double SomeDelegate(double x);

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            SomeDelegate funct1 = new SomeDelegate(Math.Sin);
            SomeDelegate funct2 = new SomeDelegate(x2);//передача синуса в делегат

            //имя функции,которую выбрал пользователь
            string func_name = comboBox1.Text;

            switch (func_name)
            {
                case "sin":
                    MathGraph(funct1);
                    break;
                case "x^2":
                    MathGraph(funct2);
                    break;
                default:
                    MathGraph(funct1);
                    break;
            }
        }

        private void MathGraph(SomeDelegate funct)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double step = 0.1;

            //!!!!!! Использует chart для вывода функции

            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(a, b);
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;


            for (double i = a; i <= b; i += step)
            {
                chart1.Series[0].Points.AddXY(i, funct(i));
            }

        }

    }
}
