using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
  partial  class Bank
    {
        public void checkBalance()
        {
            Console.WriteLine("checking Balance");
        }
    }
  partial class Bank
    {
       public void withdraw()
        {
            Console.WriteLine("withdrawing money");
        }
    }

   partial class Bank
    {
        public void crediting()
        {
            Console.WriteLine("moneycrediting in your account");
        }
    }


    class PartialClassPro
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.checkBalance();
            b.crediting();
            b.withdraw();
        }
    }
}
