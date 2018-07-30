using System;

namespace WeekFourArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating and initializing the "Mekarrays" and the values
            int[] Mekarrays = new int[] { 1, 1, 2, 3, 5, 8 };

            //Looping using 'foreach' vs 'for' to create a single line
            foreach (int digits in Mekarrays)
             {
                //Telling compiler to write the #s
                //with a space inbetween each value
                Console.Write("{0} ", digits);
             }
             Console.ReadLine();
             

            
        }

    }
}
