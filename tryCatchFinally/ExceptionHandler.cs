using System;
using System.Collections.Generic;
using System.Text;

namespace tryCatchFinally
{
    class ExceptionHandler
    {
        static int[] numbers = { 1, 5, 8, 4, 15 };
        public static bool WrongAnswer ; // if user inter an index out of the range of index sende an error massege

        public static int GetNumber(int index)
        {
            int output = -1; //we know that all of the numbers is positive
 
            try
            {
                output= numbers[index];
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally //it is run after try or catch works
            {
                if (output == -1)
                {
                    
                    WrongAnswer = true;
                }
                else
                {
                  
                    WrongAnswer = false;
                }
                
            }
            return output;


        }
    }
}
