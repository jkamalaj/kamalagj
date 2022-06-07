using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5

{
    public class BravoMarket : IStore
    { 
        public BravoMarket(int limit)
        {
            _products = new Product[0];
            ProductLimit = limit;
        }
        private Product[] _products ;
        public Product[] Products => _products;
       
        private double _totalInCome;
                
        public int ProductLimit { get; set; }
        public double TotalInCome => _totalInCome;

        public void SellProduct(string no)
        {
            Product product = FindProductByNo(no);

            if (product == null)
                throw new ProductNouFoundException("There is not any product with no: {no}");
            
            {
                if (product.Count < 1)
                    throw new ProductStockCountException("The product is stock out");
                {
                    _totalInCome += product.Price;
                    product.Count--;
                }
            }
        }

      




        void IStore.AddProduct(Product product)
        {
            if (ProductLimit > _products.Length && !IsExistProductByNo(product.No))
            {


                Array.Resize(ref _products, _products.Length + 1);
                _products[_products.Length - 1] = product;
            }
        }  
  

            
        public Product FindProductByNo(string no)
        {
            Product product = null;
            foreach(var pr in _products)
            {
                if (pr.No== no)
                {
                    product = pr;
                    break;
                }
            }
            return product;
        }
        
       
        
        public bool IsExistProductByNo(string no)
        {
            foreach (var pr in _products)
            {
                if (pr.No == no)
                {
                    return true;
                }
            }
            return false;
        }
                

        
    }
}
