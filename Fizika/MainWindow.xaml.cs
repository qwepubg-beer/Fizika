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
using static Fizika.Function;
namespace Fizika
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tin.IsChecked == true) 
            {
                answer.Text = $"{Convert.ToString(Massa(a.Text,b.Text,c.Text,Tin))}";
            }
            else if(lead.IsChecked == true)
            {
                answer.Text = $"{Convert.ToString(Massa(a.Text, b.Text, c.Text,Lead))}";
            }
            else if (iron.IsChecked == true)
            {
                answer.Text = $"{Convert.ToString(Massa(a.Text, b.Text, c.Text, Iron))}";
            }
            else if (ice.IsChecked == true)
            {
                answer.Text = $"{Convert.ToString(Massa(a.Text, b.Text, c.Text, Ice))}";
            }
        }
    }
}
