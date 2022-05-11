using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker_opgave
{
    public class DebitCard : BankCard
    {
        private Random cardNumberRandom = new Random();

        public DebitCard(string accountName, int accountNumber, long cardNumber) : base(accountName, accountNumber, cardNumber)
        {
        }

        public override void GeneratePrefix()
        {
            Prefix = "2400";
        }

        public override void GenerateCardNumber()
        {
            for (int i = 0; i < 12; i++)
            {
                string ranNumber = Convert.ToString(cardNumberRandom.Next(0, 10));

                CardNumberToConvert += ranNumber.ToString();

            }
            cardNumber = Convert.ToInt64(Prefix + CardNumberToConvert);
        }
    }
}
