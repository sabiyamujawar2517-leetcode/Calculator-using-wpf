using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long number1 = 0;
        long number2 = 0;
        string operation = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {

            //to incere the button click like unit,decimal,hundarnd,thounsand..
            if(operation == "") {
                number1 = (number1 * 10) + 1;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                txtDisplay.Text = number2.ToString();
            }
          

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtDisplay.Text = "0";
        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txtDisplay.Text = "0";

        }

        private void btn_mutli_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            txtDisplay.Text = "0";
        }

        private void btn_divide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txtDisplay.Text = "0";
        }
        private void btn_mod_Click(object sender, RoutedEventArgs e)
        {
            operation = "%";
            txtDisplay.Text = "0";
        }

        private void btn_equal_Click(object sender, RoutedEventArgs e)
        {
            switch(operation)
            {
                case "+":
                    txtDisplay.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (number1 / number2).ToString();
                    break;
                case "%":
                    txtDisplay.Text = (number1 % number2).ToString();
                    break;
                case "Sinh":
                    if (operation == "")
                        txtDisplay.Text = (Math.Sin(double.Parse(txtDisplay.Text))).ToString();
                    else if (number1 != 0 && operation != "" && number2 == 0)
                        txtDisplay.Text = (Math.Sin(double.Parse(number1.ToString()))).ToString();
                    else
                    {
                        number2 = (long)decimal.Parse(txtDisplay.Text);
                        //////////////////////////////// 
                        switch (operation)
                        {
                            case "+":
                                txtDisplay.Text = (number1 + number2).ToString();
                                break;
                            case "-":
                                txtDisplay.Text = (number1 - number2).ToString();
                                break;
                            case "×":
                                txtDisplay.Text = (number1 * number2).ToString();
                                break;
                            case "÷":
                                txtDisplay.Text = (number1 / number2).ToString();
                                break;

                            case "Mod":
                                txtDisplay.Text = (number1 % number2).ToString();
                                break;
                        }

                        txtDisplay.Text = (Math.Sin(double.Parse(txtDisplay.Text))).ToString();
                    } break;

            }
        }

        private void btnClearentry_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                number1 = 0;
               
            }
            else
            {
                number1 = 0;
               
            }
            txtDisplay.Text = "0";
        }

        private void btnclearAll_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            txtDisplay.Text = "0";
        }

        private void btnspacechange_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 / 10);
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 / 10);
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btnpositivenegative_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 += -1;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 += -1;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn_sinh_Click(object sender, RoutedEventArgs e)
        {
            operation = "Sinh";
            txtDisplay.Text = "0";
        }

        private void btn_cosh_Click(object sender, RoutedEventArgs e)
        {
            operation = "Cosh";
            txtDisplay.Text = "0";
        }
    }
}