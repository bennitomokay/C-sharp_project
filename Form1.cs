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
    public partial class Form1 : Form
    {
        List<Client> cl = new List<Client>();
        FileHandler fh = new FileHandler();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cl = fh.GetClient();
            btnMakeDeposit.Hide();
            btnAddClient.Hide();
            dgvClinets.DataSource = cl;
            lstNames.DataSource = cl;
            lstNames.DisplayMember = "FirstName" + " " + "LastName";

            txtAccountNumber.DataBindings.Add("text", cl, "AccountNumber");
            txtFirstName.DataBindings.Add("Text",cl,"FirstName");
            txtLastName.DataBindings.Add("Text", cl, "LastName");
            txtAge.DataBindings.Add("Text",cl,"Age");
            txtBalance.DataBindings.Add("Text",cl,"Balance");

        }

        private void btnClientSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchAClient ss = new SearchAClient();
            ss.Show();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddClient add = new AddClient();
            add.Show();
        }
    }
}
