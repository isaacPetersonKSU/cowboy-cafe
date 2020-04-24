using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// ID number for order
        /// </summary>
        public int OrderNumber { get; private set; }
        
        /// <summary>
        /// backing variable for Items property
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// list of all items in the order
        /// </summary>
        public IEnumerable<IOrderItem> Items { get => items.ToArray(); }

        /// <summary>
        /// total price of all items on the order (before taxes)
        /// </summary>
        public double Subtotal
        {
            get
            {
                double subtotal = 0;
                foreach(IOrderItem item in items)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }

        /// <summary>
        /// creates a new instance of Order
        /// </summary>
        /// <param name="number">Order number</param>
        public Order(int number)
        {
            OrderNumber = number;
        }

        /// <summary>
        /// adds an item to the order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);

            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged += OnItemPropertyChanged;
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Prices"));
        }

        /// <summary>
        /// removes an item from the order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged -= OnItemPropertyChanged;
            }

            items.Remove(item);

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// updates stuff when the order is updated.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
    }
}
