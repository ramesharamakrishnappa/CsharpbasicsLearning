using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CsharpConcepts
{
   public class CSharpBasics
    {
       public static void Main(string[] args)
        {
            byte varByte;
                varByte =6;
            //Console.WriteLine(varByte);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);
            int j = 2147483647;
            Console.WriteLine(int.MinValue);
            Console.WriteLine(  int.MaxValue);
            Console.ReadLine();

            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            //arr[3] = 4;
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

            int[] arr1 = new int[10] { 0,1,1,1,5,5,2,2,1,2};
            int[] count = new int[10];

            foreach (int i in arr1)
            {
                Console.WriteLine(count[i]);
                Console.WriteLine(++count[i]); 
            }
            Console.WriteLine($"count of 0 is {count[0]} ,count of 1 is {count[1]}");

        }
    }
}
