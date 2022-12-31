using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP.Entities
{
    internal class OutSourceEmployee : Employee
    {
        public double AdditionanCharge { get; set; }

        public OutSourceEmployee()
        {
        }

        public OutSourceEmployee(string name, int hours, double valuePerHour,double additionanCharge) : base( name,hours,valuePerHour)
        {
            AdditionanCharge = additionanCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionanCharge;
           
            
        }

    }
}
