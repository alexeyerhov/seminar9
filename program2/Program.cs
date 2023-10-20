using System;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
            //M = 1; N = 15 -> 120
            //M = 4; N = 8. -> 30

            int FindSumOfNaturalNumbers(int m, int n){
                if (m<n) { 
                    return n + FindSumOfNaturalNumbers(m,n-1);                  
                }    
                else return m;           
            }
            Console.WriteLine("Enter M number :");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter N number :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sum of numbers from M to N is: {FindSumOfNaturalNumbers(m,n)}");
            
        }
    }
}
