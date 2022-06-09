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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result;
        SelectedOperator selectedOperator;

        public MainWindow()
        {
            InitializeComponent();
            //resultLabel.Content = "0";
            acButton.Click += AcButton_Click;
            negativeButton.Click += NegativeButton_Click;
            percentageButton.Click += PercentageButton_Click;
            resButton.Click += ResButton_Click;
        }

        private void ResButton_Click(object sender, RoutedEventArgs e)
        {
            double newNumber = double.Parse(resultLabel.Content.ToString());
            switch (selectedOperator)
            {
                case SelectedOperator.Addition:
                    result = SimpleMath.Add(lastNumber, newNumber);
                    break;
                case SelectedOperator.Substraction:
                    result = SimpleMath.Sub(lastNumber, newNumber);
                    break;
                case SelectedOperator.Mulitplication:
                    result = SimpleMath.Mul(lastNumber, newNumber);
                    break;
                case SelectedOperator.Division:
                    result = SimpleMath.Div(lastNumber, newNumber);
                    break;
            }

            resultLabel.Content = result.ToString();
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            lastNumber = double.Parse(resultLabel.Content.ToString());
            resultLabel.Content = "0";
            //if(sender == divButton)

            if (sender == mulButton)
                selectedOperator = SelectedOperator.Mulitplication;
            if (sender == divButton)
                selectedOperator = SelectedOperator.Division;
            if (sender == plusButton)
                selectedOperator = SelectedOperator.Addition;
            if (sender == subButton)
                selectedOperator = SelectedOperator.Substraction;

        }

        private void PercentageButton_Click(object sender, RoutedEventArgs e)
        {
            lastNumber = double.Parse(resultLabel.Content.ToString());
            lastNumber /= 100;
            resultLabel.Content = lastNumber.ToString();
        }

        private void NegativeButton_Click(object sender, RoutedEventArgs e)
        {
            lastNumber =  -double.Parse(resultLabel.Content.ToString());
            resultLabel.Content = lastNumber.ToString();
        }

        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }

        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            if(resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "7";
            }
            else
            {
                resultLabel.Content += "7";
            }

        }

        private void eightButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "8";
            }
            else
            {
                resultLabel.Content += "8";
            }
        }

        private void nineButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "9";
            }
            else
            {
                resultLabel.Content += "9";
            }
        }


        private void fourButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "4";
            }
            else
            {
                resultLabel.Content += "4";
            }
        }

        private void fiveButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "5";
            }
            else
            {
                resultLabel.Content += "5";
            }
        }

        private void sixButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "6";
            }
            else
            {
                resultLabel.Content += "6";
            }
        }


        private void oneButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "1";
            }
            else
            {
                resultLabel.Content += "1";
            }
        }

        private void twoButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "2";
            }
            else
            {
                resultLabel.Content += "2";
            }
        }

        private void threeButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "3";
            }
            else
            {
                resultLabel.Content += "3";
            }
        }

        private void decButton_Click(object sender, RoutedEventArgs e)
        {
            if (!resultLabel.Content.ToString().Contains("."))
                resultLabel.Content = $"{resultLabel.Content}.";

        }

        private void zeroButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "0";
            }
            else
            {
                resultLabel.Content += "0";
            }
        }

    }

    public enum SelectedOperator
    {
        Addition,
        Substraction,
        Mulitplication,
        Division

    }
    public class SimpleMath
    {
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Sub(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Mul(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Div(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
