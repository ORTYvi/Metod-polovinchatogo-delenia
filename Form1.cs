using System;

namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            string y = textBox2.Text;

            double a  = Convert.ToDouble(x);
            double b = Convert.ToDouble(y);

            double  c, d, z, f;

            for (double i = (a + b) / 2; i > 0.001; i--)
            {
                c = (2 * Math.Round(Math.Log10(a + 7), 4)) - Math.Round(5 * (Math.Round(Math.Sin(a * Math.PI / 180), 4)), 4);
                d = (2 * Math.Round(Math.Log10(b + 7), 4)) - Math.Round(5 * (Math.Round(Math.Sin(b * Math.PI / 180), 4)), 4);
                f = (a + b) / 2;
                z = (2 * Math.Round(Math.Log10(f + 7), 4)) - Math.Round(5 * (Math.Round(Math.Sin(f * Math.PI / 180), 4)), 4);

                if (z > 0 && d < 0)
                {
                    a = f;
                }
                else
                {
                    b = f;
                }
                richTextBox1.Text += f + Environment.NewLine;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}