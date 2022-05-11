using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker_opgave
{
    public class Visa_Dankort : BankCard
    {
        private Random cardNumberRandom = new Random();
        private int monthlyLimit;

        public Visa_Dankort(string accountName, int accountNumber, long cardNumber) : base(accountName, accountNumber, cardNumber)
        {
        }

        public int MonthlyLimit
        {
            get { return monthlyLimit; }
            set { monthlyLimit = value; }
        }

        public override void GeneratePrefix()
        {
            Prefix = "4";
        }

        public override void GenerateCardNumber()
        {
            for (int i = 0; i < 15; i++)
            {
                string ranNumber = Convert.ToString(cardNumberRandom.Next(0, 10));

                CardNumberToConvert += ranNumber.ToString();

            }
            cardNumber = Convert.ToInt64(Prefix + CardNumberToConvert);
        }
    }
}
