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
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        Order order;
        //CashDrawer drawer;
        //CardTerminal cardTerminal;

        double total;
        double salesTaxPercent = 0.16;


        public TransactionControl(Order o/*, CashDrawer d, CardTerminal ct*/)
        {
            order = o;
            //drawer = d;
            //cardTerminal = ct;

            InitializeComponent();

            SubtotalBox.Text = order.Subtotal.ToString("C2");
            TaxBox.Text = (order.Subtotal * salesTaxPercent).ToString("C2");

            total = (order.Subtotal * (1 + salesTaxPercent));
            TotalBox.Text = total.ToString("C2");
        }

        private void PrintReceipt()
        {
            // do some stuff
        }

        private void CardClick(object sender, RoutedEventArgs e)
        {
            //CardTerminal ct = new CardTerminal();
            //ResultCode code = cardTerminal.ProcessTransaction(total);

            if( false)
            {
                PrintReceipt();
            }
            else
            {
                //MessageBox.Show(code.ToString());
            }
            
        }

        private void CashClick(object sender, RoutedEventArgs e)
        {

        }

        private void GoBackClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
