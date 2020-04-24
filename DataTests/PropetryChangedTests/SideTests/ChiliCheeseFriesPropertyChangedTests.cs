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

        [Fact]
        public void SettingAsSmallShouldInvokePropertyChangedForSize()
        {
            var ccf = new ChilliCheeseFries();
            ccf.Size = Size.Medium;
            Assert.PropertyChanged(ccf, "Size", () =>
            {
                ccf.Size = Size.Small;
            });
        }

        [Fact]
        public void SettingAsSmallShouldInvokePropertyChangedForPrice()
        {
            var ccf = new ChilliCheeseFries();
            ccf.Size = Size.Large;
            Assert.PropertyChanged(ccf, "Price", () =>
            {
                ccf.Size = Size.Small;
            });
        }

        [Fact]
        public void ChilliCheeseFriesShouldImplementPropertyChanged()
        {
            var ccf = new ChilliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ccf);
        }

        [Fact]
        public void SettingAsMediumShouldInvokePropertyChangedForSize()
        {
            var ccf = new ChilliCheeseFries();
            Assert.PropertyChanged(ccf, "Size", () =>
            {
                ccf.Size = Size.Medium;
            });
        }

        [Fact]
        public void SettingAsMediumShouldInvokePropertyChangedForPrice()
        {
            var ccf = new ChilliCheeseFries();
            Assert.PropertyChanged(ccf, "Price", () =>
            {
                ccf.Size = Size.Medium;
            });
        }

        [Fact]
        public void SettingAsLargeShouldInvokePropertyChangedForSize()
        {
            var ccf = new ChilliCheeseFries();
            Assert.PropertyChanged(ccf, "Size", () =>
            {
                ccf.Size = Size.Large;
            });
        }

        [Fact]
        public void SettingAsLargeShouldInvokePropertyChangedForPrice()
        {
            var ccf = new ChilliCheeseFries();
            Assert.PropertyChanged(ccf, "Price", () =>
            {
                ccf.Size = Size.Large;
            });
        }
    }
}
