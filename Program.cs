namespace UnitSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    #region task_7_3_3

    abstract class ComputerPart
    {
        public abstract void Work();
    }

    class Processor : ComputerPart
    {
        public override void Work() { }
    }
    
    class MotherBoard : ComputerPart
    {
        public override void Work() { }
    }
    
    class GraphicCard : ComputerPart
    {
        public override void Work() { }
    }
    #endregion
}
