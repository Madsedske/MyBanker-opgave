using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker_opgave
{
    public class Maestro : BankCard
    {
        private Random cardNumberRandom = new Random();
        private Random prefixPick = new Random();

        public Maestro(string accountName, int accountNumber, long cardNumber) : base(accountName, accountNumber, cardNumber)
        {
            
        }

        public override void GeneratePrefix()
        {
            int whichPrefix = prefixPick.Next(1, 10);

            switch (whichPrefix)
            {
                case 1:
                    Prefix = "5018";
                    break;
                case 2:
                    Prefix = "5020";
                    break;
                case 3:
                    Prefix = "5020";
                    break;
                case 4:
                    Prefix = "5893";
                    break;
                case 5:
                    Prefix = "6304";
                    break;
                case 6:
                    Prefix = "6759";
                    break;
                case 7:
                    Prefix = "6761";
                    break;
                case 8:
                    Prefix = "6762";
                    break;
                case 9:
                    Prefix = "6763";
                    break;
                default:
                    break;
            }
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
