namespace UnitSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    #region task_7_2_14
    /// <summary>
    /// task 7.2.14
    /// </summary>
    class IndexingClass
    {
        private int[] array;

        public IndexingClass(int[] array)
        {
            this.array = array;
        }

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                {
                    return array[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            private set
            {
                if (index >= 0 && index < array.Length)
                {
                    array[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }

        }
    }
    #endregion

    #region task_7_2_12
    /// <summary>
    /// task 7.2.12
    /// </summary>
    class Obj
    {
        public int Value;

        public static Obj operator + (Obj x, Obj y)
        {
            return new Obj()
            {
                Value = x.Value + y.Value
            };
        }
        public static Obj operator - (Obj x, Obj y)
        {
            return new Obj()
            {
                Value = x.Value - y.Value
            };
        }
    }
    #endregion

    #region task_7_2_7
    /// <summary>
    /// task 7.2.7
    /// </summary>
    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("A");
        }
    }
    
    class B : A
    {
        public new void Display()
        {
            Console.WriteLine("B");
        }
    }
    
    class C : A
    {
        public override void Display()
        {
            Console.WriteLine("C");
        }
    }
    
    class D : B
    {
        public new void Display()
        {
            Console.WriteLine("D");
        }
    }
    
    class E : C
    {
        public new void Display()
        {
            Console.WriteLine("E");
        }
    }
    #endregion

    #region task_7_2_4
    /// <summary>
    /// task 7.2.4
    /// </summary>
    class BaseClass
    {
        public virtual int Counter { get; set; }
    }

    class DerivedClass : BaseClass
    {
        private int counter;
        public override int Counter
        {
            get
            {  
                return counter;
            }
            set
            {
                if (value >= 0)
                {
                    counter = value;
                }
                else
                {
                    Console.WriteLine("Number have to be equal or greater than zero");
                }
            }

        }
    }
    #endregion

    #region task_7_2_3
    /// <summary>
    /// task 7.2.3
    /// </summary>
    class BaseClass
    {
        public virtual void Display()
        {
            Console.WriteLine("BaseClass method");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void Display()
        {
            base.Display(); // task 7.2.5
            Console.WriteLine("DerivedClass method");
        }
    }
    #endregion
}
