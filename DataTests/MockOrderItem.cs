using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    /// <summary>
    /// generic order item for testing purposes
    /// </summary>
    public class MockOrderItem : IOrderItem
    {
        public double Price { get; set; }
        public List<string> SpecialInstructions { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
