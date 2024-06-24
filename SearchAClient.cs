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
    public partial class SearchAClient : Form
    {
        List<Client> cl = new List<Client>();
        FileHandler fh = new FileHandler();

        public SearchAClient()
        {
            InitializeComponent();
        }

        private void SearchAClient_Load(object sender, EventArgs e)
        {
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtAge.Enabled = false;
            txtAccountBalance.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cl = fh.GetClient();

            foreach (Client item in cl)
            {
                if (txtAccountNumber.Text != null)
                {
                    if (txtAccountNumber.Text == item.AccountNumber)
                    {
                        txtFirstName.Text = item.FirstName;
                        txtLastName.Text = item.LastName;
                        txtAge.Text = item.Age.ToString();
                        txtAccountBalance.Text = item.Balance.ToString();
                    }
                    else
                    {
                        MessageBox.Show("enter a valid account number");
                    }
                }
                else
                {
                    MessageBox.Show("enter a valid account number");
                }
            }
        }
    }
}
