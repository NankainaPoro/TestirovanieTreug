using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TreygolVak
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LenA.Text == "" || LenB.Text == "" || LenC.Text == "")
            {
                Result.Text = "Введите стороны!";
                Result.Visible = true;
                return;
            }
            // else if (LenA.Text == || LenB.Text == "" || LenC.Text == "")
            //{ }

            try
            {
                Convert.ToDouble(LenA.Text);
                Convert.ToDouble(LenB.Text);
                Convert.ToDouble(LenC.Text);
            }
            catch
            {
                Result.Text = "Введите стороны корректно!";
                Result.Visible = true;
                return;
            }

            double a = Convert.ToDouble(LenA.Text);
            double b = Convert.ToDouble(LenB.Text);
            double c = Convert.ToDouble(LenC.Text);
            double d = a;


            if (b > d)
                d = b;
            if (c > d)
                d = c;


            if (a + b <= d || b + c <= d || a + c <= d)
            {
                Result.Text = ("Треугольника не существует");
            }
            else if (a == b && b == c)
            {
                Result.Text = "Треугольник равносторонний";
            }
            else if (a == b || a == c || b == c)
            {
                Result.Text = "Треугольник равнобедренный";
            }
            else
            {
                Result.Text = ("Треугольник разносторонний");
            }

            Result.Visible = true;







        }

        private void LenA_TextChanged(object sender, EventArgs e)
        {
            //if (LenA.Text.Length == 0 || LenB.Text.Length == 0 || LenC.Text.Length == 0)
            //{
            //    button1.Enabled = false;
            //}
            //else button1.Enabled = true;
        }

        private void LenB_TextChanged(object sender, EventArgs e)
        {

        }

        private void LenC_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LenA.Clear();
            LenB.Clear();
            LenC.Clear();
            Result.Text = "";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
