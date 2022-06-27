using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Employee
    {
        //data-fields
        private string name;
        private int age;
        private int ID;
        private int salary;


        //parameterized-constructor
        public Employee(string name, int age, int id, int salary)
        {
            this.name = name;
            this.age = age;
            this.ID = id;
            this.salary = salary;
        }

        //getters
        public string getName
        {
            get
            {
                return name;
            }

        }

        //setters
        public string setName
        {
            set 
            {
                this.name = name;
            }
        }

        //toString()
        public string toString()
        {
            return "Name: " + name + "\n" + "Age: " + age.ToString() + "\n";
        }

        public string edaNur()
        {
            return "edanur";
        }

       
    }
}
