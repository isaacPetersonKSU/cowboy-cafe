using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropetryChangedTests.EntreeTests
{
    public class PecosPulledPorkPropertyChangedTests
    {
        [Fact]
        public void PecosPulledPorkShouldImplementINotifyPropertyChanged()
        {
            var ppp = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ppp);
        }


        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForBread()
        {
            var ppp = new PecosPulledPork();
            Assert.PropertyChanged(ppp, "Bread", () =>
            {
                ppp.Bread = !ppp.Bread;
            });
        }

        [Fact]
        public void ChangeingBreadShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ppp = new PecosPulledPork();
            Assert.PropertyChanged(ppp, "SpecialInstructions", () =>
            {
                ppp.Bread = !ppp.Bread;
            });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var ppp = new PecosPulledPork();
            Assert.PropertyChanged(ppp, "Pickle", () =>
            {
                ppp.Pickle = !ppp.Pickle;
            });
        }

        [Fact]
        public void ChangeingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ppp = new PecosPulledPork();
            Assert.PropertyChanged(ppp, "SpecialInstructions", () =>
            {
                ppp.Pickle = !ppp.Pickle;
            });
        }
    }
}
