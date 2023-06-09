namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation");

            Console.WriteLine("Enter the value of X1");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of Y1");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of X2");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of Y2");
            double y2 = Convert.ToDouble(Console.ReadLine());


            double lineLength = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)));
            Console.WriteLine($"The Length of the Line is {lineLength}");
        }
    }
}