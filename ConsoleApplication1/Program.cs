using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the number of integers in array (n) and the number of shifts (d)");
           
            string[] tokens_n = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(tokens_n[0]); //nb of elements in array
            int d = Convert.ToInt32(tokens_n[1]); //nb of shifts 
            

            int[] a = new int[n];

            Console.WriteLine($"Insert the {n} members of the array  ");
            string[] a_temp = Console.ReadLine().Split(' ');
            a = Array.ConvertAll(a_temp, int.Parse); //the array

            int minshifts = d % a.Length;


            if ((n >= 1) && (n <= Math.Pow(10, 5)) && ((d >= 1) && (d <= n)))
            {
                Console.WriteLine($"\n After {d} shifts the array is : \n");
                for (int i = 0; i < minshifts; i++)
                {
                    Shift(a);
                    
                }

                foreach (int i in a)
                {
                    
                    Console.Write($"{i} ");
                    
                }
                

                Console.ReadKey();

            }

            else
            {
                Console.WriteLine("number of integers in array or the number of shifts is not in the right format ");
            }



        }

        private static void Shift(int[] a)
        {
            int firstElement = a[0];
            for (int i = 0; i < a.Length - 1; i++)
            {
                a[i] = a[i + 1];

            }
            a[a.Length - 1] = firstElement;
        }
    }
}
