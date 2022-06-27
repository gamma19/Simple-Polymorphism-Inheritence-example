using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class ComissionSalariedEmployee : SalariedEmployee , IPayable
    {
        private double comision;

        public ComissionSalariedEmployee(string name, int age, int id, int salary ,int ssiNumber,double comision) : base(name, age, id, salary, ssiNumber)
        {
            this.comision = comision;
        }

        public int getPaymentAmount()
        {

            return (int)(comision * 234);

        }
    }
}
