﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    public class NumberSystem
    {
        public void Fibonacci()
        {
            int n1 = 0;
            int n2 = 1;
            int n3, i;
            Console.WriteLine("Enter the number of Elements: ");
            int number = Convert.ToInt32(Console.ReadLine());
            // printing the value 0 and 1
            Console.WriteLine(n1 + " " + n2 + " ");
            // loop starts from 2 because 0 and 1 is already printed.
            for(i = 2; i< number; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3 + " ");
                n1 = n2;
                n2 = n3;

            }
        }
        public void PerfectNumber()
        {
            int n, r, sum = 0, number;
            Console.WriteLine("Enter the number: ");
            number = int.Parse(Console.ReadLine());
            n = number;
           
            for(int i = 1; i < number; i++)
            {
                if(number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine(" Entered the number is a perfect number");
                
            }
            else
            {
                Console.WriteLine("Entered the number is not a perfect number");
                
            }
            
                
            
        }
    }
}
