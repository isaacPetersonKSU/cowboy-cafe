using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropetryChangedTests.EntreeTests
{
    public class TexasTripleBurgerPropertyChangedTests
    {
        [Fact]
        public void TexasTripleBurgerShouldImplementINotifyPropertyChanged()
        {
            var ttb = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ttb);
        }


        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "Bun", () =>
            {
                ttb.Bun = !ttb.Bun;
            });
        }

        [Fact]
        public void ChangeingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "SpecialInstructions", () =>
            {
                ttb.Bun = !ttb.Bun;
            });
        }

        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "Ketchup", () =>
            {
                ttb.Ketchup = !ttb.Ketchup;
            });
        }

        [Fact]
        public void ChangeingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "SpecialInstructions", () =>
            {
                ttb.Ketchup = !ttb.Ketchup;
            });
        }

        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "Mustard", () =>
            {
                ttb.Mustard = !ttb.Mustard;
            });
        }

        [Fact]
        public void ChangeingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "SpecialInstructions", () =>
            {
                ttb.Mustard = !ttb.Mustard;
            });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "Pickle", () =>
            {
                ttb.Pickle = !ttb.Pickle;
            });
        }

        [Fact]
        public void ChangeingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "SpecialInstructions", () =>
            {
                ttb.Pickle = !ttb.Pickle;
            });
        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "Cheese", () =>
            {
                ttb.Cheese = !ttb.Cheese;
            });
        }

        [Fact]
        public void ChangeingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "SpecialInstructions", () =>
            {
                ttb.Cheese = !ttb.Cheese;
            });
        }

        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForTomato()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "Tomato", () =>
            {
                ttb.Tomato = !ttb.Tomato;
            });
        }

        [Fact]
        public void ChangeingTomatoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "SpecialInstructions", () =>
            {
                ttb.Tomato = !ttb.Tomato;
            });
        }

        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForLettuce()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "Lettuce", () =>
            {
                ttb.Lettuce = !ttb.Lettuce;
            });
        }

        [Fact]
        public void ChangeingLettuceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "SpecialInstructions", () =>
            {
                ttb.Lettuce = !ttb.Lettuce;
            });
        }

        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForMayo()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "Mayo", () =>
            {
                ttb.Mayo = !ttb.Mayo;
            });
        }

        [Fact]
        public void ChangeingMayoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "SpecialInstructions", () =>
            {
                ttb.Mayo = !ttb.Mayo;
            });
        }

        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedForBacon()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "Bacon", () =>
            {
                ttb.Bacon = !ttb.Bacon;
            });
        }

        [Fact]
        public void ChangeingBaconShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "SpecialInstructions", () =>
            {
                ttb.Bacon = !ttb.Bacon;
            });
        }

        [Fact]
        public void ChangingEggShouldInvokePropertyChangedForEgg()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "Egg", () =>
            {
                ttb.Egg = !ttb.Egg;
            });
        }

        [Fact]
        public void ChangeingEggShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            Assert.PropertyChanged(ttb, "SpecialInstructions", () =>
            {
                ttb.Egg = !ttb.Egg;
            });
        }
    }
}
