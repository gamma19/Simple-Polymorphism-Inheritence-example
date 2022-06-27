using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
   class Program
    {

        static void Main(string[] args)
        {
            
            //objects
            Employee e1 = new Employee("Utku Enes Baki",23,123456,10000);
            Employee e2 = new Employee("Gabe Newell", 56, 789123, 50000);
            SalariedEmployee se1 = new SalariedEmployee("David Goggins", 20, 546132, 25000,349857);
            ComissionSalariedEmployee cse1 = new ComissionSalariedEmployee("Cave Johnson", 45, 654234, 60000, 546234,3.5);
         

            Console.WriteLine(e1.toString());
            Console.WriteLine(e2.toString());
            Console.WriteLine(se1.toString());

            


            














        }


    }

}
    
    


   




