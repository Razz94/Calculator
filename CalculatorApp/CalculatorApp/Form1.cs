using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double result = 0;
        public string operation, prevOperation, prevEquation = ""; 

        public void clickAll(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            try
            {
                switch (btn.Name)
                {
                    case "btnDel":
                        if (mainDisplay.Text.Length > 0)
                        {
                            mainDisplay.Text = mainDisplay.Text.Substring(0, mainDisplay.TextLength - 1);
                        }
                        break;

                    case "btnC":
                        mainDisplay.ResetText();
                        secondaryDisplay.ResetText();
                        operation = "";
                        break;

                    case "btnCE":
                        mainDisplay.ResetText();
                        break;

                    case "btnPlusMinus":
                        if (mainDisplay.Text.Contains("-"))
                        {
                            mainDisplay.Text = mainDisplay.Text.Substring(1, mainDisplay.Text.Length - 1);
                        }
                        else
                        {
                            mainDisplay.Text = "-" + mainDisplay.Text;
                        }
                        break;

                    case "btnComma":
                        if (!mainDisplay.Text.Contains(","))
                        {
                            mainDisplay.Text = mainDisplay.Text + ",";
                        }
                        break;

                    default:
                        if(operation == "=")
                        {
                            operation = "";
                            mainDisplay.ResetText(); 
                        }
                        mainDisplay.Text += btn.Text;
                        break;
                }
            }
            catch
            {
                Console.WriteLine("You have not pressed a valid key");
            }
            
        }

        public void ClickOperation(object sender, EventArgs e)
        {
            Button opr = sender as Button;
            switch (opr.Text)
            {
                case "+":

                    operation = "+";
                    prevOperation = operation;
                    prevEquation = mainDisplay.Text;
                    secondaryDisplay.Text = prevEquation + operation;
                    mainDisplay.ResetText(); 
                    break;

                case "-":
                    operation = "-";
                    prevOperation = operation;
                    prevEquation = mainDisplay.Text;
                    secondaryDisplay.Text = prevEquation + operation;
                    mainDisplay.ResetText();
                    break;

                case "x":
                    operation = "x";
                    prevOperation = operation;
                    prevEquation = mainDisplay.Text;
                    secondaryDisplay.Text = prevEquation + operation;
                    mainDisplay.ResetText();
                    break;

                case "/":
                    operation = "/";
                    prevOperation = operation;
                    prevEquation = mainDisplay.Text;
                    secondaryDisplay.Text = prevEquation + operation;
                    mainDisplay.ResetText();
                    break;

                case "=":
                    DoTheMath();
                    break; 
            }
        }

        public void DoTheMath()
        {
            try
            {
                switch (prevOperation)
                {
                    case "+":
                        result = Convert.ToDouble(prevEquation) + Convert.ToDouble(mainDisplay.Text);
                        prevEquation = result.ToString();
                        secondaryDisplay.Text = prevEquation;
                        mainDisplay.ResetText();
                        break;

                    case "-":
                        result = Convert.ToDouble(prevEquation) - Convert.ToDouble(mainDisplay.Text);
                        prevEquation = result.ToString();
                        secondaryDisplay.Text = prevEquation;
                        mainDisplay.ResetText();
                        break;

                    case "x":
                        result = Convert.ToDouble(prevEquation) * Convert.ToDouble(mainDisplay.Text);
                        prevEquation = result.ToString();
                        secondaryDisplay.Text = prevEquation;
                        mainDisplay.ResetText();
                        break;

                    case "/":
                        if (mainDisplay.Text.Equals("0"))
                        {
                            mainDisplay.Text = "You cannot divide by zero";
                            secondaryDisplay.ResetText();
                        }
                        else
                        {
                            result = Convert.ToDouble(prevEquation) / Convert.ToDouble(mainDisplay.Text);
                            prevEquation = result.ToString();
                            secondaryDisplay.Text = prevEquation;
                            mainDisplay.ResetText();
                        }
                        break;
                }
            }
            catch
            {
                mainDisplay.ResetText();
                secondaryDisplay.ResetText(); 
            }
            
                
        }
        
        
    }
}
