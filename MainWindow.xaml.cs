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


        Caculate caculate = new Caculate();
        int operators = -1;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Select_Operator(int _operator)
        {
            caculate.firstNumber = Convert.ToSingle(txtNumber.Text); 
            txtNumber.Text = "0"; 
            operators = _operator; 
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Select_Operator(0);
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            Select_Operator(1);
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            Select_Operator(2);
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            Select_Operator(3);
        }
        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            float finalResults = 0f; 
            caculate.secondNumber = Convert.ToSingle(txtNumber.Text); 

            
            switch (operators)
            {
                case 0:
                    finalResults = caculate.Add();
                    break;
                case 1:
                    finalResults = caculate.Subtract();
                    break;
                case 2:
                    finalResults = caculate.Multiply();
                    break;
                case 3:
                    finalResults =caculate.Divide();
                    break;
            }

            txtNumber.Text = string.Format("{0:0.##########}", finalResults);

            caculate.Reset();
        }
        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
           
            if (txtNumber.Text.IndexOf(".") == -1)
                txtNumber.Text = txtNumber.Text + ".";
        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtNumber.Text = "0";
            caculate.Reset();
        }
        private void Add_Number(string _number)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text = txtNumber.Text + _number;
        }
        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("0");
        }
        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("1");
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("2");
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("3");
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("4");
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("5");
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("6");
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("7");
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("8");
        }

        private void btnNime_Click(object sender, RoutedEventArgs e)
        {
            Add_Number("9");
        }

        private void btnPercent_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text.Length > 1)
            {
                float result;
                result = Convert.ToSingle(txtNumber.Text);
                txtNumber.Text = string.Format("{0:0.####}", result / 100);
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text.Length >1)
            {
                txtNumber.Text =txtNumber.Text.Substring(0, txtNumber.Text.Length - 1);
            }
            else if (txtNumber.Text.Length==1)
            {
                txtNumber.Text = "0";
            }
        }
    }
    
}
