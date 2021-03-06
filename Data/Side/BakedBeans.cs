﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class BakedBeans : Side
    {
        /// <summary> 
        /// initializes the values for the prices of various sizes
        /// </summary>
        public BakedBeans()
        {
            prices = new double[] { 1.59, 1.79, 1.99 };
            calories = new uint[] { 312, 378, 410 }; 
        }

        /// <summary>
        /// side represented by a string
        /// </summary>
        /// <returns>name and size of side</returns>
        public override string ToString()
        {
            return size.ToString() + " Baked Beans";
        }
    }
}
