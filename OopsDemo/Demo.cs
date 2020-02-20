using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class Demo
    {
        int no;
        int no1;
        public Demo()
        {

        }
        public Demo(int v, int r)
        {
            this.no = v;
            this.no1 = r;
        }
        public static Demo operator +(Demo x, Demo y)
        {
            Demo t = new Demo();
            t.no = x.no + y.no;
            t.no1 = x.no1 + y.no1;
            return t;
        }
        public static Demo operator -(Demo x, Demo y)
        {
            Demo t = new Demo();
            t.no = x.no - y.no;
            t.no1 = x.no1 - y.no1;
            return t;
        }
        public void show()
        {
            Console.WriteLine("The numbers are {0} and {1}", no, no1);
        }
    }
}














