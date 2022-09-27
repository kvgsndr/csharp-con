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
using System.IO;

namespace filebeolvas
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

       

        private void btOk_Click(object sender, RoutedEventArgs e)
        {
            //if (File.Exists(txbFileName.Text))
            //{
            //   string txt= File.ReadAllText(txbFileName.Text);
            //    txbTartalom.Text = txt;
            //}
            //else
            //{
            //    MessageBox.Show($"A {txbFileName.Text} nem létezik");
            //    txbTartalom.Clear();

            //}
            try
            {
                StreamReader fbe = new StreamReader(txbFileName.Text);
                while (!fbe.EndOfStream)
                {
                    lbxTartalom.Items.Add(fbe.ReadLine());
                }
                fbe.Close();
            }
            catch (Exception kiv)
            {

                MessageBox.Show($"{kiv.Message}", "HIBA!!!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
                

        }

        private void lbxTartalom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbSor.Content = lbxTartalom.SelectedItem;
        }

        private void txbFileName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cmbxLista.Items.Add(lbxTartalom.SelectedItem);
        }
    }
}
