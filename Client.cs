using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem
{
    class Client
    {

        private string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        private string firsName;

        public string FirstName
        {
            get { return firsName; }
            set { firsName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Client(string accountNumber, string firstName, string lastName, int age, double balance = 0)
        {
            this.accountNumber = accountNumber;
            this.firsName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.balance = balance;


        }


        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}", accountNumber, firsName, lastName, age, balance);
        }






    }
}
