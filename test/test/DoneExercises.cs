using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class DoneExercises 
    {
        /*==========Question 1==========

            Console.Write("Num1?: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Num2?: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Your sum is: {0}", (num1 + num2)*3);
            }
            else
            {
                Console.WriteLine("Your sum is: {0}", num1 + num2);
            }
            */


        /*============Question 2===========
        Console.Write("Enter n value: ");
        int n = Convert.ToInt32(Console.ReadLine());


        if (n > 51)
        {
            Console.WriteLine("Abs difference between n and 51 is: {0}",(Math.Abs(n-51))*3);
        }
        else
        {
            Console.WriteLine("Abs difference between n and 51 is: {0}", Math.Abs(n - 51));
        }
        */


        /*===========Question 3=========
        bool isThirty;
        int counter = 3;

        while (true)
        {
            Console.Write("Enter first value: ");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second value: ");
            int j = Convert.ToInt32(Console.ReadLine());


            if (i == 30 || j == 30)
            {
                Console.WriteLine(isThirty = true);
                counter--;
                Console.WriteLine("You have {0} guesses left.",counter) ;
            }
            else if (i + j == 30)
            {
                Console.WriteLine(isThirty = true);
                counter--;
                Console.WriteLine("You have {0} guesses left.", counter);

            }
            else
            {
                Console.WriteLine(isThirty = false);
                counter--;
                Console.WriteLine("You have {0} guesses left.", counter);

            }

            if (counter == 0)
            {
                break;
            }
        }
        
        ================Calculator=====================
        int x;
        int[] nums = new int[2];


        Console.WriteLine("========Welcome to my calculator!=========");
            Console.Write("Enter num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine(
                "Press 0 to summerize.\n" +
                "Press 1 to substract.\n" +
                "Press 2 to add values to memory.\n" +
                "Press 3 to add write values in memory.\n"+
                "Press 4 to add delete values in memory.\n"

                );
            

            do
            {
                Console.Write("Enter Your Operand: ");
                x = Convert.ToInt32(Console.ReadLine());

                //switch-case
                switch (x)
                {
                    case 0:
                        Console.WriteLine(num1 + num2);
                        break;
                    case 1:
                        Console.WriteLine(num1 - num2);
                        break;
                    case 2:
                        nums[0] = num1;
                        nums[1] = num2;
                        Console.WriteLine("Num1 has been added to memory successfully.");
                        break;
                    case 3:
                        Console.WriteLine("====Nums in memory are==== ");
                        foreach (var t in nums)
                        {
                            Console.WriteLine(t);
                        }
                        break;
                    case 4:
                        nums[0].ToString("null");
                        nums[1].ToString("null");
                        break;
                    default:
                        Console.WriteLine("You've entered the wrong input.");
                        break;

                }

            }while (true) ;
    */
        public int getPaymentAmount{get; set;}

 

    }
}
