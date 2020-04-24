using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropetryChangedTests
{
    public class OrderPropertyChangedTests
    {
        [Fact]
        public void OrderShouldImplementINotifyPropertyChanged()
        {
            var cbc = new Order(420);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cbc);
        }

        [Fact]
        public void AddingItemToOrderShouldInvokePropertyChangedForSubtotal()
        {
            var order = new Order(420);
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Add(new MockOrderItem());
            });
        }

        [Fact]
        public void AddingItemToOrderShouldInvokePropertyChangedForItems()
        {
            var order = new Order(420);
            Assert.PropertyChanged(order, "Items", () =>
            {
                order.Add(new MockOrderItem());
            });
        }

        [Fact]
        public void RemovingItemToOrderShouldInvokePropertyChangedForSubtotal()
        {
            var order = new Order(420);
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Remove(new MockOrderItem());
            });
        }

        [Fact]
        public void RemovingItemToOrderShouldInvokePropertyChangedForItems()
        {
            var order = new Order(420);
            Assert.PropertyChanged(order, "Items", () =>
            {
                order.Remove(new MockOrderItem());
            });
        }
    }
}
