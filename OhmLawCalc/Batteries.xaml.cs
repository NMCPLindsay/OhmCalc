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
using System.Windows.Shapes;

namespace OhmLawCalc
{
    /// <summary>
    /// Interaction logic for Batteries.xaml
    /// </summary>
    public partial class Batteries : Window
    {

        public Batteries()
        {
            InitializeComponent();
        }

    //    private void Button_Add_Click(object sender, RoutedEventArgs e)
    //    {
    //        AddBattery();
    //    }
    //    private void AddBattery()
    //    {
    //        double MAh, amp, volt;
    //        List<Battery> batteries = new List<Battery>();
    //        Battery battery = new Battery();
    //        battery.Brand = TextBox_Brand.Text;
    //        double.TryParse(TextBox_MAh.Text, out MAh);
    //        battery.MAH = MAh;
    //        double.TryParse(TextBox_BattAmp.Text, out amp);
    //        battery.Amp = amp;
    //        battery.Size = TextBox_Size.Text;
    //        double.TryParse(TextBox_BattVolt.Text, out volt);
    //        batteries.Add(battery);
    //    }
    }
}
