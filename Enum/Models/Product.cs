using System;
using System.Collections.Generic;
using System.Text;

namespace Enum.Models
{
    class Product
    {
        private static int ID = 1000;
        
        public string Code;
        public string Name;
        public double Price;
        public double DiscountedPrice;
        private static int TotalCount = 0;

        public Product(ProductType a, double b)
        {
            string aa = a.ToString();
            char firstletter = aa[0];
            Price = b;
            ProductTypeMethod(a);
           
            ID++;
            Code = $"{firstletter}{ID}";
            TotalCount++;


            



        }   

        public void ProductTypeMethod(ProductType b)
        {
            if(b == ProductType.Bakery)
            {
                DiscountedPrice = Price - (Price * 10) / 100;
                

            }
            DiscountedPrice = Price;

        }
            
            
           
            



        

    }
}
