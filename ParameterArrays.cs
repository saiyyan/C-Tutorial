using System;


namespace IntroductionToCsharp
{
    class Program
    {

        //use params keyword for arrays that are parameters to a function
        //signficance of params keyword: even if nums is not passed in, the function
        //will still run
        //also, if you can list out the parameters as shown below if params keyword is used
        public static void calculate(  params int[] nums)
        {
            Console.WriteLine(nums.Length);
            foreach(int i in nums)
            {
                Console.WriteLine(i);
            }
        }

       
        public static void Main(string[] args)
        {
            int[] nums = new int[3];
            nums[0] = 101;
            nums[1] = 102;
            nums[2] = 103;
            calculate();
            calculate(nums);
            calculate(1, 2, 3, 4);
        }
    }
}
