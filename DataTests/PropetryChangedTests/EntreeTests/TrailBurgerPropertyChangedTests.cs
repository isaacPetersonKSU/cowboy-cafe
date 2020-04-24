using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropetryChangedTests.EntreeTests
{
    public class TrailBurgerPropertyChangedTests
    {
        [Fact]
        public void TrailBurgerShouldImplementINotifyPropertyChanged()
        {
            var tb = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tb);
        }


        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var tb = new TrailBurger();
            Assert.PropertyChanged(tb, "Bun", () =>
            {
                tb.Bun = !tb.Bun;
            });
        }

        [Fact]
        public void ChangeingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tb = new TrailBurger();
            Assert.PropertyChanged(tb, "SpecialInstructions", () =>
            {
                tb.Bun = !tb.Bun;
            });
        }

        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var tb = new TrailBurger();
            Assert.PropertyChanged(tb, "Ketchup", () =>
            {
                tb.Ketchup = !tb.Ketchup;
            });
        }

        [Fact]
        public void ChangeingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tb = new TrailBurger();
            Assert.PropertyChanged(tb, "SpecialInstructions", () =>
            {
                tb.Ketchup = !tb.Ketchup;
            });
        }

        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var tb = new TrailBurger();
            Assert.PropertyChanged(tb, "Mustard", () =>
            {
                tb.Mustard = !tb.Mustard;
            });
        }

        [Fact]
        public void ChangeingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tb = new TrailBurger();
            Assert.PropertyChanged(tb, "SpecialInstructions", () =>
            {
                tb.Mustard = !tb.Mustard;
            });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var tb = new TrailBurger();
            Assert.PropertyChanged(tb, "Pickle", () =>
            {
                tb.Pickle = !tb.Pickle;
            });
        }

        [Fact]
        public void ChangeingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tb = new TrailBurger();
            Assert.PropertyChanged(tb, "SpecialInstructions", () =>
            {
                tb.Pickle = !tb.Pickle;
            });
        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var tb = new TrailBurger();
            Assert.PropertyChanged(tb, "Cheese", () =>
            {
                tb.Cheese = !tb.Cheese;
            });
        }

        [Fact]
        public void ChangeingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tb = new TrailBurger();
            Assert.PropertyChanged(tb, "SpecialInstructions", () =>
            {
                tb.Cheese = !tb.Cheese;
            });
        }
    }
}
