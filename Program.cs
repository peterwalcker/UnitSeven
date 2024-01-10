namespace UnitSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    #region task_7_1_10
    /// <summary>
    /// task 7.1.10
    /// </summary>
    class BaseClass
    {
        protected string Name;

        public BaseClass(string name)
        {
            Name = name;
        }
    }

    class DerivedClass : BaseClass
    {
        public string Description;

        public int Counter;

        public DerivedClass(string name, string description) : base(name)
        {
            Description = description;
        }

        public DerivedClass(string name, string description, int counter) : this(name, description)
        {
            Counter = counter;
        }
    }
    #endregion

    #region task_7_1_6
    /// <summary>
    /// task 7.1.6
    /// </summary>
    class Obj
    {
        private string name;
        private string owner;
        private int length;
        private int count;

        public Obj(string name, string ownerName, int objLength, int count)
        {
            this.name = name;
            owner = ownerName;
            length = objLength;
            this.count = count;
        }
    }
    #endregion

    #region task_7_1_5   
    /// <summary>
    /// task 7.1.5
    /// </summary>
    class Food { }
    class Fruit : Food { }
    class Vegetable : Food { }
    class Apple : Fruit { }
    class Banana : Fruit { }
    class Pear : Fruit { }
    class Potato : Vegetable { }
    class Carrot : Vegetable { }
    #endregion

    #region task_7_1_4
    /// <summary>
    /// task 7.1.4
    /// </summary>
    class Employee
    {
        public string Name;
        public int Age;
        public int Salary;
    }

    class ProjectManager : Employee
    {
        public string ProjectName;
    }

    class Developer : Employee
    {
        public string ProgrammingLanguage;
    }
    #endregion
}
