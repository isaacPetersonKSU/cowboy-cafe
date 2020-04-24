using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropetryChangedTests.SideTests
{
    public class ChilliCheeseFriesPropertyChangedTests
    {
        [Fact]
        public void ChilliCheeseFriesShouldImplementINotifyPropertyChanged()
        {
            var ccf = new ChilliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ccf);
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeShouldInvokePropertyChangedForSize(Size s)
        {
            var ccf = new ChilliCheeseFries();
            Assert.PropertyChanged(ccf, "Size", () =>
            {
                ccf.Size = s;
            });
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeShouldInvokePropertyChangedForPrice(Size s)
        {
            var ccf = new ChilliCheeseFries();
            Assert.PropertyChanged(ccf, "Price", () =>
            {
                ccf.Size = s;
            });
        }
    }
}
