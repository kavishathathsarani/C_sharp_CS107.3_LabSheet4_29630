using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q_5
{
    public partial class Form1 : Form
    {
        public int num1;
        public int num2;
        public int answer;
        string operation = "";
        double result_value = 0;
        bool is_Operation_Performed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Operation_Performed(object sender, EventArgs e)
        {
            try
            {
                if (result_value != 0)
                {
                    button14.PerformClick();
                    Button btn = (Button)sender;
                    operation = btn.Text;
                    result_value = double.Parse(txtResult.Text);
                    label1.Text = result_value + operation;
                    is_Operation_Performed = true;
                }
                else
                {
                    Button btn = (Button)sender;
                    operation = btn.Text;
                    result_value = double.Parse(txtResult.Text);
                    label1.Text = result_value + operation;
                    is_Operation_Performed = true;
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Enter Valid number", "Error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(txtResult.Text=="0"|| is_Operation_Performed)
            {
                txtResult.Clear();
            }
            Button btn = (Button)sender;

            if (btn.Text == ".")
            {
                if (!txtResult.Text.Contains("."))
                {
                    txtResult.Text = txtResult + btn.Text;
                }
            }
            else
            {
                txtResult.Text= txtResult.Text+btn.Text;
            }
            is_Operation_Performed = false;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            label1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        { 
         //num2 = Convert.ToInt32(txtResult.Text);

            switch (operation)
            {
                case "+":
                    txtResult.Text = (result_value + double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (result_value - double.Parse(txtResult.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = (result_value * double.Parse(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (result_value / double.Parse(txtResult.Text)).ToString();
                    break;
            }

           //txtResult.Text = answer.ToString();
        }
    }
}
