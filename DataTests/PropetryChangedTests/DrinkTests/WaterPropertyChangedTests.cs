using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropetryChangedTests.DrinkTests
{
    public class WaterPropertyChangedTests
    {
        [Fact]
        public void WaterShouldImplementINotifyPropertyChanged()
        {
            var h2o = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(h2o);
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeShouldInvokePropertyChangedForSize(Size s)
        {
            var h2o = new Water();
            Assert.PropertyChanged(h2o, "Size", () =>
            {
                h2o.Size = s;
            });
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeShouldInvokePropertyChangedForPrice(Size s)
        {
            var h2o = new Water();
            Assert.PropertyChanged(h2o, "Price", () =>
            {
                h2o.Size = s;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var h2o = new Water();
            Assert.PropertyChanged(h2o, "Ice", () =>
            {
                h2o.Ice = !h2o.Ice;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var h2o = new Water();
            Assert.PropertyChanged(h2o, "SpecialInstructions", () =>
            {
                h2o.Ice = !h2o.Ice;
            });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForLemon()
        {
            var h2o = new Water();
            Assert.PropertyChanged(h2o, "Lemon", () =>
            {
                h2o.Lemon = !h2o.Lemon;
            });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var h2o = new Water();
            Assert.PropertyChanged(h2o, "SpecialInstructions", () =>
            {
                h2o.Lemon = !h2o.Lemon;
            });
        }
    }
}
