using System;


namespace IntroductionToCsharp
{
    class Program
    {

        //output parameters are sum, prod
        public static void calculate(int x, int y, out int sum, out int prod)
        {
            sum = x + y;
            prod = x * y;
        }

       
        public static void Main(string[] args)
        {
            int sum = 0;
            int product = 0;
            calculate(10, 20, out sum, out product);
            Console.WriteLine(sum + " , " + product);
        }
    }
}
