using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class Analyst :Employee
    {
        public override string empSalary(double sal)
        {
            //return base.empSalary(sal);
            double incentive = 4000;
            double total = incentive + sal;
            return total.ToString();
        }                                                                                                           

    }
}
