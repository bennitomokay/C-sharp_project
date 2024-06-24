using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class Deposit : Form
    {

        FileHandler fh = new FileHandler();
        List<Client> cl;

        public Deposit()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            cl = fh.GetClient();
            foreach (Client item in cl)
            {
                if (txtToAccount.Text == item.AccountNumber)
                {
                    item.Balance = item.Balance + double.Parse(txtAmount.Text);

                }
                else
                {
                    MessageBox.Show("enter a valid account number");
                }
            }

        }

        private void Deposit_Load(object sender, EventArgs e)
        {

        }
    }
}
