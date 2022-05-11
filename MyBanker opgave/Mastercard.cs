using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker_opgave
{
    public class Mastercard : BankCard
    {
        private Random cardNumberRandom = new Random();
        private Random prefixPick = new Random();

        private int dailyLimit;

        public int DailyLimit
        {
            get { return dailyLimit; }
            set { dailyLimit = value; }
        }

        private int monthlyLimit;

        public int MonthlyLimit
        {
            get { return monthlyLimit; }
            set { monthlyLimit = value; }
        }

        private int currentMonthlyLoan;

        public Mastercard(string accountName, int accountNumber, long cardNumber) : base(accountName, accountNumber, cardNumber)
        {
        }

        public int CurrentMonthlyLoan
        {
            get { return currentMonthlyLoan; }
            set { currentMonthlyLoan = value; }
        }

        public override void GeneratePrefix()
        {
            int whichPrefix = prefixPick.Next(1, 6);           

            switch (whichPrefix)
            {
                case 1:
                    Prefix = "51";
                    break;
                case 2:
                    Prefix = "52";
                    break;
                case 3:
                    Prefix = "53";
                    break;
                case 4:
                    Prefix = "54";
                    break;
                case 5:
                    Prefix = "55";
                    break;
                default:
                    break;
            }
        }

        public override void GenerateCardNumber()
        {
            for (int i = 0; i < 14; i++)
            {
                string ranNumber = Convert.ToString(cardNumberRandom.Next(0, 10));

                CardNumberToConvert += ranNumber.ToString();

            }
            cardNumber = Convert.ToInt64(Prefix + CardNumberToConvert);
        }
    }
}
