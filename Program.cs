﻿namespace FactoryMethod;

class Program
{
    static void Main(string[] args)
    {
        // The client code works with an instance of a concrete creator
        // The CreateProduct will return the actual product instance via the product interface
        // PlatinumFactory CreateProduct method will return an instance of Platinum Product via the CreditCard interface
        CreditCard creditCard = new PlatinumFactory().CreateProduct();
        if(creditCard != null){
             Console.WriteLine("Card Type : " + creditCard.GetCardType());
             Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
             Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
        } else {
             Console.WriteLine("Invalid Card");
        }
    }
}
