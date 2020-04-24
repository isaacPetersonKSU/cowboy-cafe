using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropetryChangedTests.EntreeTests
{
    public class AngryChickenPropertyChangedTests
    {
        /// <summary>
        /// tests if the angrychicken implements INotifyPropertyChanged
        /// </summary>
        [Fact]
        public void AngryChickenShouldImplementINotifyPropertyChanged()
        {
            var sammich = new AngryChicken();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(sammich);
        }


        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForBread()
        {
            var sammich = new AngryChicken();
            Assert.PropertyChanged(sammich, "Bread", ()=>
            {
                sammich.Bread = !sammich.Bread;
            });
        }

        [Fact]
        public void ChangeingBreadShouldInvokePropertyChangedForSpecialInstructions()
        {
            var sammich = new AngryChicken();
            Assert.PropertyChanged(sammich, "SpecialInstructions", () =>
            {
                sammich.Bread = !sammich.Bread;
            });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var sammich = new AngryChicken();
            Assert.PropertyChanged(sammich, "Pickle", () =>
            {
                sammich.Pickle = !sammich.Pickle;
            });
        }

        [Fact]
        public void ChangeingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var sammich = new AngryChicken();
            Assert.PropertyChanged(sammich, "SpecialInstructions", () =>
            {
                sammich.Pickle = !sammich.Pickle;
            });
        }
    }
}
