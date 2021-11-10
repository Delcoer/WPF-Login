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

namespace Wpf_CheckBox
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            btn.IsEnabled = true;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            btn.IsEnabled = false;
        }

        int counter = 1;
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if (( psw.Password == "12341" && (txt_Name.Text=="Wayne" || txt_Name.Text == "wayne") && (txt_Vorname.Text=="Bruce"|| txt_Vorname.Text == "bruce")) ||
                (psw.Password == "12342" && txt_Name.Text == "Cattin" && txt_Vorname.Text == "Kevin"))
            {
                string message = " Hello mister "+txt_Name.Text +" "+txt_Vorname.Text;
                lbl_out.Content = message;
                txt_Name.Text = "";
                txt_Vorname.Text = "";
                psw.Password = "";
                counter = 0;
            }
            else
            {
                if (counter == 3)
                {
                    lbl_out.Content = " Try again after 30sec!";
                    counter = 0;
                    txt_Name.Text = "";
                    txt_Vorname.Text = "";
                    psw.Password = "";
                }
                else if (counter == 2)
                {
                    lbl_out.Content = " Wrong input!\n " +
                        " You have one try left!";
                    psw.Password = "";
                }
                else if (counter == 1)
                {
                    lbl_out.Content = " Wrong input!";
                    psw.Password = "";
                }
            }
            counter++;
        }
    }
}
