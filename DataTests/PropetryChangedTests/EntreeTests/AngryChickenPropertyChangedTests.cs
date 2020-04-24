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
    }
}
