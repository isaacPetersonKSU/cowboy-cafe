using System;
using System.Collections.Generic;
using System.Text;
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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderSummeryControl : UserControl
    {
        public OrderSummeryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  When an order item is selected to be edited from the order
        /// summery control list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void EditOrderItem(object sender, RoutedEventArgs e)
        {
            if(sender is ListBox list && list.SelectedItem is IOrderItem)
            {
                OrderControl parent = this.FindAncestor<OrderControl>();
                UserControl editor = new OrderItemCostomizer((IOrderItem)list.SelectedItem);
                parent.SwapScreen(editor);
            }
        }

        /// <summary>
        /// When the delete button is clicked on an item 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DeleteOrderItem(object sender, RoutedEventArgs e)
        {
            
        }
    }
}