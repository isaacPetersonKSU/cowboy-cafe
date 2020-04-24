using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropetryChangedTests.DrinkTests
{
    public class JerkedSodaPropertyChangedTests
    {
        [Fact]
        public void JerkedSodaShouldImplementINotifyPropertyChanged()
        {
            var js = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(js);
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeShouldInvokePropertyChangedForSize(Size s)
        {
            var js = new JerkedSoda();
            Assert.PropertyChanged(js, "Size", () =>
            {
                js.Size = s;
            });
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeShouldInvokePropertyChangedForPrice(Size s)
        {
            var js = new JerkedSoda();
            Assert.PropertyChanged(js, "Price", () =>
            {
                js.Size = s;
            });
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeShouldInvokePropertyChangedForCalories(Size s)
        {
            var js = new JerkedSoda();
            Assert.PropertyChanged(js, "Calories", () =>
            {
                js.Size = s;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var js = new JerkedSoda();
            Assert.PropertyChanged(js, "Ice", () =>
            {
                js.Ice = !js.Ice;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var js = new JerkedSoda();
            Assert.PropertyChanged(js, "SpecialInstructions", () =>
            {
                js.Ice = !js.Ice;
            });
        }

        [Theory]
        [InlineData(SodaFlavor.BirchBeer)]
        [InlineData(SodaFlavor.CreamSoda)]
        [InlineData(SodaFlavor.OrangeSoda)]
        [InlineData(SodaFlavor.RootBeer)]
        [InlineData(SodaFlavor.Sarsparilla)]
        public void ChangingFlavorShouldInvokePropertyChangedForFlavor(SodaFlavor sf)
        {
            var js = new JerkedSoda();
            Assert.PropertyChanged(js, "Flavor", () =>
            {
                js.Flavor = sf;
            });
        }
    }
}
