using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CsharpConcepts
{
    class ArraysExample
    {
        public static void Main(String[] args)
        {
            int[] arr = new int[10];
            arr[0] = 1;
            arr[1] = 0;
            arr[2] = 0;
            arr[3] = 0;
            arr[4] = 1;
            arr[5] = 1;
            arr[6] = 0;
            arr[7] = 1;
            arr[8] = 0;
            arr[9] = 1;
            int countOne = 0;
            int countZero = 0;

            foreach (int number in arr)
            {
                if (number == 1)
                {
                    countOne++;
                }
                else
                {
                    countZero++;

                }
            }
            Console.WriteLine($"The count for One's in the given array is {countOne}");
            Console.WriteLine($"The count for Zero's in the given array is {countZero}");

            foreach (int number in arr)
            {

            }

        

            }

    }
    }

