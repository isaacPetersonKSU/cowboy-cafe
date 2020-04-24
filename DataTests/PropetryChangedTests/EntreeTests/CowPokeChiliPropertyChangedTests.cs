using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropetryChangedTests.EntreeTests
{
    public class CowPokeChiliPropertyChangedTests
    {
        [Fact]
        void CowPokeChiliShouldImplementPropertyChanged()
        {
            var cpc = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cpc);
        }

        [Fact]
        void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var cpc = new CowpokeChili();
            Assert.PropertyChanged(cpc, "Cheese", () =>
            {
                cpc.Cheese = !cpc.Cheese;
            });
        }

        [Fact]
        void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cpc = new CowpokeChili();
            Assert.PropertyChanged(cpc, "SpecialInstructions", () =>
            {
                cpc.Cheese = !cpc.Cheese;
            });
        }

        [Fact]
        void ChangingSourCreamShouldInvokePropertyChangedForSourCream()
        {
            var cpc = new CowpokeChili();
            Assert.PropertyChanged(cpc, "SourCream", () =>
            {
                cpc.SourCream = !cpc.SourCream;
            });
        }

        [Fact]
        void ChangingSourCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cpc = new CowpokeChili();
            Assert.PropertyChanged(cpc, "SpecialInstructions", () =>
            {
                cpc.SourCream = !cpc.SourCream;
            });
        }

        [Fact]
        void ChangingGreanOnionsShouldInvokePropertyChangedForGreenOnions()
        {
            var cpc = new CowpokeChili();
            Assert.PropertyChanged(cpc, "GreenOnions", () =>
            {
                cpc.GreenOnions = !cpc.GreenOnions;
            });
        }

        [Fact]
        void ChangingGreenOnionsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cpc = new CowpokeChili();
            Assert.PropertyChanged(cpc, "SpecialInstructions", () =>
            {
                cpc.GreenOnions = !cpc.GreenOnions;
            });
        }

        [Fact]
        void ChangingTortillaStripsShouldInvokePropertyChangedForTortillaStrips()
        {
            var cpc = new CowpokeChili();
            Assert.PropertyChanged(cpc, "TortillaStrips", () =>
            {
                cpc.TortillaStrips = !cpc.TortillaStrips;
            });
        }

        [Fact]
        void ChangingTortillaStripsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cpc = new CowpokeChili();
            Assert.PropertyChanged(cpc, "SpecialInstructions", () =>
            {
                cpc.TortillaStrips = !cpc.TortillaStrips;
            });
        }
    }
}
