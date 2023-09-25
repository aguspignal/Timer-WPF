using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Timer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            HoursCombox.ItemsSource = LoadComboBoxData();
            MinutesCombox.ItemsSource = LoadComboBoxData();
            SecondsCombox.ItemsSource = LoadComboBoxData();
        }

        private static string[] LoadComboBoxData()
        {
            string[] strArray = {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"
            };
            return strArray;
        }

        private void SetTime(object sender, RoutedEventArgs e)
        {
            HoursValue.Text = HoursCombox.SelectedItem.ToString();
            MinutesValue.Text = MinutesCombox.SelectedItem.ToString();
            SecondsValue.Text = SecondsCombox.SelectedItem.ToString();
        }

        private void StartTimer(object sender, RoutedEventArgs e)
        {

        }
        private void StopBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
