using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitSeven.Classes
{
    abstract internal class Document<T>
    {
        private int _id;
        private string _header;
        protected string?[] _body;
        private string _footer;

        internal Document(string header, string footer)
        {
            _header = header;
            _footer = footer;
            _body = new string[0];
            _id = Indexer.GenerateID();
        }

        abstract private protected void AddTAble(T table);

        internal virtual string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(_header + " №" + _id);
            foreach (var item in _body)
            {
                sb.AppendLine(item);
            }
            sb.AppendLine(_footer);
            return sb.ToString();
        }
    }

    internal class Sell  : Document<Cart>
    {
        internal Sell(string header, string footer, Cart cart) : base(header, footer)
        {
            AddTAble(cart);
        }
        private protected override void AddTAble(Cart cart)
        {
            _body = new string[cart.Count];
            int i = 0;
            foreach (var cartItem in cart.GetProducts())
            {
                _body[i] = cartItem.ToString();
                i++;
            }
        }
    }
}
