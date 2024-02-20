using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Proiect
{
    public partial class LibrarianInterface : Form
    {       
        public LibrarianInterface()
        {
            InitializeComponent();
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            String title = titleTextField.Text;
            String author = authorTextField.Text;
            int id = getIdBook();
            try
            {
            int quantity = Convert.ToInt16(nrOfBooksTextField.Text);
            Book book = new Book(id, title, author, quantity);
            if (validForBook(book))
            {
                    addBooks(book);
            }
            }
            catch
            {
                MessageBox.Show("Please introduce a number for quantity!");
            }
        }

        private void addBooks(Book book)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string Connection = @"Data Source = (LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=" + projectDirectory + @"\Database1.mdf;" +
                                        "Integrated Security = True";
            SqlConnection DataConnection = new SqlConnection(Connection);
            DataConnection.Open();

            string query = "INSERT INTO Books ([Id], [title], [author], [quantity]) ";
            query += "VALUES (@Id, @title,@author, @quantity) ";

            SqlCommand myCommand = new SqlCommand(query, DataConnection);
            myCommand.Parameters.AddWithValue("@Id", book.id);
            myCommand.Parameters.AddWithValue("@title", book.title);
            myCommand.Parameters.AddWithValue("@author", book.authorName);
            myCommand.Parameters.AddWithValue("@quantity", book.quantity);

            try
            {
                myCommand.ExecuteNonQuery();
                MessageBox.Show("The Id of the book is: " + book.id.ToString());
                MessageBox.Show("Book successfuly added!");
            }
            catch (Exception)
            {
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Error!");
            }
            DataConnection.Close();
        }


        private int getIdBook()
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
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Books", DataConnection);
            adapter.Fill(dataSet, "Books");
            foreach (DataRow dataRow in dataSet.Tables["Books"].Rows)
            {
                id = Convert.ToInt32(dataRow.ItemArray.GetValue(0));
            }
            DataConnection.Close();
            return id + 1;
        }

        private bool validForBook(Book book)
        {

            if (book.title.Length == 0)
            {
                MessageBox.Show("Please introduce book title!");
                return false;
            }

            if (book.authorName.Length == 0)
            {
                MessageBox.Show("Please introduce book author!");
                return false;
            }

            if (book.quantity == 0)
            {
                MessageBox.Show("Please introduce number of books!");
                return false;
            }

            foreach (char b in book.title)
            {
                if (!char.IsLetter(b))
                {
                    MessageBox.Show("Invalid title!");
                    return false;
                }

            }
            foreach (char b in book.title)
            {
                if (!char.IsLetter(b))
                {
                    MessageBox.Show("Invalid last name!");
                    return false;
                }
            }         
            return true;

        }

        private void deleteBook_Click(object sender, EventArgs e)
        {         
            String BookSelected = null;
            try
            {
                BookSelected = idTextField.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Choose an id!");
            }

            if(VerifyIdBook(BookSelected) && VerifyPresenceOfId(BookSelected))
            {
            DeleteBooks(BookSelected);
            }      
        }

        private bool VerifyIdBook(String bookSelected)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string Connection = @"Data Source = (LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=" + projectDirectory + @"\Database1.mdf;" +
                                        "Integrated Security = True";
            SqlConnection DataConnection = new SqlConnection(Connection);
            DataConnection.Open();

            int idBook = 0;
            DataSet dataSet;
            dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Loans", DataConnection);
            adapter.Fill(dataSet, "Loans");
            foreach (DataRow dataRow in dataSet.Tables["Loans"].Rows)
            {
                try
                {
                idBook = Convert.ToInt32(dataRow.ItemArray.GetValue(1));
                if (Convert.ToInt32(bookSelected) == idBook)
                {
                    MessageBox.Show("The book is on loan, it cannot be deleted!");
                    bookSelected = null;
                    return false;
                }
                } 
                catch
                {
                    MessageBox.Show("Choose an Id!");
                    return false;
                }              
            }
            DataConnection.Close();
            return true;
        }

        private bool VerifyPresenceOfId(String bookSelected)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string Connection = @"Data Source = (LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=" + projectDirectory + @"\Database1.mdf;" +
                                        "Integrated Security = True";
            SqlConnection DataConnection = new SqlConnection(Connection);
            DataConnection.Open();

            int idBook = 0;
            bool valid = false;
            DataSet dataSet;
            dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Books", DataConnection);
            adapter.Fill(dataSet, "Books");
            foreach (DataRow dataRow in dataSet.Tables["Books"].Rows)
            {
                try
                {
                    idBook = Convert.ToInt32(dataRow.ItemArray.GetValue(0));
                    if (Convert.ToInt32(bookSelected) == idBook)
                    {
                        valid = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Choose an Id!");
                    break;
                }
            }

            DataConnection.Close();
            if (valid)
                return true;
            else
            {
                MessageBox.Show("The Id isn't present in database!");
                return false; 
            }
                
        }

        private void DeleteBooks(String BookSelected)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string Connection = @"Data Source = (LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=" + projectDirectory + @"\Database1.mdf;" +
                                        "Integrated Security = True";
            SqlConnection DataConnection = new SqlConnection(Connection);
            DataConnection.Open();

            SqlCommand command = new SqlCommand("DELETE FROM Books WHERE [Id] LIKE @Id", DataConnection);

            if (BookSelected != null)
            {
                // Add the parameters for the DeleteCommand.
                SqlParameter parameter = command.Parameters.AddWithValue("@Id", BookSelected);
                parameter.SourceVersion = DataRowVersion.Original;

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("The book is deleted!");
                }
                catch (Exception)
                {
                    MessageBox.Show("The book is on loan, it cannot be deleted!\n");
                }
            }
            else
            {
                MessageBox.Show("Choose an id!");
            }
        }

        private void viewClients_Click(object sender, EventArgs e)
        {
            List<Client> clients = new List<Client>();
            clients = getClients();
            showClients(clients);
        }
        private List<Client> getClients()
        {
            List<Client> clients = new List<Client>();
            DataSet dataSet;
            string Connection = @"Data Source = (LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=|DataDirectory|Database1.mdf;
                                        Integrated Security = True";
            SqlConnection DataConnection = new SqlConnection(Connection);
            DataConnection.Open();
            dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Clients", DataConnection);
            adapter.Fill(dataSet, "Clients");
            foreach (DataRow dataRow in dataSet.Tables["Clients"].Rows)
            {
                int id = Convert.ToInt32(dataRow.ItemArray.GetValue(0));
                String firstName = dataRow.ItemArray.GetValue(1).ToString().Trim();
                String lastName = dataRow.ItemArray.GetValue(2).ToString().Trim();
                String email = dataRow.ItemArray.GetValue(3).ToString().Trim();
                String phoneNumber = dataRow.ItemArray.GetValue(4).ToString().Trim();
                Client client = new Client(id, firstName, lastName, email, phoneNumber);
                clients.Add(client);

            }
            return clients;
        }

        private void showClients(List<Client> clients)
        {
            foreach (Client client in clients)
            {
                listBox_clients.Items.Add(client.id + "   " + client.firstName + "  " + client.lastName + 
                     "          " + client.email + "            " + client.phoneNumber);
            }
        }

        private void showLoans(List<Loan> loans)
        {
            foreach (Loan loan in loans)
            {
                listBox_loans.Items.Add(loan.id + "              " + loan.idClient + "                                       " + loan.idBook +
                     "                                         " + loan.returned);
            }
        }

        private List<Loan> getLoans()
        {
            List<Loan> loans = new List<Loan>();
            DataSet dataSet;
            string Connection = @"Data Source = (LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=|DataDirectory|Database1.mdf;
                                        Integrated Security = True";
            SqlConnection DataConnection = new SqlConnection(Connection);
            DataConnection.Open();
            dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Loans", DataConnection);
            adapter.Fill(dataSet, "Loans");
            foreach (DataRow dataRow in dataSet.Tables["Loans"].Rows)
            {
                int id = Convert.ToInt32(dataRow.ItemArray.GetValue(0));
                int idClient = Convert.ToInt32(dataRow.ItemArray.GetValue(1));
                int idBook = Convert.ToInt32(dataRow.ItemArray.GetValue(2));
                bool returned = Convert.ToBoolean(dataRow.ItemArray.GetValue(3));
                Loan loan = new Loan(id, idClient, idBook, returned);
                loans.Add(loan);

            }
            return loans;
        }

        private void viewBorrowedBooks_Click(object sender, EventArgs e)
        {
            List<Loan> loans = new List<Loan>();
            loans = getLoans();
            showLoans(loans);
        }

        private void titleMouseClick(object sender, MouseEventArgs e)
        {
            titleTextField.Clear();
        }

        private void authorMouseClick(object sender, MouseEventArgs e)
        {
            authorTextField.Clear();
        }

        private void quantityMouseClick(object sender, MouseEventArgs e)
        {
            nrOfBooksTextField.Clear();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditBook editBook = new EditBook();
            editBook.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditBook editBook = new EditBook();
            editBook.Show();
        }

        private void titleTextField_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Client> clients = new List<Client>();
            clients = getClients();
            listBox_clients.Items.Clear();
            clients.Sort(delegate (Client client1, Client client2)
            {
                return client1.firstName.CompareTo(client2.firstName);
            });
            showClients(clients);
        }

        private void idToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Client> clients = new List<Client>();
            clients = getClients();
            listBox_clients.Items.Clear();
            showClients(clients);
        }

        private void lastNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Client> clients = new List<Client>();
            clients = getClients();
            listBox_clients.Items.Clear();
            clients.Sort(delegate (Client client1, Client client2)
            {
                return client1.lastName.CompareTo(client2.lastName);
            });
            showClients(clients);
        }

        private void idToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<Loan> loans = new List<Loan>();
            loans = getLoans();
            listBox_loans.Items.Clear();
            showLoans(loans);
        }

        private void idBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Loan> loans = new List<Loan>();
            loans = getLoans();
            listBox_loans.Items.Clear();
            loans.Sort(delegate (Loan loan1, Loan loan2)
            {
                return loan1.idBook.CompareTo(loan2.idBook);
            });
            showLoans(loans);
        }

        private void idClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Loan> loans = new List<Loan>();
            loans = getLoans();
            listBox_loans.Items.Clear();
            loans.Sort(delegate (Loan loan1, Loan loan2)
            {
                return loan1.idClient.CompareTo(loan2.idClient);
            });
            showLoans(loans);
        }
    }
}
