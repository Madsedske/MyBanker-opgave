using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker_opgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankCard maestro = new Maestro("Mads", 5324, 86);
            BankCard mastercard = new Mastercard("Simon", 532, 532);
            BankCard visaElectron = new Visa_Electron("Jørgen", 3, 34);
            BankCard visaDankort = new Visa_Dankort("Thyge", 43, 34);
            BankCard debitCard = new DebitCard("Karl", 432, 52);


            // Test om kort generator virker.
            mastercard.GeneratePrefix();
            mastercard.GenerateCardNumber();
            Console.Write(mastercard.CardNumber);
            Console.WriteLine();
            maestro.GeneratePrefix();
            maestro.GenerateCardNumber();
            Console.Write(maestro.CardNumber);
            Console.WriteLine();
            visaDankort.GeneratePrefix();
            visaDankort.GenerateCardNumber();
            Console.Write(visaDankort.CardNumber);
            Console.WriteLine();
            visaElectron.GeneratePrefix();
            visaElectron.GenerateCardNumber();
            Console.Write(visaElectron.CardNumber);
            Console.WriteLine();
            debitCard.GeneratePrefix();
            debitCard.GenerateCardNumber();
            Console.Write(debitCard.CardNumber);
            // Test om kort generator virker.



            //List<BankCard> list = new List<BankCard>() { maestro, mastercard, visaElectron, visaDankort, debitCard };

            //foreach (BankCard n in list)
            //{
            //    Console.WriteLine(n.AccountName);
            //    Console.WriteLine(n.AccountNumber);
            //    Console.WriteLine(n.AccountBalance);
            //    Console.WriteLine(n.IsWorkingInternational);
            //    Console.WriteLine(n.CardNumber);
            //}

            Console.ReadKey();
        }
    }
}
