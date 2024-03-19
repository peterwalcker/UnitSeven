using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitSeven.Classes
{
    internal class Order
    {
        internal IOrderState State;
        private Client client;
        private Cart cart;
        internal Delivery delivery;

        internal Order(IOrderState State)
        {
            this.State = State;
        }

        internal Order() : this(new StatusCreating()) { }

        internal void NextStep()
        {
            State.NextStep(this);
        }

        internal void Cancel()
        {
            State.Cancel(this);
        }

        internal void AddClient((string FirstName, string LastName, string Address) client)
        {
            this.client = new(client.FirstName, client.LastName, client.Address);
        }

        internal bool IsAuthorized()
        {
            return client != null;
        }

        internal void AddToCart(Product product, int count)
        {
            cart.AddToCart(product, count);
        }

        internal Cart GetCart()
        {
            return cart;
        }

        internal void ChooseDelivery(int type = 0)
        {
            switch (type)
            {
                case 0:
                    delivery = new HomeDelivery(client.info.GetAddress());
                    break;
                case 1:
                    delivery = new PickPointDelivery(client.info.GetAddress());
                    break;
                case 2:
                    delivery = new PickupDelivery(client.info.GetAddress());
                    break;
                default:
                    Cancel();
                    break;
            }
        }

        internal void Assemble()
        {
            this.delivery.Assemble(cart);
        }
    }

    interface IOrderState
    {
        void NextStep(Order order);
        void Cancel(Order order)
        {
            order.State = new StatusCanceled();
        }
    }

    internal class StatusCreating : IOrderState
    {
        public void NextStep(Order order)
        {
            if(!order.IsAuthorized())
            {
                (string, string, string) client = (Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                order.AddClient(client);
            }

            
            
            while (Console.ReadLine() != "-1")
            {
                string inputProduct = Console.ReadLine();
                string inputCount = Console.ReadLine();
                
                bool CountIsNumeric = int.TryParse(inputProduct, out int count);
                if (int.TryParse(inputProduct, out int value))
                {
                    if (CountIsNumeric) order.AddToCart(Product.GetById(value), count);
                }
                else
                {
                    if (CountIsNumeric) order.AddToCart(Product.GetByName(inputProduct), count);
                }
            }

            order.State = new StatusAssembling();
        }
    }

    class StatusAssembling : IOrderState
    {
        public void NextStep(Order order)
        {
            order.Assemble();
            Sell sell = new Sell("Sell", "Please come again", order.GetCart());
            Console.WriteLine(sell.Print());
            order.State = new StatusDelivering();
        }
    }

    //Delivering in action
    class StatusDelivering : IOrderState
    {
        public void NextStep(Order order)
        {
            order.delivery.Deliver(DeliveryBoy.Get());
            order.State = new StatusDelivered();
        }
    }

    class StatusDelivered : IOrderState
    {
        public void NextStep(Order order)
        {
            order.delivery.Delivered();
            order.State = new StatusReceived();
        }
    }

    class StatusReceived : IOrderState
    {
        public void NextStep(Order order)
        {
            Console.WriteLine("Order already have been received");
        }
        void Cancel(Order order)
        {
            Console.WriteLine("Order already have been received");
        }
    }

    class StatusCanceled : IOrderState
    {
        public void NextStep(Order order)
        {
            order.State = new StatusCreating();
        }
    }

}
