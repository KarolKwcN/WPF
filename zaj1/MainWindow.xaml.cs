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

namespace zaj1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Stos stosik { get; set; }
       
        public MainWindow()
        {
            InitializeComponent();
            this.stosik = new Stos();

            wynik.Content = "Stos jest pusty";
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string a = pole.Text;
            stosik.push(a);
        
            wynik.Content = stosik.top();
            
        }

        private void Przycisk_pop_Click(object sender, RoutedEventArgs e)
        {
            if (stosik.empty())
            {
                wynik.Content = "Stos jest pusty";
            }
            else
            {
                stosik.pop();
                wynik.Content = stosik.top();
                if(stosik.empty())
                {
                    wynik.Content = "Stos jest pusty";
                }
            }
        }
    }
}
