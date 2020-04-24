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

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeShouldInvokePropertyChangedForSize(Size s)
        {
            var cd = new CornDodgers();
            Assert.PropertyChanged(cd, "Size", () =>
            {
                cd.Size = s;
            });
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeShouldInvokePropertyChangedForPrice(Size s)
        {
            var cd = new CornDodgers();
            Assert.PropertyChanged(cd, "Price", () =>
            {
                cd.Size = s;
            });
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeShouldInvokePropertyChangedForCalories(Size s)
        {
            var cd = new CornDodgers();
            Assert.PropertyChanged(cd, "Calories", () =>
            {
                cd.Size = s;
            });
        }
    }
}
