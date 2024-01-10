namespace UnitSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    #region task_7_6_6
    /// <summary>
    /// task 7.6.2
    /// </summary>
    /// <typeparam name="T">ID</typeparam>
    /// <typeparam name="K">Value</typeparam>
    class Record<T, K>
    {
        public T Id;
        public K Value;
        public DateTime Date;
    }
    #endregion

    #region task_7_6_2
    /// <summary>
    /// task 7.6.2
    /// </summary>
    abstract class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;

        public abstract void ChangePart<TPart>(TPart newPart) where TPart : Part;
    }

    class GasCar : Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart) { }
    }

    class ElectricCar : Car<ElectricEngine>
    {
        public override void ChangePart<TPart>(TPart newPart) { }
    }

    abstract class Engine { }
    
    abstract class Part { }
    
    class GasEngine : Engine { }
    
    class ElectricEngine : Engine { }

    class Battery : Part { }

    class Differential : Part { }

    class Wheel : Part { }
    #endregion
}
