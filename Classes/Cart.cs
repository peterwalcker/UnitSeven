using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitSeven.Classes
{
    internal class Cart
    {
        private List<InCartProduct> products;
        public int Count = 0;

        internal Cart() => products = new(); 
        
        internal void AddToCart(Product product, int count)
        {
            products.Add(new InCartProduct(product, count));
            Count++;
        }

        internal List<InCartProduct> GetProducts()
        {
            return products;
        }
    }

    internal class InCartProduct
    {
        Product product;
        int count;

        internal InCartProduct(Product product, int count)
        {
            this.product = product;
            this.count = count;
        }

        internal string GetAssembleInfo()
        {
            return product.ToString() + "\t-\t" + count; ; 
        }

        public override string ToString()
        {
            return product.ToString() + "\t-\t" + count + "\t-\t" + product.GetPrice().ToString();
        }
    }
}
