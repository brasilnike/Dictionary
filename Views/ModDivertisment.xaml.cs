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

namespace Dictionar.Views
{

    public partial class ModDivertisment : UserControl
    {
        public Button buttonStart;
        public Button next;
        private int index = 0;
        public ModDivertisment()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Button buton = (sender as Button);
            buton.Visibility = Visibility.Hidden;
        }

        private void btnAdauga_Click(object sender, RoutedEventArgs e)
        {
            index++;
            Button buton = (sender as Button);
            if(index==5)
            {
                buton.Visibility = Visibility.Hidden;
            }
        }

        private void btnDeletete_Click(object sender, RoutedEventArgs e)
        {
            Button buton = (sender as Button);
            buton.Visibility = Visibility.Hidden;    
        }
    }
}
