namespace UnitSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    #region task_7_5_9

    static class intExtensions
    {
        static int GetNegative(this int a)
        {
            if (a <= 0) return a;
            else return -a;
        }
        
        static int GetPositive(this int a)
        {
            if (a >= 0) return a;
            else return -a;
        }
    }
    #endregion

    #region task_7_5_5
    /// <summary>
    /// task 7.5.5
    /// </summary>
    class Obj
    {
        public string Name;
        public string Description;

        public static string Parent;
        public static int DaysInWeek;
        public static int MaxValue;

        static Obj()
        {
            Parent = "System.Object";
            DaysInWeek = 7;
            MaxValue = 2000;
        }
    }
    #endregion

    #region task_7_5_3
    /// <summary>
    /// task 7.5.3
    /// </summary>
    class Helper
    {
        public static void Swap(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }
    }
    #endregion

    #region task_7_5_2
    /// <summary>
    /// task 7.5.2
    /// </summary>
    class Obj
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public static int MaxValue = 2000;
    }
    #endregion
}
