using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethod
{
    // Platinum Product provides implementations of the CreditCard interface methods.
    public class Platinum : CreditCard
    {
        
        public string GetCardType()
        {
            return "Platinum Plus";
        }

        public int GetCreditLimit()
        {
            return 50000;
        }
        
        public int GetAnnualCharge()
        {
            return 2000;
        }
    }
}