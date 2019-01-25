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

namespace OhmLawCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            bool[] equation = new bool[3];
            
            InitializeComponent();
        }

        private void Radio_Button_Voltage_Checked(object sender, RoutedEventArgs e)
        {
            
            TextBox_Voltage.IsReadOnly = true;
            TextBox_Resistance.IsReadOnly = false;
            TextBox_Current.IsReadOnly = false;
            TextBox_Voltage.Background = Brushes.Gray;
            TextBox_Resistance.Background = Brushes.WhiteSmoke;
            TextBox_Current.Background = Brushes.WhiteSmoke;
           
        }

        private void Radio_Button_Resistance_Checked(object sender, RoutedEventArgs e)
        {
           
            TextBox_Voltage.IsReadOnly = false;
            TextBox_Resistance.IsReadOnly = true;
            TextBox_Current.IsReadOnly = false;
            TextBox_Voltage.Background = Brushes.WhiteSmoke;
            TextBox_Resistance.Background = Brushes.Gray;
            TextBox_Current.Background = Brushes.WhiteSmoke;
            
        }

        private void Radio_Button_Current_Checked(object sender, RoutedEventArgs e)
        {
            
            TextBox_Voltage.IsReadOnly = false;
            TextBox_Resistance.IsReadOnly = false;
            TextBox_Current.IsReadOnly = true;
            TextBox_Voltage.Background = Brushes.WhiteSmoke;
            TextBox_Resistance.Background = Brushes.WhiteSmoke;
            TextBox_Current.Background = Brushes.Gray;
           
            
        }

        private void GetEquation(bool[] equation)
        {
            double R, A, V;
            if (Radio_Button_Voltage.IsChecked.Value)
            {
                double.TryParse(TextBox_Current.Text, out A);
                double.TryParse(TextBox_Resistance.Text, out R);
                V = A * R;
                TextBox_Voltage.Text = V.ToString();
            }
            else if (Radio_Button_Resistance.IsChecked.Value)
            {
                double.TryParse(TextBox_Voltage.Text, out V);
                double.TryParse(TextBox_Current.Text, out A);
                R = V / A;
                TextBox_Resistance.Text = R.ToString();
            }
            else if (Radio_Button_Current.IsChecked.Value)
            {
                double.TryParse(TextBox_Voltage.Text, out V);
                double.TryParse(TextBox_Resistance.Text, out R);
                A= V /R;
                TextBox_Resistance.Text = A.ToString();
            }
        }
    }
}
