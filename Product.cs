using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal class Product
    {
        public string No;
        public string Name;
        public double Price;
        public int Count;

        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name} - No:{No} - Price:{Price} - Count:{Count}");
        }

    }
}
