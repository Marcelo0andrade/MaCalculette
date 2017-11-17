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

namespace WpfCalculette
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            double dblnb1;
            double dblnb2;
            double dblResponse;
           
             if(double.TryParse(tbxNb1.Text, out dblnb1))
            {
                if (double.TryParse(tbxNb2.Text, out dblnb2))
                {
                    dblResponse = dblnb1 + dblnb2;
                    lblResponse.Content = dblResponse.ToString();

                }
                else
                {
                    MessageBox.Show("Erreur veuillez saisir un nombre entier");
                }
            }
            else
            {
                MessageBox.Show("Erreur veuillez saisir un nombre entier");
            }
        }
    }
}
