using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker_opgave
{
    public class Visa_Electron : BankCard
    {
        private Random cardNumberRandom = new Random();
        private Random prefixPick = new Random();

        public Visa_Electron(string accountName, int accountNumber, long cardNumber) : base(accountName, accountNumber, cardNumber)
        {
        }

        public override void GeneratePrefix()
        {
            int whichPrefix = prefixPick.Next(1, 7);

            switch (whichPrefix)
            {
                case 1:
                    Prefix = "4026";
                    break;
                case 2:
                    Prefix = "417500";
                    break;
                case 3:
                    Prefix = "4508";
                    break;
                case 4:
                    Prefix = "4844";
                    break;
                case 5:
                    Prefix = "4913";
                    break;
                case 6:
                    Prefix = "4917";
                    break;
                default:
                    break;
            }
        }

        public override void GenerateCardNumber()
        {
            if (Prefix == "417500")
            {
                for (int i = 0; i < 10; i++)
                {
                    string ranNumber = Convert.ToString(cardNumberRandom.Next(0, 10));
                    CardNumberToConvert += ranNumber.ToString();
                }
                cardNumber = Convert.ToInt64(Prefix + CardNumberToConvert);
            }
            else
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
}
