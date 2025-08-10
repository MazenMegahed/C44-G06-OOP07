namespace Assignment_OOP7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.WriteLine(Maths.Add(5, 50) );
            Console.WriteLine(Maths.Subtract(5, 50)) ;
            Console.WriteLine(Maths.Multiply(5, 50));
            Console.WriteLine(Maths.Divide(5, 50));
            double[] numm = { 5, 50, 5 };

            Console.WriteLine(Maths.Avg(numm));
            Console.WriteLine(Maths.Power(2, 3));
            Maths.SHOWOPERATIONSCOUNT();
            #endregion
        }
    }
}
