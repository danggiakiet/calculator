using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        float NumA, NumB;
        bool checkNumA = false;
        bool checkNumB = false;
        bool Operator = false;
        int countOperator;
        public Form1()
        {
            InitializeComponent();
        }

        private void bttNumber1_Click(object sender, EventArgs e)
        {
            if (!Operator)
            {
                txtResult.Text += "1";
                checkNumA = true;
                NumA = Convert.ToSingle(txtResult.Text);
            }
            else
            {
                txtResult.Text = "1";
                checkNumB = true;
                NumB = Convert.ToSingle(txtResult.Text);
                Operator = false;
            }
        }

        private void bttNumber2_Click(object sender, EventArgs e)
        {
            if (!Operator)
            {
                txtResult.Text += "2";
                checkNumA = true;
                NumA = Convert.ToSingle(txtResult.Text);
            }
            else
            {

                txtResult.Text = "2";
                checkNumB = true;
                NumB = Convert.ToSingle(txtResult.Text);
                Operator = false;
            }
        }

        private void bttNumber3_Click(object sender, EventArgs e)
        {
            if (!Operator)
            {
                txtResult.Text += "3";
                checkNumA = true;
                NumA = Convert.ToSingle(txtResult.Text);
            }
            else
            {

                txtResult.Text = "3";
                checkNumB = true;
                NumB = Convert.ToSingle(txtResult.Text);
                Operator = false;
            }
        }

        private void bttNumber4_Click(object sender, EventArgs e)
        {
            if (!Operator)
            {
                txtResult.Text += "4";
                checkNumA = true;
                NumA = Convert.ToSingle(txtResult.Text);
            }
            else
            {

                txtResult.Text = "4";
                checkNumB = true;
                NumB = Convert.ToSingle(txtResult.Text);
                Operator = false;
            }
        }

        private void bttNumber5_Click(object sender, EventArgs e)
        {
            if (!Operator)
            {
                txtResult.Text += "5";
                checkNumA = true;
                NumA = Convert.ToSingle(txtResult.Text);
            }
            else
            {

                txtResult.Text = "5";
                checkNumB = true;
                NumB = Convert.ToSingle(txtResult.Text);
                Operator = false;
            }
        }

        private void bttNumber6_Click(object sender, EventArgs e)
        {
            if (!Operator)
            {
                txtResult.Text += "6";
                checkNumA = true;
                NumA = Convert.ToSingle(txtResult.Text);
            }
            else
            {

                txtResult.Text = "6";
                checkNumB = true;
                NumB = Convert.ToSingle(txtResult.Text);
                Operator = false;
            }
        }

        private void bttNumber7_Click(object sender, EventArgs e)
        {
            if (!Operator)
            {
                txtResult.Text += "7";
                checkNumA = true;
                NumA = Convert.ToSingle(txtResult.Text);
            }
            else
            {

                txtResult.Text = "7";
                checkNumB = true;
                NumB = Convert.ToSingle(txtResult.Text);
                Operator = false;
            }
        }

        private void bttNumber8_Click(object sender, EventArgs e)
        {
            if (!Operator)
            {
                txtResult.Text += "8";
                checkNumA = true;
                NumA = Convert.ToSingle(txtResult.Text);
            }
            else
            {

                txtResult.Text = "8";
                checkNumB = true;
                NumB = Convert.ToSingle(txtResult.Text);
                Operator = false;
            }
        }

        private void bttNumber9_Click(object sender, EventArgs e)
        {
            if (!Operator)
            {
                txtResult.Text += "9";
                checkNumA = true;
                NumA = Convert.ToSingle(txtResult.Text);
            }
            else
            {

                txtResult.Text = "9";
                checkNumB = true;
                NumB = Convert.ToSingle(txtResult.Text);
                Operator = false;
            }
        }

        private void bttDivide_Click(object sender, EventArgs e)
        {
            Operator = true;   
            txtAns.Text += txtResult.Text;
            txtAns.Text += "/";
        }

        private void bttMultip_Click(object sender, EventArgs e)
        {
            Operator = true;
            txtAns.Text += txtResult.Text;
            txtAns.Text += "x";
        }

        private void bttMinus_Click(object sender, EventArgs e)
        {
            Operator = true;
            txtAns.Text += txtResult.Text;
            txtAns.Text += "-";
        }

        private void bttPlus_Click(object sender, EventArgs e)
        {
            Operator = true;
            countOperator++;
            txtAns.Text = txtResult.Text;
            txtAns.Text += "+";
            if (checkNumA && checkNumB)
            {
                txtResult.Text = Convert.ToString(NumA + NumB);
            }
            if (countOperator > 1)
            {
                NumA = Convert.ToSingle(txtResult.Text);
            }
        }
    }
}
