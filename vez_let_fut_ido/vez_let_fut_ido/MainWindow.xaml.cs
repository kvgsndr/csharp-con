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

namespace vez_let_fut_ido
{
    

    public partial class MainWindow : Window
    {



        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Label lab1 = new Label();
            lab1.Content = "Ez egy dinamikusan futás időben létrejött objektum!";
            lab1.Name = "lbLab1";
            lab1.Width = 300;
            lab1.Height = 200;
            lab1.Background = Brushes.Red;
            lab1.Margin = new Thickness(20, 20, 20, 20);

            grid.Children.Add(lab1);


        }
    }
}
