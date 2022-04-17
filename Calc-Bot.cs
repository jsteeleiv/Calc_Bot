using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_Bot
{
    public partial class Form1 : Form
    {

        //char[] entry1;
        //char[] entry2;
        //StringBuilder entry1 = new StringBuilder();
        //StringBuilder entry2 = new StringBuilder();
        string op1;
        string op2;
        double operand1;
        double operand2;
        double result = 0.0;
        char symbol;
        bool isNegative = false;
        bool neg_op1 = false;
        bool neg_op2 = false;
        bool isFirstOp = true;


        public Form1()
        {
            InitializeComponent();
        }

        private void clearBox()
        {
            calc_display.Text = "0";
            op1 = "";
            op2 = "";
            isNegative = false;
            lbl_neg.Text = "";
            neg_op1 = false;
            neg_op2 = false;
            isFirstOp = true;
            calc_progress.Value = 0;
            calc_progress.Visible = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (isFirstOp) 
            {
                if (calc_display.Text == "0") 
                {
                    calc_display.Text = "0";
                    op1 = "0";
                }
                else
                {
                    calc_display.Text += "0";
                    op1 += "0";
                }  
            }
            else
            {
                if (calc_display.Text == "0")
                {
                    calc_display.Text = "0";
                    op2 = "0";
                }
                else
                {
                    calc_display.Text += "0";
                    op2 += "0";
                }
            }      
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (isFirstOp)
            {
                if (calc_display.Text == "0")
                {
                    calc_display.Text = "1";
                    op1 = "1";
                }
                else
                {
                    calc_display.Text += "1";
                    op1 += "1";
                }
            }
            else
            {
                if (calc_display.Text == "0")
                {
                    calc_display.Text = "1";
                    op2 = "1";
                }
                else
                {
                    calc_display.Text += "1";
                    op2 += "1";
                }
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (isFirstOp)
            {
                if (calc_display.Text == "0")
                {
                    calc_display.Text = "2";
                    op1 = "2";
                }
                else
                {
                    calc_display.Text += "2";
                    op1 += "2";
                }
            }
            else
            {
                if (calc_display.Text == "0")
                {
                    calc_display.Text = "2";
                    op2 = "2";
                }
                else
                {
                    calc_display.Text += "2";
                    op2 += "2";
                }
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (isFirstOp)
            {
                if (calc_display.Text == "0")
                {
                    calc_display.Text = "3";
                    op1 = "3";
                }
                else
                {
                    calc_display.Text += "3";
                    op1 += "3";
                }
            }
            else
            {
                if (calc_display.Text == "0")
                {
                    calc_display.Text = "3";
                    op2 = "3";
                }
                else
                {
                    calc_display.Text += "3";
                    op2 += "3";
                }
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (isFirstOp)
            {
                if (calc_display.Text == "0")
                {
                    calc_display.Text = "4";
                    op1 = "4";
                }
                else
                {
                    calc_display.Text += "4";
                    op1 += "4";
                }
            }
            else
            {
                if (calc_display.Text == "0")
                {
                    calc_display.Text = "4";
                    op2 = "4";
                }
                else
                {
                    calc_display.Text += "4";
                    op2 += "4";
                }
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (isFirstOp)
            {
                if (calc_display.Text == "0")
                {
                    calc_display.Text = "5";
                    op1 = "5";
                }
                else
                {
                    calc_display.Text += "5";
                    op1 += "5";
                }
            }
            else
            {
                if (calc_display.Text == "0")
                {
                    calc_display.Text = "5";
                    op2 = "5";
                }
                else
                {
                    calc_display.Text += "5";
                    op2 += "5";
                }
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (isFirstOp)
            {
                if (calc_display.Text == "0")
                {
                    calc_display.Text = "6";
                    op1 = "6";
                }
                else
                {
                    calc_display.Text += "6";
                    op1 += "6";
                }
            }
            else
            {
                if (calc_display.Text == "0")
                {
                    calc_display.Text = "6";
                    op2 = "6";
                }
                else
                {
                    calc_display.Text += "6";
                    op2 += "6";
                }
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (isFirstOp)
            {
                if (calc_display.Text == "0")
                {
                    calc_display.Text = "7";
                    op1 = "7";
                }
                else
                {
                    calc_display.Text += "7";
                    op1 += "7";
                }
            }
            else
            {
                if (calc_display.Text == "0")
                {
                    calc_display.Text = "7";
                    op2 = "7";
                }
                else
                {
                    calc_display.Text += "7";
                    op2 += "7";
                }
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (isFirstOp)
            {
                if (calc_display.Text == "0")
                {
                    calc_display.Text = "8";
                    op1 = "8";
                }
                else
                {
                    calc_display.Text += "8";
                    op1 += "8";
                }
            }
            else
            {
                if (calc_display.Text == "0")
                {
                    calc_display.Text = "8";
                    op2 = "8";
                }
                else
                {
                    calc_display.Text += "8";
                    op2 += "8";
                }
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (isFirstOp)
            {
                if (calc_display.Text == "0")
                {
                    calc_display.Text = "9";
                    op1 = "9";
                }
                else
                {
                    calc_display.Text += "9";
                    op1 += "9";
                }
            }
            else
            {
                if (calc_display.Text == "0")
                {
                    calc_display.Text = "9";
                    op2 = "9";
                }
                else
                {
                    calc_display.Text += "9";
                    op2 += "9";
                }
            }
        }

        private void btn_neg_Click(object sender, EventArgs e)
        {
            isNegative = !isNegative;
            if (isNegative)
            {
                lbl_neg.Text = "_";
                if (isFirstOp)
                    neg_op1 = true;
                else
                    neg_op2 = true;
            }
            else 
            {
                lbl_neg.Text = "";
                if (isFirstOp)
                    neg_op1 = false;
                else
                    neg_op2 = false;
            }
            
                

        }

        private void btn_dec_Click(object sender, EventArgs e)
        {
            calc_display.Text += ".";
            if (isFirstOp)
                op1 += ".";
            else
                op2 += ".";
            /*
            if (calc_display.Text == "0")
            {
                calc_display.Text = "0";
                op1 = "0";
            }
            else
            {
                calc_display.Text += "0";
                op1 += "0";
            }
            */
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            symbol = '+'; // assign the symbol for the switch cases
            op1 = calc_display.Text; // capture the users input as first operand 
            calc_display.Text = ""; // clear the text in the display

            //check for negative value
            if (isNegative)
                neg_op1 = true;

            //debugging
            if(neg_op1)
                opDisplay1.Text = "-" + op1.ToString();
            else
                opDisplay1.Text = op1.ToString();

            //reset negative check
            isNegative = false;
            lbl_neg.Text = "";

            //switch to second operand to save new inputs which will be saved upon clicking `=`
            isFirstOp = false;

        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            symbol = '-'; // assign the symbol for the switch cases
            op1 = calc_display.Text; // capture the users input as first operand 
            calc_display.Text = ""; // clear the text in the display

            //check for negative value
            if (isNegative)
                neg_op1 = true;

            //debugging
            if (neg_op1)
                opDisplay1.Text = "-" + op1.ToString();
            else
                opDisplay1.Text = op1.ToString();

            //reset negative check
            isNegative = false;
            lbl_neg.Text = "";

            //switch to second operand to save new inputs which will be saved upon clicking `=`
            isFirstOp = false;
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            symbol = '*'; // assign the symbol for the switch cases
            op1 = calc_display.Text; // capture the users input as first operand 
            calc_display.Text = ""; // clear the text in the display

            //check for negative value
            if (isNegative)
                neg_op1 = true;

            //debugging
            if (neg_op1)
                opDisplay1.Text = "-" + op1.ToString();
            else
                opDisplay1.Text = op1.ToString();

            //reset negative check
            isNegative = false;
            lbl_neg.Text = "";

            //switch to second operand to save new inputs which will be saved upon clicking `=`
            isFirstOp = false;
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            symbol = '/'; // assign the symbol for the switch cases
            op1 = calc_display.Text; // capture the users input as first operand 
            calc_display.Text = ""; // clear the text in the display

            //check for negative value
            if (isNegative)
                neg_op1 = true;

            //debugging
            if (neg_op1)
                opDisplay1.Text = "-" + op1.ToString();
            else
                opDisplay1.Text = op1.ToString();

            //reset negative check
            isNegative = false;
            lbl_neg.Text = "";

            //switch to second operand to save new inputs which will be saved upon clicking `=`
            isFirstOp = false;
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            symbol = '%'; // assign the symbol for the switch cases
            op1 = calc_display.Text; // capture the users input as first operand 
            calc_display.Text = ""; // clear only the text in the display

            //check for negative value
            if (isNegative)
                neg_op1 = true;

            //debugging
            if (neg_op1)
                opDisplay1.Text = "-" + op1.ToString();
            else
                opDisplay1.Text = op1.ToString();

            //reset negative check
            isNegative = false;
            lbl_neg.Text = "";

            //switch to second operand to save new inputs which will be saved upon clicking `=`
            isFirstOp = false;
        }

        private void btn_eql_Click(object sender, EventArgs e)
        {
            if (operand1 == 0 && operand2 == 0)
                result = 0;


            //// a silly attempt at a clunky progress bar for a visual effect
            //calc_progress.Visible = true;
            //for (int i = 1; i <= 100; i++)
            //{
            //    Thread.Sleep(1);
            //    calc_progress.Value = i;
            //}
            //calc_progress.Visible = false;



            op2 = calc_display.Text; // capture input into second operand
            calc_display.Text = ""; // clear only the text in the display

            //check for negative value
            if (isNegative)
                neg_op2 = true;

            //debugging
            if (neg_op2)
                opDisplay1.Text = "-" + op2.ToString();
            else
                opDisplay2.Text = op2.ToString();

            

            switch (symbol)
            {
                case '+':
                    operand1 = float.Parse(op1.ToString());
                    operand2 = float.Parse(op2.ToString());
                    if (neg_op1)
                        operand1 *= -1;
                    else if (neg_op2)
                        operand2 *= -1;
                    result = operand1 + operand2;
                    calc_display.Text = result.ToString();
                    lbl_neg.Text = "";
                    isNegative = false;
                    isFirstOp = true;
                    break;

                case '-':
                    operand1 = float.Parse(op1.ToString());
                    operand2 = float.Parse(op2.ToString());
                    if (neg_op1)
                        operand1 *= -1;
                    else if (neg_op2)
                        operand2 *= -1;
                    result = operand1 - operand2;
                    calc_display.Text = result.ToString();
                    lbl_neg.Text = "";
                    isNegative = false;
                    isFirstOp = true;
                    break;

                case '*':
                    operand1 = float.Parse(op1.ToString());
                    operand2 = float.Parse(op2.ToString());
                    if (neg_op1)
                        operand1 *= -1;
                    else if (neg_op2)
                        operand2 *= -1;
                    result = operand1 * operand2;
                    calc_display.Text = result.ToString();
                    lbl_neg.Text = "";
                    isNegative = false;
                    isFirstOp = true;
                    break;

                case '/':
                    operand1 = float.Parse(op1.ToString());
                    operand2 = float.Parse(op2.ToString());
                    if (neg_op1)
                        operand1 *= -1;
                    else if (neg_op2)
                        operand2 *= -1;
                    result = operand1 / operand2;
                    calc_display.Text = result.ToString();
                    lbl_neg.Text = "";
                    isNegative = false;
                    isFirstOp = true;
                    break;

                case '%':
                    operand1 = int.Parse(op1.ToString());
                    operand2 = int.Parse(op2.ToString());
                    if (neg_op1)
                        operand1 *= -1;
                    else if (neg_op2)
                        operand2 *= -1;
                    result = operand1 % operand2;
                    calc_display.Text = result.ToString();
                    lbl_neg.Text = "";
                    isNegative = false;
                    isFirstOp = true;
                    break;
            }//end switch
        }//end btn_eql_Click event

        private void btn_clrEntry_Click(object sender, EventArgs e)
        {

        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            clearBox();
        }

        private void calc_progress_Click(object sender, EventArgs e)
        {
            
        }

        private void opDisplay2_Click(object sender, EventArgs e)
        {

        }
    }
}
