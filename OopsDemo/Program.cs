using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Employee emp=new Employee
            {
                EmpId=101,
                Name="Anand",
                Dept=new Department
            }

            Analyst al=new Analyst
            {
                EmpId=323,
                Name="vijaya",

            }*/

        }

      
        
            public static void demo()
            {
                //Demo d = new Demo();
                Demo d1 = new Demo(12, 23);
                Demo d2 = new Demo(23, 12);

                Demo da = d1 + d2;
                Demo ds = d1 - d2;

                da.show();
                ds.show();

            }
            Demo d1 = new Demo(12, 23);
            Demo d2 = new Demo(23, 12);

            Demo da = d1 + d2;
            Demo ds = d1 - d2;

            da.show();
            ds.show();
           

        }


    }
}
