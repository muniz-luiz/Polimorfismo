using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Polimorfismo.Entities
{
    internal class OutsourceEmployee : Employee
    {
        public double AditionalCharge { get; set; }



        public OutsourceEmployee(double additionalCharge)
        {
            AditionalCharge = additionalCharge;
        }

        public OutsourceEmployee()
        {

        }
        public OutsourceEmployee(string name, int hours, double valuePerHour) : base(name, hours, valuePerHour)
        {
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AditionalCharge;
        }
    }





}
