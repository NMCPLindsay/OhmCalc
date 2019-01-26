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

        private void GetEquationResult()
        {
            double R, A, V;
            bool validRes = false;
            bool validAmp = false;
            bool validVolt = false;



            if (Radio_Button_Voltage.IsChecked.Value)
            {
                while (!validRes || !validAmp)
                {
                    if (double.TryParse(TextBox_Current.Text, out A) && double.TryParse(TextBox_Resistance.Text, out R))
                    {
                        validRes = true;
                        validAmp = true;                        
                        V = A * R;
                        TextBox_Voltage.Text = V.ToString();
                        validVolt = true;
                    }
                    else if (!double.TryParse(TextBox_Current.Text, out A))
                    {
                        validRes = true;
                        validAmp = true;
                        MessageBox.Show("Please enter valid number for Current.");
                    }
                    else if (!double.TryParse(TextBox_Resistance.Text, out R))
                    {
                        validRes = true;
                        validAmp = true;
                        MessageBox.Show("Please enter valid number for Resistance.");
                    }
             
                }
                
                
                
            }
            else if (Radio_Button_Resistance.IsChecked.Value)
            {

                while (!validVolt || !validAmp)
                {
                    if (double.TryParse(TextBox_Current.Text, out A) && double.TryParse(TextBox_Voltage.Text, out V))
                    {
                        validVolt = true;
                        validAmp = true;
                        R = V / A;
                        TextBox_Resistance.Text = R.ToString();
                        validRes = true;
                    }
                    else if (!double.TryParse(TextBox_Current.Text, out A))
                    {
                        validVolt = true;
                        validAmp = true;
                        MessageBox.Show("Please enter valid number for Current.");
                    }
                    else if (!double.TryParse(TextBox_Voltage.Text, out V))
                    {
                        validVolt = true;
                        validAmp = true;
                        MessageBox.Show("Please enter valid number for Voltage.");
                    }

                }
               
                
                
            }
            else if (Radio_Button_Current.IsChecked.Value)
            {
                while (!validVolt || !validAmp)
                {
                    if (double.TryParse(TextBox_Resistance.Text, out R) && double.TryParse(TextBox_Voltage.Text, out V))
                    {
                        validVolt = true;
                        validAmp = true;
                       A = V / R;
                        TextBox_Current.Text = A.ToString();
                        validRes = true;
                    }
                    else if (!double.TryParse(TextBox_Resistance.Text, out R))
                    {
                        validVolt = true;
                        validAmp = true;
                        MessageBox.Show("Please enter valid number for Resistance.");
                    }
                    else if (!double.TryParse(TextBox_Voltage.Text, out V))
                    {
                        validVolt = true;
                        validAmp = true;
                        MessageBox.Show("Please enter valid number for Voltage.");
                    }

                }
                
               
                
            }
            else
            {
                MessageBox.Show("Please select equation."); 
            }
        }

        private void Button_Calculate_Click(object sender, RoutedEventArgs e)
        {
            GetEquationResult();
        }



        private void Button_Safe_Check_Click( object sender, RoutedEventArgs e)
        {

            string battery = ComboBox_Battery.SelectionBoxItem as string;
            double battAMP = 0;
            switch (battery)
            {
                //case "Add a Battery":
                //    Batteries batt = new Batteries();
                //    batt.ShowDialog();
                //    break;
                case "20 Amp Battery":
                    battAMP = 20;
                    break;
                case "30 Amp Battery":
                    battAMP = 30;
                    break;
                default:
                    battAMP = 0;
                    break;
            }
            if (battAMP>double.Parse(TextBox_Current.Text.ToString()))
            {
                
                Label_Safe.Content = "Battery is safe";
                Label_Safe.Foreground = Brushes.Green;
            }
            else if (battAMP<double.Parse(TextBox_Current.Text.ToString()))
            {
                
                Label_Safe.Content = "Battery is unstable with this setting.";
                Label_Safe.Foreground = Brushes.Red;
            }
        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Help_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.ShowDialog();
        }
        //private void ImportBatteryList(List<Battery> batteries)
        //{
        //    foreach (Battery battery in batteries)
        //    {
        //       ;
        //    }
        //}
    }
}
