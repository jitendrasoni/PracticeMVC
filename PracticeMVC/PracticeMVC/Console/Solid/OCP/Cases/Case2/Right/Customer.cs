﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Cases.Case2.Right
{
    class Customer
    {
        public virtual double getDiscount(double TotalSales)
        {
            return TotalSales;
        }
    }
}   
