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

namespace Calculator
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        float firstNumber, secondNumber; 
        int operators = -1;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text); 
            txtNumber.Text = "0"; 
            operators = 0; 
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "0";
            operators = 1; 
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "0";
            operators = 2; 
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "0";
            operators = 3; 
        }
        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            float finalResults = 0f; 
            secondNumber = Convert.ToSingle(txtNumber.Text); 

            
            switch (operators)
            {
                case 0:
                    finalResults = firstNumber + secondNumber;
                    break;
                case 1:
                    finalResults = firstNumber - secondNumber;
                    break;
                case 2:
                    finalResults = firstNumber * secondNumber;
                    break;
                case 3:
                    finalResults = firstNumber / secondNumber;
                    break;
            }

            txtNumber.Text = string.Format("{0:0.##########}", finalResults); 
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }
        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
           
            if (txtNumber.Text.IndexOf(".") == -1)
                txtNumber.Text = txtNumber.Text + ".";
        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtNumber.Text = "0";
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }
        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = " ";
                txtNumber.Text += "0";
            }
            
        }
        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = " ";               
            }
            txtNumber.Text += "1";
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";              
            }
            txtNumber.Text += "2";
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";               
            }
            txtNumber.Text += "3";
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";              
            }
            txtNumber.Text += "4";
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";             
            }
            txtNumber.Text += "5";
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";              
            }
            txtNumber.Text += "6";
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";             
            }
            txtNumber.Text += "7";
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";               
            }
            txtNumber.Text += "8";
        }


        private void btnNime_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";              
            }
            txtNumber.Text += "9";
        }
    }
}
