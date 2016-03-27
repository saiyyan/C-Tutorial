using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace IntroductionToCsharp
{
    class Program
    {

        //instance method (non static method) needs to be invoked using an instance of the class
        void foo()
        {
        }

        static void Main(string[] args)
        {
            /*Console.WriteLine("Welcome...What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("What is your lastname?");
            string lastName = Console.ReadLine();
            //Console.WriteLine("Hello, " + userName);
            Console.WriteLine("Hello, {0} {1}", userName, lastName);*/
            int x = 9; //x ranges from 0 to 255
            int r = Marshal.SizeOf(x);
            sbyte y; //y ranges from -128 to 127

            ////Nullable data types:
            //to make a value type (such as integer) nullable, add a qn mark:
            //you can convert between nullable and non-nullable types by simply casting
            int? n = null;
            bool? a = null;
            x = (int)n;    // or: x = n.Value();
            x = n ?? 0; //if (n == null) x = 0

            //conversions:
            string strNum = "100";
            int intNum = int.Parse(strNum);
            string strBS = "123bs";
            bool didItConvert = int.TryParse(strBS, out intNum); //if success, then converted num goes to intNum

            //arrays
            int[] evens = new int[3];


            Program p = new Program();
            p.foo();



        }
    }
}
