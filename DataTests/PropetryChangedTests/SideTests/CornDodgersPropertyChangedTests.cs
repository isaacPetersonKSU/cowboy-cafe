using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropetryChangedTests.SideTests
{
    public class CornDodgersPropertyChangedTests
    {
        [Fact]
        public void CornDodgersShouldImplementINotifyPropertyChanged()
        {
            var cd = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cd);
        }

        [Fact]
        public void SettingAsSmallShouldInvokePropertyChangedForSize()
        {
            var cd = new CornDodgers();
            cd.Size = Size.Medium;
            Assert.PropertyChanged(cd, "Size", () =>
            {
                cd.Size = Size.Small;
            });
        }

        [Fact]
        public void SettingAsSmallShouldInvokePropertyChangedForPrice()
        {
            var cd = new CornDodgers();
            cd.Size = Size.Large;
            Assert.PropertyChanged(cd, "Price", () =>
            {
                cd.Size = Size.Small;
            });
        }

        [Fact]
        public void CornDodgersShouldImplementPropertyChanged()
        {
            var cd = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cd);
        }

        [Fact]
        public void SettingAsMediumShouldInvokePropertyChangedForSize()
        {
            var cd = new CornDodgers();
            Assert.PropertyChanged(cd, "Size", () =>
            {
                cd.Size = Size.Medium;
            });
        }

        [Fact]
        public void SettingAsMediumShouldInvokePropertyChangedForPrice()
        {
            var cd = new CornDodgers();
            Assert.PropertyChanged(cd, "Price", () =>
            {
                cd.Size = Size.Medium;
            });
        }

        [Fact]
        public void SettingAsLargeShouldInvokePropertyChangedForSize()
        {
            var cd = new CornDodgers();
            Assert.PropertyChanged(cd, "Size", () =>
            {
                cd.Size = Size.Large;
            });
        }

        [Fact]
        public void SettingAsLargeShouldInvokePropertyChangedForPrice()
        {
            var cd = new CornDodgers();
            Assert.PropertyChanged(cd, "Price", () =>
            {
                cd.Size = Size.Large;
            });
        }
    }
}
