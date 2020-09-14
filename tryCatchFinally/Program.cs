using System;

namespace tryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {

            //program ask a user to inter an index and program return a number from index

            Console.WriteLine("Please inter an index!");
            int index = Convert.ToInt32(Console.ReadLine());


            int result= ExceptionHandler.GetNumber(index);

            if (ExceptionHandler.WrongAnswer ==true)
            {
                Console.WriteLine("The index was wrong!");
            }
            else
            {

                Console.WriteLine($"The number is {result}"); 
            }
            
           

            Console.WriteLine("Please a press a key to exit!");
            Console.ReadKey(true);
        }
    }
}
