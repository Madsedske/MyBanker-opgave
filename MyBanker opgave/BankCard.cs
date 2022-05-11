using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker_opgave
{
    public abstract class BankCard
    {
        private Random r = new Random();


        public BankCard(string accountName, int accountNumber, long cardNumber)
        {
            accountName = AccountName;
            accountNumber = AccountNumber;
            cardNumber = CardNumber;
        }

        protected string accountName;

        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }
        private string prefix;

        public string Prefix
        {
            get { return prefix; }
            set { prefix = value; }
        }

        private string cardNumberToConvert;

        public string CardNumberToConvert
        {
            get { return cardNumberToConvert; }
            set { cardNumberToConvert = value; }
        }
        protected long cardNumber;

        public  long CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }

        protected int accountNumber;

        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        protected double accountBalance;

        public double AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }

        protected bool isWorkingInternational;

        public bool IsWorkingInternational
        {
            get { return isWorkingInternational; }
            set { isWorkingInternational = value; }
        }

        public virtual void GeneratePrefix()
        {
          
        }

        public virtual void GenerateCardNumber()
        {
            //for (int i = 0; i < 12; i++)
            //{
            //    cardNumber = r.Next(0,10);
            //}
        }
    }
}
