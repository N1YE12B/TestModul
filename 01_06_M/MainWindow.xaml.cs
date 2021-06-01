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

namespace _01_06_M
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Count_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToInt32(Value1.Text);
            double b = Convert.ToInt32(Value2.Text);

            if (Actions.SelectedIndex == 0)
            {
                
                double result = Summ.Sum(a, b);
                Result.Text = result.ToString();
            }
            if (Actions.SelectedIndex == 1)
            {

                double result = Subtr.Sub(a, b);
                Result.Text = result.ToString();
            }
            if (Actions.SelectedIndex == 2)
            {
                

                double result = Multi.Mult(a, b);
                Result.Text = result.ToString();
            }
            if (Actions.SelectedIndex == 3)
            {
                

                double result = Dividing.Div(a, b);
                Result.Text = result.ToString();
            }
            if (Actions.SelectedIndex == 4)
            {
               

                double result = MathPow.Pow(a, b);
                Result.Text = result.ToString();
            }







        }
    }
}
