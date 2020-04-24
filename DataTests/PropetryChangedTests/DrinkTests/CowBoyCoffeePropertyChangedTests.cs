using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropetryChangedTests.DrinkTests
{
    public class CowBoyCoffeePropertyChangedTests
    {
        [Fact]
        public void CowboyCoffeeShouldImplementINotifyPropertyChanged()
        {
            var ccc = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ccc);
        }

        [Fact]
        public void SettingAsSmallShouldInvokePropertyChangedForSize()
        {
            var ccc = new CowboyCoffee();
            ccc.Size = Size.Medium;
            Assert.PropertyChanged(ccc, "Size", () =>
            {
                ccc.Size = Size.Small;
            });
        }

        [Fact]
        public void SettingAsSmallShouldInvokePropertyChangedForPrice()
        {
            var ccc = new CowboyCoffee();
            ccc.Size = Size.Large;
            Assert.PropertyChanged(ccc, "Price", () =>
            {
                ccc.Size = Size.Small;
            });
        }

        [Fact]
        public void CowboyCoffeeShouldImplementPropertyChanged()
        {
            var ccc = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ccc);
        }

        [Fact]
        public void SettingAsMediumShouldInvokePropertyChangedForSize()
        {
            var ccc = new CowboyCoffee();
            Assert.PropertyChanged(ccc, "Size", () =>
            {
                ccc.Size = Size.Medium;
            });
        }

        [Fact]
        public void SettingAsMediumShouldInvokePropertyChangedForPrice()
        {
            var ccc = new CowboyCoffee();
            Assert.PropertyChanged(ccc, "Price", () =>
            {
                ccc.Size = Size.Medium;
            });
        }

        [Fact]
        public void SettingAsLargeShouldInvokePropertyChangedForSize()
        {
            var ccc = new CowboyCoffee();
            Assert.PropertyChanged(ccc, "Size", () =>
            {
                ccc.Size = Size.Large;
            });
        }

        [Fact]
        public void SettingAsLargeShouldInvokePropertyChangedForPrice()
        {
            var ccc = new CowboyCoffee();
            Assert.PropertyChanged(ccc, "Price", () =>
            {
                ccc.Size = Size.Large;
            });
        }
    }
}
