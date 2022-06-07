using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal interface IStore
    {
        Product[] Product { get; }
        int ProductLimit { get; set; }
        Double TotalInCome { get; set; }
        void AddProduct(Product product);
        void SellProduct(string No);
        

        

    }
}
