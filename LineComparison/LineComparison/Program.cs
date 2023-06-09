using System.Security.Cryptography.X509Certificates;

namespace LineComparison
{
    internal class Program
    {
        public static double GetLineLength(double x1, double y1, double x2, double y2)
        {
            double length = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)));
            return length;
        }
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

            Console.WriteLine("================2nd Line Point===============");
            Console.WriteLine("Enter the value of X3");
            double x3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of Y3");
            double y3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of X4");
            double x4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of Y4");
            double y4 = Convert.ToDouble(Console.ReadLine());

            
            double firstLineLength = GetLineLength(x1, y1, x2, y2);
            double secondLineLength = GetLineLength(x3, y3, x4, y4);

            if (firstLineLength == secondLineLength)
            {
                Console.WriteLine("The line length are equal");
            }
            else if (firstLineLength > secondLineLength)
            {
                Console.WriteLine("First line is greater than Second line");
            }
            else
            {
                Console.WriteLine("Second line is greater than First Line");
            }
        }
       
    }
}