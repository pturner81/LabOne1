using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, firstNum1, firstNum2, firstNum3, firstNum4, secondNumber, secNum1, secNum2, secNum3, secNum4;
           string firstNumberTest, secondNumberTest;
            

            Console.WriteLine("What are the last four digits of your phone number?");
            firstNumberTest =Console.ReadLine();
            bool isNumerical = Int32.TryParse(firstNumberTest, out firstNumber);
            
              
                // check to ensure input is a number            
                while (firstNumber / 1000 > 9 || firstNumber - 1000 < 0)
                {
                    Console.WriteLine("System is unable to read that- looks like it was not 4 digits. Please re-enter the last four digits of your phone number.");
                    firstNumber = Convert.ToInt32(Console.ReadLine());
                }
                            // checks to ensure the number entered has 4 digits
                firstNum1 = Convert.ToInt32(firstNumber / 1000);
                firstNum2 = Convert.ToInt32((firstNumber - (firstNum1 * 1000)) / 100);
                firstNum3 = Convert.ToInt32((firstNumber - (firstNum1 * 1000 + firstNum2 * 100)) / 10);
                firstNum4 = Convert.ToInt32(firstNumber - (firstNum1 * 1000 + firstNum2 * 100 + firstNum3 * 10));
                            // defines each place in the firstNumber to compare to the secondNumber


                Console.WriteLine("What are the last four digits of your zip code?");
            secondNumberTest = Console.ReadLine();
                bool isNumerical2 = Int32.TryParse(secondNumberTest, out secondNumber);
      
                            // checks to ensure input is a number

            while (secondNumber / 1000 > 9 || secondNumber - 1000 < 0)
                {
                    Console.WriteLine("System is unable to read that - looks like it was not 4 digits. Please re-enter the last four digits of your zip code.");
                    secondNumber = Convert.ToInt32(Console.ReadLine());
                }           // checks to ensure the number entered has 4 digits
                secNum1 = Convert.ToInt32(secondNumber / 1000);
                secNum2 = Convert.ToInt32((secondNumber - (secNum1 * 1000)) / 100);
                secNum3 = Convert.ToInt32((secondNumber - (secNum1 * 1000 + secNum2 * 100)) / 10);
                secNum4 = Convert.ToInt32(secondNumber - (secNum1 * 1000 + secNum2 * 100 + secNum3 * 10));
                               // defines each place in the secondNumber to compare to the firstNumber

            /*Console.WriteLine(firstNum1);
            Console.WriteLine(firstNum2);
            Console.WriteLine(firstNum3);
            Console.WriteLine(firstNum4);
            Console.WriteLine(secNum1);
            Console.WriteLine(secNum2);
            Console.WriteLine(secNum3);
            Console.WriteLine(secNum4);
                                           // used to check if variables were defined correctly*/
              if (((firstNum1 + secNum1) == (firstNum2 + secNum2)) && ((firstNum1 + secNum1) == (firstNum3+secNum3)) && ((firstNum4+secNum4) == firstNum1+secNum1))
              {
                  Console.WriteLine("True (each corresponding place in the two numbers sums to the same total");
              }
              else
              {
                  Console.WriteLine("False (each corresponding place in the two numbers does not sum to the same total)");
              }               // tests if corresponding places in the two numbers are all equal           
                        Console.ReadKey();
        }
    }
}
