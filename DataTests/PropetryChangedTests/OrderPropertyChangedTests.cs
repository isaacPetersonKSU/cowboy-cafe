using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropetryChangedTests.DrinkTests
{
    public class OrderPropertyChangedTests
    {
        /*
        [Fact]
        public void OrderShouldImplementINotifyPropertyChanged()
        {
            var cbc = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cbc);
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeShouldInvokePropertyChangedForPrice(Size s)
        {
            var cbc = new Order();
            Assert.PropertyChanged(cbc, "Price", () =>
            {
                cbc.Size = s;
            });
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeShouldInvokePropertyChangedForCalories(Size s)
        {
            var cbc = new Order();
            Assert.PropertyChanged(cbc, "Calories", () =>
            {
                cbc.Size = s;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var cbc = new Order();
            Assert.PropertyChanged(cbc, "Ice", () =>
            {
                cbc.Ice = !cbc.Ice;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cbc = new Order();
            Assert.PropertyChanged(cbc, "SpecialInstructions", () =>
            {
                cbc.Ice = !cbc.Ice;
            });
        }

        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForDecaf()
        {
            var cbc = new Order();
            Assert.PropertyChanged(cbc, "Decaf", () =>
            {
                cbc.Decaf = !cbc.Decaf;
            });
        }

        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cbc = new Order();
            Assert.PropertyChanged(cbc, "SpecialInstructions", () =>
            {
                cbc.Decaf = !cbc.Decaf;
            });
        }

        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForRoomForCream()
        {
            var cbc = new Order();
            Assert.PropertyChanged(cbc, "RoomForCream", () =>
            {
                cbc.RoomForCream = !cbc.RoomForCream;
            });
        }

        [Fact]
        public void ChangingRoomForCremShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cbc = new Order();
            Assert.PropertyChanged(cbc, "SpecialInstructions", () =>
            {
                cbc.RoomForCream = !cbc.RoomForCream;
            });
        }*/
    }
}
