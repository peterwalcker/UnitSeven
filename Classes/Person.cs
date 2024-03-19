using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace UnitSeven.Classes
{
    abstract internal class Person 
    {
        internal int id;
        internal string firstName;
        internal string lastName;

        internal Person(string firstName, string lastName)
        {
            this.id = Indexer.GenerateID();
            this.firstName = firstName;
            this.lastName = lastName;
        }
        
    }

    internal class Employee : Person
    {
        internal Employee(string firstName, string lastName) : base(firstName, lastName) { }
        internal Employee(string firstName) : this(firstName, "") { }
    }

    internal class DeliveryBoy : Employee
    {
        private static List<DeliveryBoy> _deliveryBoys;
        private bool _isFree;
        internal DeliveryBoy(string firstName, string lastName) : base (firstName, lastName) 
        { 
            _isFree = true; 
            _deliveryBoys.Add(this); 
        }

        internal static DeliveryBoy Get()
        {
            var boy = _deliveryBoys.FirstOrDefault(d => d._isFree);
            boy._isFree = false;
            return boy;
        }

        internal void GoToWork(string address)
        {
            Console.WriteLine("Delivering to " + address);
        }

        internal void SetFree()
        {
            _deliveryBoys.Find(d => d ==  this)._isFree = true;
        }
    }

    internal class Client : Person
    {
        internal ClientInfo info;
        internal Client(string firstName, string lastName) : base(firstName, lastName) { }
        internal Client(string firstName) : this(firstName, "") { }
        internal Client(string firstName, string lastName, string address) : this(firstName, lastName)
        {
            info = new ClientInfo(address);
        }
    }

    internal class ClientInfo
    {
        private string Address;

        internal ClientInfo(string Address)
        {
            this.Address = Address;
        }

        internal string GetAddress()
        {
            return this.Address;
        }
    }
}
