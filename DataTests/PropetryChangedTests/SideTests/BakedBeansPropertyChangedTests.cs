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

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeShouldInvokePropertyChangedForPrice(Size s)
        {
            var bb = new BakedBeans();
            Assert.PropertyChanged(bb, "Price", () =>
            {
                bb.Size = s;
            });
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeShouldInvokePropertyChangedForSize(Size s)
        {
            var bb = new BakedBeans();
            Assert.PropertyChanged(bb, "Size", () =>
            {
                bb.Size = s;
            });
        }
    }
}
