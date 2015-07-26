using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonFuncs;

namespace CallingDLLUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long num1 = long.Parse(textBox1.Text);
            long num2 = long.Parse(textBox2.Text);

            long sum = AddClass.Add(num1, num2);
            long product = MultiplyClass.Multiply(num1, num2);
            float div = DivideClass.Divide(num1 / 1L, num2 / 1L);

            // System.Console.WriteLine("#1: {0}  #2: {1}", num1, num2);

            label3.Text = sum.ToString();
            label4.Text = product.ToString();
            label5.Text = div.ToString();
        }
    }
}
