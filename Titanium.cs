using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethod
{
     // Titanium Product provides implementations of the CreditCard interface methods.
    public class Titanium : CreditCard
    {
         public string GetCardType()
        {
            return "Titanium Edge";
        }

        public int GetCreditLimit()
        {
            return 25000;
        }

         public int GetAnnualCharge()
        {
            return 1500;
        }

    }
}