using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace OopsDemo
{
    class Customer
    {
        public string cid;
        public string name, address;
        public void get(int i, string cname, string add)
        {
            cid = i;
            name = cname;
            address = add;
        }

    }
   
    class Bankaccount
    {
        int accountnumber, balance;
        Customer c;
        int principle = 1000, rate = 3, time = 2;
        private string accno;

        public void bankDetail(int accno, int bal, Customer c)
        {
            accountnumber = accno;
            balance = bal;
            this.c = c;
        }

        public virtual double interestamount(double p,int t,double r)
        {
            double simpleinterest = (p * t * r) / 100;
            return simpleinterest;
        }

        public void display()
        {
            Console.WriteLine("customer id:" + c.cid);
            Console.WriteLine("customer name:" + c.name);
            Console.WriteLine("customer address:" + c.address);
            Console.WriteLine("account number:" + accno);
            Console.WriteLine("account balance:" +balance);

        }
        
    }

    class FixedAccount:BankAccount
    {
        public override double interestamount(double p,int t,double r)
        {
            double s1 = (p * t * r) / 100;
            Console.WriteLine("simpleinterest +3% additional:")
                return s1;
        }
    }

    

    class BankProgram
    {
        static void main(string[] args)
        {
            Customer c2 = new Customer();
            c2.get(5, "supraja", "sklm");
            BankAccount b = new BankAccount;
            b.bankDetail(2345, 4000, b2);
            b.display();
            Console.WriteLine(b.interestamount(1000, 2, 3));
            FixedAccount f = new FixedAccount();
            Console.WriteLine(f.interestamount(1000, 2, 3.03));
            Console.ReadKey();
        }
    }

}
