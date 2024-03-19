using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitSeven.Classes
{
    internal class Product
    {
        private static List<Product> _products = new List<Product>();
        private int Id { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private decimal Price { get; set; }

        internal Product(string Name, string Description, decimal Price)
        {
            this.Id = Indexer.GenerateID();
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;

            _products.Add(this);
        }

        internal static Product GetById(int ID)
        {
            return _products.First(p => p.Id == ID);
        }

        internal static Product GetByName(string Name)
        {
            return _products.First(p => p.Name == Name);
        }

        public override string ToString()
        {
            return "[" + Id.ToString() + "] " + Name;
        }

        internal decimal GetPrice()
        {
            return Price;
        }
    }
}
