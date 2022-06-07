using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal class ProductStockCountException:Exception
    {
        public ProductStockCountException(string msg) : base(msg)
        {

        }
       
    }
}
