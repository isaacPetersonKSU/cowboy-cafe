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
        public void SettingAsSmallShouldInvokePropertyChangedForSize()
        {
            var pdc = new PanDeCampo();
            pdc.Size = Size.Medium;
            Assert.PropertyChanged(pdc, "Size", () =>
            {
                pdc.Size = Size.Small;
            });
        }

        [Fact]
        public void SettingAsSmallShouldInvokePropertyChangedForPrice()
        {
            var pdc = new PanDeCampo();
            pdc.Size = Size.Large;
            Assert.PropertyChanged(pdc, "Price", () =>
            {
                pdc.Size = Size.Small;
            });
        }

        [Fact]
        public void PanDeCampoShouldImplementPropertyChanged()
        {
            var pdc = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pdc);
        }

        [Fact]
        public void SettingAsMediumShouldInvokePropertyChangedForSize()
        {
            var pdc = new PanDeCampo();
            Assert.PropertyChanged(pdc, "Size", () =>
            {
                pdc.Size = Size.Medium;
            });
        }

        [Fact]
        public void SettingAsMediumShouldInvokePropertyChangedForPrice()
        {
            var pdc = new PanDeCampo();
            Assert.PropertyChanged(pdc, "Price", () =>
            {
                pdc.Size = Size.Medium;
            });
        }

        [Fact]
        public void SettingAsLargeShouldInvokePropertyChangedForSize()
        {
            var pdc = new PanDeCampo();
            Assert.PropertyChanged(pdc, "Size", () =>
            {
                pdc.Size = Size.Large;
            });
        }

        [Fact]
        public void SettingAsLargeShouldInvokePropertyChangedForPrice()
        {
            var pdc = new PanDeCampo();
            Assert.PropertyChanged(pdc, "Price", () =>
            {
                pdc.Size = Size.Large;
            });
        }
    }
}
