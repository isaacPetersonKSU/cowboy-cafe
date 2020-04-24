using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropetryChangedTests.SideTests
{
    public class PanDeCampoPropertyChangedTests
    {
        [Fact]
        public void PanDeCampoShouldImplementINotifyPropertyChanged()
        {
            var pdc = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pdc);
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeShouldInvokePropertyChangedForSize(Size s)
        {
            var pdc = new PanDeCampo();
            Assert.PropertyChanged(pdc, "Size", () =>
            {
                pdc.Size = s;
            });
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeShouldInvokePropertyChangedForPrice(Size s)
        {
            var pdc = new PanDeCampo();
            Assert.PropertyChanged(pdc, "Price", () =>
            {
                pdc.Size = s;
            });
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeShouldInvokePropertyChangedForCalories(Size s)
        {
            var pdc = new PanDeCampo();
            Assert.PropertyChanged(pdc, "Calories", () =>
            {
                pdc.Size = s;
            });
        }
    }
}
