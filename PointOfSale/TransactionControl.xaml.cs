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
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        Order order;


        public TransactionControl()
        {
            InitializeComponent();

            
        }

        private void CardClick(object sender, RoutedEventArgs e)
        {

        }

        private void CashClick(object sender, RoutedEventArgs e)
        {

        }

        private void GoBackClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
