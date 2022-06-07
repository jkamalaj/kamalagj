using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal class ProductNouFoundException:Exception
    {
        public ProductNouFoundException(string msg) : base(msg)
        {

        }
    }
}
