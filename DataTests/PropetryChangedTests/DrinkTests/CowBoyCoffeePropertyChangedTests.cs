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
            var cbc = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cbc);
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeShouldInvokePropertyChangedForSize(Size s)
        {
            var cbc = new CowboyCoffee();
            Assert.PropertyChanged(cbc, "Size", () =>
            {
                cbc.Size = s;
            });
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeShouldInvokePropertyChangedForPrice(Size s)
        {
            var cbc = new CowboyCoffee();
            Assert.PropertyChanged(cbc, "Price", () =>
            {
                cbc.Size = s;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var cbc = new CowboyCoffee();
            Assert.PropertyChanged(cbc, "Ice", () =>
            {
                cbc.Ice = !cbc.Ice;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cbc = new CowboyCoffee();
            Assert.PropertyChanged(cbc, "SpecialInstructions", () =>
            {
                cbc.Ice = !cbc.Ice;
            });
        }
    }
}
