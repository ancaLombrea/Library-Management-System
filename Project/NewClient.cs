using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Proiect
{
    public partial class NewClient : Form
    {
        public NewClient()
        {
            InitializeComponent();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            string firstName, lastName, email, phoneNumber;
            firstName = textBoxFirstName.Text;
            lastName = textBoxLastName.Text;
            email = textBoxEmail.Text;
            phoneNumber = textBoxPhoneNumber.Text;
            int id = getIdClient();
            Client client = new Client(id, firstName, lastName, email, phoneNumber);
            checkBoxAgreed.ForeColor = Color.Black;



            if (validForNewClient(client))
            {
                if (checkBoxAgreed.Checked)
                {
                    addClient(client);
                    textBoxFirstName.Clear();
                    textBoxLastName.Clear();
                    textBoxEmail.Clear();
                    textBoxPhoneNumber.Clear();
                }
                else
                {
                    checkBoxAgreed.ForeColor = Color.Red;
                }

            }
        }

        private int getIdClient()
        {
            int id = 0;
            DataSet dataSet;
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string Connection = @"Data Source = (LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=" + projectDirectory + @"\Database1.mdf;" +
                                        "Integrated Security = True";

            SqlConnection DataConnection = new SqlConnection(Connection);
            DataConnection.Open();
            dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Clients", DataConnection);
            adapter.Fill(dataSet, "Clients");
            foreach (DataRow dataRow in dataSet.Tables["Clients"].Rows)
            {
                id = Convert.ToInt32(dataRow.ItemArray.GetValue(0));
            }
            DataConnection.Close();

            return id + 1;
        }

        private bool existentClient(Client client)
        {
            DataSet dataSet;
            String email;
            String phoneNumber;
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string Connection = @"Data Source = (LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=" + projectDirectory + @"\Database1.mdf;" +
                                        "Integrated Security = True";

            SqlConnection DataConnection = new SqlConnection(Connection);
            DataConnection.Open();
            dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Clients", DataConnection);
            adapter.Fill(dataSet, "Clients");
            foreach (DataRow dataRow in dataSet.Tables["Clients"].Rows)
            {
                phoneNumber = dataRow.ItemArray.GetValue(4).ToString();
                email = dataRow.ItemArray.GetValue(3).ToString();
                if (email.Trim() == client.email) return true;
                if (phoneNumber.Trim() == client.phoneNumber) return true;
            }
            DataConnection.Close();
            return false;
        }

        private bool validForNewClient(Client client)
        {
            //Conditii validare firstName
            if (client.firstName.Length == 0)
            {
                textBoxFirstName.ForeColor = Color.Red;
                MessageBox.Show("Please introduce first name!");

                return false;
            }

            foreach (char c in client.firstName)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("Invalid first name!");
                    textBoxFirstName.ForeColor = Color.Red;
                    return false;
                }

            }

            //Conditii validare lastName

            if (client.lastName.Length == 0)
            {
                MessageBox.Show("Please introduce last name!");
                textBoxLastName.ForeColor = Color.Red;
                return false;
            }

            foreach (char c in client.lastName)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("Invalid last name!");
                    textBoxLastName.ForeColor = Color.Red;
                    return false;
                }
            }

            //Conditii validare email

            if (client.email.Length == 0)
            {
                MessageBox.Show("Please introduce email adress!");
                textBoxEmail.ForeColor = Color.Red;
                return false;
            }

            if (client.email.Length <= 10 || client.email.Substring(client.email.Length - 10) != "@gmail.com" &&
                client.email.Substring(client.email.Length - 10) != "@yahoo.com")
            {
                MessageBox.Show("Invalid email!");
                textBoxEmail.ForeColor = Color.Red;
                return false;
            }

            //Conditii validare phoneNumber

            if (client.phoneNumber.Length == 0)
            {
                MessageBox.Show("Please introduce phone number !");
                textBoxPhoneNumber.ForeColor = Color.Red;
                return false;
            }

            if (client.phoneNumber.Length != 10)
            {
                MessageBox.Show("Invalid phone number !");
                textBoxPhoneNumber.ForeColor = Color.Red;
                return false;
            }

            foreach (char c in client.phoneNumber)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Invalid phone number!");
                    textBoxPhoneNumber.ForeColor = Color.Red;
                    return false;
                }
            }

            if (existentClient(client) == true)
            {
                MessageBox.Show("This email or phone number is already used for another account.");
                return false;
            }
            return true;

        }

        private void addClient(Client client)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string Connection = @"Data Source = (LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=" + projectDirectory + @"\Database1.mdf;" +
                                        "Integrated Security = True";

            SqlConnection DataConnection = new SqlConnection(Connection);
            DataConnection.Open();
            string query = "INSERT INTO Clients ([Id], [firstName], [lastName], [email],[phoneNumber]) ";
            query += "VALUES (@Id, @firstName,@lastName, @email, @phoneNumber) ";

            SqlCommand myCommand = new SqlCommand(query, DataConnection);
            myCommand.Parameters.AddWithValue("@Id", client.id);
            myCommand.Parameters.AddWithValue("@firstName", client.firstName);
            myCommand.Parameters.AddWithValue("@lastName", client.lastName);
            myCommand.Parameters.AddWithValue("@email", client.email);
            myCommand.Parameters.AddWithValue("@phoneNumber", client.phoneNumber);

            try
            {
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Client successfuly added!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            DataConnection.Close();

        }

        private void firstNameMouseClick(object sender, MouseEventArgs e)
        {
            textBoxFirstName.Clear();
            textBoxFirstName.ForeColor = Color.Black;
        }

        private void lastNameMouseClick(object sender, MouseEventArgs e)
        {
            textBoxLastName.Clear();
            textBoxLastName.ForeColor = Color.Black;
        }

        private void emailMouseClick(object sender, MouseEventArgs e)
        {
            textBoxEmail.Clear();
            textBoxEmail.ForeColor = Color.Black;
        }

        private void phoneNumberMouseClick(object sender, MouseEventArgs e)
        {
            textBoxPhoneNumber.Clear();
            textBoxPhoneNumber.ForeColor = Color.Black;
        }
    }
}

