using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form,MathInterface
    {
        public double result = 0;
        public char operand = '?'; 
        public string screen = "0";
        public string lastResult = " ";
        public char prevChar = ' ';
        public double? repeat = null;
        public bool waiting = false;
        //seperate by operand inside of parens using regex
        // pemdas order parens - mult - division
        //
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Reset()
        {
            result = 0;
            operand = '?';
            ResultScreen.ForeColor = Color.Silver;
            ResultScreen.Text = screen;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadChecker(char c)
        {

            if(ResultScreen.Text == lastResult && prevChar =='=')
                Reset();
            prevChar = c;
            if (ResultScreen.Text == screen || ResultScreen.Text == lastResult)
            {
                ResultScreen.Text = c.ToString();
                prevChar = c;
            }
            else
            {
                ResultScreen.Text += c;
                prevChar = c;
            }
             
         // if no parens -- && result is empty- result == input else result (oper) entry > (oper)/(calc) > entry =eq (show result)
         //   return (sb.Length<8 && sb && &&)
         // switch case - pass char to oper/or text? or both? 
         // indexOf('(') to close, len has to be greater than certain point)
         // if max len reached, can't add 
         // if parens open, cant compute
         // am I allowing e+/- 2.31094258 etc as an answer? idk how to do that yet. 5e+/- 2.5825        
         // regex decimal for result check? if it contians . && chars above limit || chars above limit? return 5e+/- etc
        }



        private void Calc(char operand, double number)
        {
            switch (operand)
            {
                case '+':
                    result = MathEx.Math.Add((double)result , (double)number);
                    lastResult = result.ToString();
                    ResultScreen.Text= lastResult;
                    break;
                case '-':
                    result = MathEx.Math.Subtract((double)result,(double)number);
                    lastResult = result.ToString();
                    ResultScreen.Text = lastResult;
                    break;
                case '*':
                    result = MathEx.Math.Multiply((double)result , (double)number);
                    lastResult = result.ToString();
                    ResultScreen.Text = lastResult;

                    break;
                case '/':
                    result = MathEx.Math.Divide((double)result , (double)number);
                    lastResult = result.ToString();
                    ResultScreen.Text = lastResult;
                    break;


            }
        }

        private void Update(char c)
        {
            
            double temp = double.Parse(ResultScreen.Text);
            
            if (result == 0 )
            {
                repeat = null;
                result = temp; operand = c; 
                lastResult = result.ToString();
                waiting = true;
            }
            
            else if (c == '=' && !"-+/*".Contains(prevChar))
            {
                repeat = temp;
                Calc(operand, temp);
                waiting = false;
            }
            else if(waiting == true && !"-+/*".Contains(prevChar))  
            {
                
                repeat = null;
                Calc(operand, temp); 
                operand = c;
                waiting = false;
            }
            else
            {
                repeat = null;
                operand = c;
                waiting = true;
            }
            prevChar = c;
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            //   Math.
            
            Reset();
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if(ResultScreen.Text != screen)
                Update('/');
               
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            if(ResultScreen.Text != screen)
                Update('*');
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (ResultScreen.Text != screen) 
                Update('-');
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (ResultScreen.Text != screen) 
                Update('+');
        }

        private void modulus_Click(object sender, EventArgs e)
        {
            if (ResultScreen.Text != screen)   //???????????
            {

            }
                Update('%');
        }

        private void rParen_Click(object sender, EventArgs e)
        {

        }

        private void lParen_Click(object sender, EventArgs e)
        {

        }

        private void seven_Click(object sender, EventArgs e)
        {
            LoadChecker('7');
        }

        private void eight_Click(object sender, EventArgs e)
        {
            LoadChecker('8');
        }

        private void nine_Click(object sender, EventArgs e)
        {
            LoadChecker('9');
        }

        private void four_Click(object sender, EventArgs e)
        {
            LoadChecker('4');
        }

        private void five_Click(object sender, EventArgs e)
        {
            LoadChecker('5');
        }

        private void six_Click(object sender, EventArgs e)
        {
            LoadChecker('6');
        }

        private void one_Click(object sender, EventArgs e)
        {
            LoadChecker('1');
        }

        private void two_Click(object sender, EventArgs e)
        {
            LoadChecker('2');
        }

        private void three_Click(object sender, EventArgs e)
        {
            LoadChecker('3');
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (ResultScreen.Text != screen) 
                LoadChecker('0');
        }

        private void deci_Click(object sender, EventArgs e)
        {
            if(!ResultScreen.Text.Contains('.'))
                LoadChecker('.');
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            //switch case? parser? for multiple parts I need a way to break it up. operands etc.
            if(repeat!=null)
                Calc(operand, (double)repeat);
            else Update('=');
        }

        public double Add(double num1, double num2)
        {
            return num1+num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1-num2;
        }

        double MathInterface.Divide(double num1, double num2)
        {
            return num2==0?num1:num1/num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1*num2;
        }



        // default screen is 0
        // no divisible by zero
        // adding keys to screen as pressed
        // refresh and update on calc complete
        // add queue for current result + new operator key / else clear current result
        // validator? - on key press run methods
        // erase leading zero's on key press?
        // cust? max key entries before it ignores keys?
        // ignore key validation? 
        // multiple operator ignore validation?
        // operation holding parameter / variable (like phase on old project)


    }
}
