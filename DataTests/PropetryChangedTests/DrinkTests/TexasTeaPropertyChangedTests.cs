using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropetryChangedTests.DrinkTests
{
    public class TexasTeaPropertyChangedTests
    {
        [Fact]
        public void TexasTeaShouldImplementINotifyPropertyChanged()
        {
            var tt = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tt);
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeShouldInvokePropertyChangedForSize(Size s)
        {
            var tt = new TexasTea();
            Assert.PropertyChanged(tt, "Size", () =>
            {
                tt.Size = s;
            });
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeShouldInvokePropertyChangedForPrice(Size s)
        {
            var tt = new TexasTea();
            Assert.PropertyChanged(tt, "Price", () =>
            {
                tt.Size = s;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var tt = new TexasTea();
            Assert.PropertyChanged(tt, "Ice", () =>
            {
                tt.Ice = !tt.Ice;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tt = new TexasTea();
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Ice = !tt.Ice;
            });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForLemon()
        {
            var tt = new TexasTea();
            Assert.PropertyChanged(tt, "Lemon", () =>
            {
                tt.Lemon = !tt.Lemon;
            });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tt = new TexasTea();
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Lemon = !tt.Lemon;
            });
        }

        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedForSweet()
        {
            var tt = new TexasTea();
            Assert.PropertyChanged(tt, "Sweet", () =>
            {
                tt.Sweet = !tt.Sweet;
            });
        }

        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tt = new TexasTea();
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Sweet = !tt.Sweet;
            });
        }
    }
}
