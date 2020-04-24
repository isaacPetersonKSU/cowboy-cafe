using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropetryChangedTests.EntreeTests
{
    public class DakotaDoubleBurgerPropertyChangedTests
    {
        [Fact]
        public void DakotaDoubleBurgerShouldImplementINotifyPropertyChanged()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ddb);
        }


        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "Bun", () =>
            {
                ddb.Bun = !ddb.Bun;
            });
        }

        [Fact]
        public void ChangeingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "SpecialInstructions", () =>
            {
                ddb.Bun = !ddb.Bun;
            });
        }

        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "Ketchup", () =>
            {
                ddb.Ketchup = !ddb.Ketchup;
            });
        }

        [Fact]
        public void ChangeingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "SpecialInstructions", () =>
            {
                ddb.Ketchup = !ddb.Ketchup;
            });
        }

        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "Mustard", () =>
            {
                ddb.Mustard = !ddb.Mustard;
            });
        }

        [Fact]
        public void ChangeingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "SpecialInstructions", () =>
            {
                ddb.Mustard = !ddb.Mustard;
            });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "Pickle", () =>
            {
                ddb.Pickle = !ddb.Pickle;
            });
        }

        [Fact]
        public void ChangeingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "SpecialInstructions", () =>
            {
                ddb.Pickle = !ddb.Pickle;
            });
        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "Cheese", () =>
            {
                ddb.Cheese = !ddb.Cheese;
            });
        }

        [Fact]
        public void ChangeingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "SpecialInstructions", () =>
            {
                ddb.Cheese = !ddb.Cheese;
            });
        }

        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForTomato()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "Tomato", () =>
            {
                ddb.Tomato = !ddb.Tomato;
            });
        }

        [Fact]
        public void ChangeingTomatoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "SpecialInstructions", () =>
            {
                ddb.Tomato = !ddb.Tomato;
            });
        }

        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForLettuce()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "Lettuce", () =>
            {
                ddb.Lettuce = !ddb.Lettuce;
            });
        }

        [Fact]
        public void ChangeingLettuceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "SpecialInstructions", () =>
            {
                ddb.Lettuce = !ddb.Lettuce;
            });
        }

        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForMayo()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "Mayo", () =>
            {
                ddb.Mayo = !ddb.Mayo;
            });
        }

        [Fact]
        public void ChangeingMayoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ddb = new DakotaDoubleBurger();
            Assert.PropertyChanged(ddb, "SpecialInstructions", () =>
            {
                ddb.Mayo = !ddb.Mayo;
            });
        }
    }
}
