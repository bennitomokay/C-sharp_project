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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileHandler fh = new FileHandler();

            if (txtAddFirstName.Text == null || txtAddLastName == null || txtAddAge == null || txtxAddAccountNumber == null)
            {
                MessageBox.Show("please fill in all the boxes");
            }
            else
            {
                fh.AddClient(txtxAddAccountNumber.Text, txtAddFirstName.Text, txtAddLastName.Text, int.Parse(txtAddAge.Text));
                MessageBox.Show("Successfully Added");
            }


        }
    }
}
