using System;


namespace IntroductionToCsharp
{
    class Program
    {

        static void change(ref int i) //pass variable i by reference
        {
            i = 100;
        }

       
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine(i);
            change(ref i);
            Console.WriteLine(i);

        }
    }
}
