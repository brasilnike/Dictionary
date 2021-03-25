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
using Dictionar.ViewModels;

namespace Dictionar
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

        private void ModAdministrativView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new ModAdministrativViewModel();
        }

        private void ModCautareCuvinteView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new ModCautareCuvinteViewModel();
        }

        private void ModDivertisment_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new ModDivertismentViewModel();
        }
    }
}
