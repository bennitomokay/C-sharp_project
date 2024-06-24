using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BankManagementSystem
{
    class FileHandler
    {
        private string fileName = "client";

        public void AddClient(string accountNumber, string firstName, string lastName, int age, double balance = 0)
        {
            string line = accountNumber + ',' + firstName + ',' + lastName + ',' + age + ',' + balance;
            StreamWriter sw = new StreamWriter(fileName,true);

            try
            {
                if (File.Exists(fileName))
                {

                    sw.WriteLine(line);
                }
                else
                {
                    throw new CustomException("file does not exist");
                }

            }
            catch (CustomException ce)
            {

                MessageBox.Show(ce.Message);

            }
            finally
            {
                sw.Close();
            }

        }

        public List<Client> GetClient()
        {
            List<Client>  c = new List<Client>();

            StreamReader sr = new StreamReader(fileName);
            try
            {
                if (File.Exists(fileName))
                {
                    string line = sr.ReadLine();

                    while (line != null)
                    {
                        string[] rowData = line.Split(',');
                        c.Add(new Client(rowData[0], rowData[1], rowData[2],int.Parse(rowData[3]), double.Parse(rowData[4])));

                    }

                }
                else
                {
                    throw new CustomException("file does not exist");
                }

            }
            catch (CustomException ce)
            {

                MessageBox.Show(ce.Message);
            }



            return c;

        }
    }
}
