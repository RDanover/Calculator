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
        int first = 0;
        int second = 0;

        char op;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Result.Text += btn.Content.ToString();
            second = Int32.Parse(Result.Text);
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            second = Int32.Parse(Result.Text);
            int result = 0;
            if (op == '+')
            {
                result = first + second;
            }
            else if(op == '-')
            {
                result = first - second;
            }
            else if(op == '*')
            {
                result = first * second;
            }
            else if (op == '/')
            {
                result = first / second;
            }
            if (Result.Text == "0")
            {
                Result.Clear();
            }
            Result.Text = result.ToString();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Result.Clear();
            op = ' ';
            first = 0;
            second = 0;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(Result.Text);
            op = '+';
            Result.Clear();
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(Result.Text);
            op = '-';
            Result.Clear();
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(Result.Text);
            op = '*';
            Result.Clear();
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(Result.Text);
            op = '/';
            Result.Clear();
        }
    }
}
