using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropetryChangedTests.SideTests
{
    public class BakedBeansPropertyChangedTests
    {
        [Fact]
        public void BakedBeansShouldImplementINotifyPropertyChanged()
        {
            var bb = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(bb);
        }

        [Fact]
        public void SettingAsSmallShouldInvokePropertyChangedForSize()
        {
            var bb = new BakedBeans();
            bb.Size = Size.Medium;
            Assert.PropertyChanged(bb, "Size", () =>
            {
                bb.Size = Size.Small;
            });
        }

        [Fact]
        public void SettingAsSmallShouldInvokePropertyChangedForPrice()
        {
            var bb = new BakedBeans();
            bb.Size = Size.Large;
            Assert.PropertyChanged(bb, "Price", () =>
            {
                bb.Size = Size.Small;
            });
        }

        [Fact]
        public void BakedBeansShouldImplementPropertyChanged()
        {
            var bb = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(bb);
        }

        [Fact]
        public void SettingAsMediumShouldInvokePropertyChangedForSize()
        {
            var bb = new BakedBeans();
            Assert.PropertyChanged(bb, "Size", () =>
            {
                bb.Size = Size.Medium;
            });
        }

        [Fact]
        public void SettingAsMediumShouldInvokePropertyChangedForPrice()
        {
            var bb = new BakedBeans();
            Assert.PropertyChanged(bb, "Price", () =>
            {
                bb.Size = Size.Medium;
            });
        }

        [Fact]
        public void SettingAsLargeShouldInvokePropertyChangedForSize()
        {
            var bb = new BakedBeans();
            Assert.PropertyChanged(bb, "Size", () =>
            {
                bb.Size = Size.Large;
            });
        }

        [Fact]
        public void SettingAsLargeShouldInvokePropertyChangedForPrice()
        {
            var bb = new BakedBeans();
            Assert.PropertyChanged(bb, "Price", () =>
            {
                bb.Size = Size.Large;
            });
        }
    }
}
