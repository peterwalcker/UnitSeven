using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitSeven.Classes
{
    abstract class Delivery
    {
        private string address;
        private DeliveryBoy boy;
        public Delivery(string address) { this.address = address; }
        public void Assemble(Cart cart)
        {
            foreach(var product in cart.GetProducts())
            {
                Console.WriteLine("Assembling " + product.GetAssembleInfo());
            }
        }
        public virtual void Deliver(DeliveryBoy Boy)
        {
            boy = Boy;
            boy.GoToWork(address);
        }
        public virtual void Delivered()
        {
            Console.WriteLine("Order delivered");
            boy.SetFree();
        }
    }

    internal class HomeDelivery : Delivery
    {
        public HomeDelivery(string address) : base(address)
        {
        }
    }

    internal class PickPointDelivery : Delivery
    {
        private int CellId;
        public PickPointDelivery(string address) : base(address)
        {
            this.CellId = new Random().Next(32);
            //not implemented, generates random cell id
        }
        public override void Delivered()
        {
            base.Delivered();
            Console.WriteLine($"Cell id is {this.CellId}");
        }
    }

    internal class PickupDelivery : Delivery
    {
        public PickupDelivery(string address) : base(address)
        {

        }

        public override void Deliver(DeliveryBoy boy)
        {
            //Just waiting for client arrival
        }
    }
}
