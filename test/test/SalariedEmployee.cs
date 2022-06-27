using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class SalariedEmployee : Employee , IPayable
    {
        private int ssiNumber;

        //base
        public SalariedEmployee(string name,int age,int id,int salary,int ssiNumber) : base(name, age, id, salary)
        {
            this.ssiNumber = ssiNumber;

        }

         public int getPaymentAmount()
        {
            
                return ssiNumber;
            
        }
    }
}
