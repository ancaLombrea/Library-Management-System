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
    public partial class ClientInterface : Form
    {
        public ClientInterface()
        {
            InitializeComponent();
            List<Book> books = new List<Book>();
            books = getBooks();
            showBooks(books);
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            NewClient newClient = new NewClient();
            newClient.Show();
        }

        private void showBooks(List<Book> books)
        {
            foreach (Book book in books)
            {
                listBoxBooks.Items.Add(book.id + "     " + book.title + "                                           " + book.authorName + "                       " + book.quantity);
            }
        }

        private void refresh()
        {
            listBoxBooks.Items.Clear();
            List<Book> books = new List<Book>();
            books = getBooks();
            showBooks(books);
        }

        private List<Book> getBooks()
        {
            List<Book> books = new List<Book>();
            DataSet dataSetBooks;
            string Connection = @"Data Source = (LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=|DataDirectory|Database1.mdf;
                                        Integrated Security = True";
            SqlConnection DataConnection = new SqlConnection(Connection);
            DataConnection.Open();
            dataSetBooks = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Books", DataConnection);
            adapter.Fill(dataSetBooks, "Books");
            foreach (DataRow dataRow in dataSetBooks.Tables["Books"].Rows)
            {
                int id = Convert.ToInt32(dataRow.ItemArray.GetValue(0));
                String title = dataRow.ItemArray.GetValue(1).ToString().Trim();
                String author = dataRow.ItemArray.GetValue(2).ToString().Trim();
                int quantity = Convert.ToInt32(dataRow.ItemArray.GetValue(3));
                Book book = new Book(id, title, author, quantity);
                books.Add(book);

            }
            return books;
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
                String email = dataRow.ItemArray.GetValue(1).ToString().Trim();
                String phoneNumber = dataRow.ItemArray.GetValue(2).ToString().Trim();
                Client client = new Client(id, firstName, lastName, email, phoneNumber);
                clients.Add(client);

            }
            return clients;
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

        //Metode folosite pentru imprumutul cartilor
        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>();
            books = getBooks();

            if (valideIdCB(textBoxIdClientBorrow.Text, textBoxIdBook.Text) == true)
            {
                int idClient = Convert.ToInt32(textBoxIdClientBorrow.Text);
                int idBook = Convert.ToInt32(textBoxIdBook.Text);
                if (checkClient(idClient) == true)
                {
                    if (checkBook(idBook) == true)
                    {
                        borrowBook(idClient, idBook);
                        int quantity = getBookQuantity(idBook) - 1;
                        updateBookQuantity(idBook, quantity);

                    }
                }
            }

            refresh();
        }

        private void borrowBook(int idClient, int idBook)
        {
            int id = getIdLoan();
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string Connection = @"Data Source = (LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=" + projectDirectory + @"\Database1.mdf;" +
                                        "Integrated Security = True";

            SqlConnection DataConnection = new SqlConnection(Connection);
            DataConnection.Open();
            string query = "INSERT INTO Loans ([Id], [IdClient],[IdBook],[Returned] ) ";
            query += "VALUES (@Id, @IdClient,@IdBook,@Returned) ";

            SqlCommand myCommand = new SqlCommand(query, DataConnection);
            myCommand.Parameters.AddWithValue("@Id", id);
            myCommand.Parameters.AddWithValue("@IdClient", idClient);
            myCommand.Parameters.AddWithValue("@IdBook", idBook);
            myCommand.Parameters.AddWithValue("@Returned", 0);

            try
            {
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Loan successfuly added!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            DataConnection.Close();
        }

        private int getBookQuantity(int idBook)
        {
            List<Book> books = new List<Book>();
            DataSet dataSetBooks;
            string Connection = @"Data Source = (LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=|DataDirectory|Database1.mdf;
                                        Integrated Security = True";
            SqlConnection DataConnection = new SqlConnection(Connection);
            DataConnection.Open();
            dataSetBooks = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Books", DataConnection);
            adapter.Fill(dataSetBooks, "Books");
            foreach (DataRow dataRow in dataSetBooks.Tables["Books"].Rows)
            {
                int id = Convert.ToInt32(dataRow.ItemArray.GetValue(0));
                int quantity = Convert.ToInt32(dataRow.ItemArray.GetValue(3));
                if (idBook == id) return quantity;
            }
            return 0;

        }

        private bool checkClient(int id)
        {
            List<Client> clients = new List<Client>();
            List<Loan> loans = new List<Loan>();
            loans = getLoans();
            clients = getClients();
            bool exist = false;
            int existingLoan = 0;
            foreach (Client client in clients)
            {
                if (id == client.id) exist = true;
            }
            foreach (Loan loan in loans)
            {
                if (id == loan.idClient && loan.returned == false) existingLoan = existingLoan + 1;
            }
            if (existingLoan > 5)
            {
                MessageBox.Show("You have already borrowed more 5 books. Please return some of them before borrowing again.");
                return false;
            }

            return exist;
        }

        private bool checkBook(int id)
        {
            List<Book> books = new List<Book>();
            books = getBooks();
            bool exist = false;
            int quantity = 0;
            foreach (Book book in books)
            {
                if (id == book.id)
                {
                    quantity = book.quantity;
                }
            }

            if (quantity > 0) exist = true;
            if (quantity <= 0) MessageBox.Show("Sorry, this book is not available at the moment.");
            return exist;
        }

        private void updateBookQuantity(int idBook, int quantity)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string Connection = @"Data Source = (LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=" + projectDirectory + @"\Database1.mdf;" +
                                        "Integrated Security = True";

            SqlConnection DataConnection = new SqlConnection(Connection);
            DataConnection.Open();
            string query = "UPDATE Books SET quantity = @quantity WHERE Id = @Id";

            SqlCommand myCommand = new SqlCommand(query, DataConnection);
            myCommand.Parameters.AddWithValue("@Id", idBook);
            myCommand.Parameters.AddWithValue("@quantity", quantity);

            try
            {
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Book quantity updated!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            DataConnection.Close();
        }

        private bool valideIdCB(String idClient, String idBook)
        {
            if (idClient.Length == 0)
            {
                MessageBox.Show("Empty Client ID!");
                return false;
            }
            foreach (char c in idClient)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Invalid Client ID!");
                    return false;
                }
            }
            if (idBook.Length == 0)
            {
                MessageBox.Show("Empty Book ID!");
                return false;
            }
            foreach (char c in idBook)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Invalid Book ID!");
                    return false;
                }
            }
            return true;
        }

        private int getIdLoan()
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
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Loans", DataConnection);
            adapter.Fill(dataSet, "Loans");
            foreach (DataRow dataRow in dataSet.Tables["Loans"].Rows)
            {
                id = Convert.ToInt32(dataRow.ItemArray.GetValue(0));
            }
            DataConnection.Close();

            return id + 1;
        }
  
        
        //Metode pentru meniu ordonare
        private void idToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>();
            books = getBooks();
            listBoxBooks.Items.Clear();
            showBooks(books);
        }

        private void titleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>();
            books = getBooks();
            listBoxBooks.Items.Clear();
            books.Sort(delegate (Book book1, Book book2)
            {
                return book1.title.CompareTo(book2.title);
            });
            showBooks(books);
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>();
            books = getBooks();
            listBoxBooks.Items.Clear();
            books.Sort(delegate (Book book1, Book book2)
            {
                return book1.quantity.CompareTo(book2.quantity);
            });
            showBooks(books);
        }

        private void quantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>();
            books = getBooks();
            listBoxBooks.Items.Clear();
            books.Sort(delegate (Book book1, Book book2)
            {
                return book1.authorName.CompareTo(book2.authorName);
            });
            showBooks(books);
        }


        //Metoda pentru gasire id client
        private void buttonFindIdClient_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Length == 0)
            {
                MessageBox.Show("Please introduce an email!");
            }
            else
            {
                bool found = false;
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
                    if (dataRow.ItemArray.GetValue(3).ToString().Trim() == textBoxEmail.Text)
                    {
                        MessageBox.Show("Your ID: " + dataRow.ItemArray.GetValue(0).ToString());
                        found = true;
                    }
                }
                if (!found) MessageBox.Show("Sorry! We could not find you account!");
                DataConnection.Close();
            }
        }


        //Metoda pentru gasire id imprumut
        private void buttonFindLoan_Click(object sender, EventArgs e)
        {
            if (textBoxClientFindLoan.Text.Length == 0 || textBoxBookFindLoan.Text.Length == 0)
            {
                MessageBox.Show("Please introduce your Client ID and the book name.");
            }
            else
            {
                DataSet dataSet;
                int idClient = 0, idBook = 0;
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
                    if (Convert.ToInt32(dataRow.ItemArray.GetValue(0)) == Convert.ToInt32(textBoxClientFindLoan.Text))
                    {
                        idClient = Convert.ToInt32(dataRow.ItemArray.GetValue(0));
                    }

                }

                DataSet dataSetBooks = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Books", DataConnection);
                sqlDataAdapter.Fill(dataSetBooks, "Books");
                foreach (DataRow dataRow in dataSetBooks.Tables["Books"].Rows)
                {
                    if (dataRow.ItemArray.GetValue(1).ToString().Trim() == textBoxBookFindLoan.Text)
                    {
                        idBook = Convert.ToInt32(dataRow.ItemArray.GetValue(0));
                    }
                }

                if (idClient == 0 || idBook == 0)
                {
                    MessageBox.Show("We could not find any loan for this book.");
                }
                else
                {
                    SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Loans", DataConnection);
                    adapt.Fill(dataSet, "Loans");
                    foreach (DataRow dataRow in dataSet.Tables["Loans"].Rows)
                    {
                        bool returned = Convert.ToBoolean(dataRow.ItemArray.GetValue(3));
                        if (idClient == Convert.ToInt32(dataRow.ItemArray.GetValue(1)) &&
                             idBook == Convert.ToInt32(dataRow.ItemArray.GetValue(2)))
                        {
                            MessageBox.Show("Loan ID : " + Convert.ToInt32(dataRow.ItemArray.GetValue(0)));
                        }

                    }
                }
                DataConnection.Close();
            }
        }


        //Metode folosite pentru returnare carti
        private bool checkLoan(int idClient, int idLoan)
        {
            DataSet dataSet;
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string Connection = @"Data Source = (LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=" + projectDirectory + @"\Database1.mdf;" +
                                        "Integrated Security = True";

            SqlConnection DataConnection = new SqlConnection(Connection);
            DataConnection.Open();
            dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Loans", DataConnection);
            adapter.Fill(dataSet, "Loans");
            foreach (DataRow dataRow in dataSet.Tables["Loans"].Rows)
            {
                if (idClient == Convert.ToInt32(dataRow.ItemArray.GetValue(1)) &&
                    idLoan == Convert.ToInt32(dataRow.ItemArray.GetValue(0)))
                {
                    MessageBox.Show("Loan found");
                    return true;
                }
            }
            DataConnection.Close();
            return false;
        }

        private void returnBook(int idClient, int idLoan)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string Connection = @"Data Source = (LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=" + projectDirectory + @"\Database1.mdf;" +
                                        "Integrated Security = True";

            SqlConnection DataConnection = new SqlConnection(Connection);
            DataConnection.Open();
            string query = "UPDATE Loans SET Returned = @Returned WHERE IdClient = @IdClient AND Id=@Id";

            SqlCommand myCommand = new SqlCommand(query, DataConnection);
            myCommand.Parameters.AddWithValue("@Id", idLoan);
            myCommand.Parameters.AddWithValue("@IdClient", idClient);
            myCommand.Parameters.AddWithValue("@Returned", 1);

            try
            {
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Book returned successfuly!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            DataConnection.Close();
        }

        private bool valideIdCL(String idClient, String idLoan)
        {
            if (idClient.Length == 0)
            {
                MessageBox.Show("Empty Client ID!");
                return false;
            }

            foreach (char c in idClient)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Invalid Client ID!");
                    return false;
                }
            }
            if (idLoan.Length == 0)
            {
                MessageBox.Show("Empty Loan ID!");
                return false;
            }

            foreach (char c in idLoan)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Invalid Loan ID!");
                    return false;
                }
            }
            return true;
        }

        private int getBookIdFromLoan(int idClient, int idLoan)
        {
            DataSet dataSet;
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string Connection = @"Data Source = (LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=" + projectDirectory + @"\Database1.mdf;" +
                                        "Integrated Security = True";

            SqlConnection DataConnection = new SqlConnection(Connection);
            DataConnection.Open();
            dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Loans", DataConnection);
            adapter.Fill(dataSet, "Loans");
            foreach (DataRow dataRow in dataSet.Tables["Loans"].Rows)
            {
                if (idClient == Convert.ToInt32(dataRow.ItemArray.GetValue(1)) &&
                    idLoan == Convert.ToInt32(dataRow.ItemArray.GetValue(0)))
                {
                    return Convert.ToInt32(dataRow.ItemArray.GetValue(2));
                }
            }
            DataConnection.Close();
            return 0;
        }

        private void buttonReturnBook_Click(object sender, EventArgs e)
        {
            if (valideIdCL(textBoxIdClientReturn.Text, textBoxLoan.Text) == true)
            {
                int idClient = Convert.ToInt32(textBoxIdClientReturn.Text);
                int idLoan = Convert.ToInt32(textBoxLoan.Text);
                if (checkLoan(idClient, idLoan) == true && getBookIdFromLoan(idClient, idLoan) > 0)
                {
                    returnBook(idClient, idLoan);
                    int quantity = getBookQuantity(getBookIdFromLoan(idClient, idLoan)) + 1;
                    updateBookQuantity(getBookIdFromLoan(idClient, idLoan), quantity);
                    _ = new List<Book>();
                    List<Book> bookss = getBooks();
                    listBoxBooks.Items.Clear();
                    showBooks(bookss);
                }
            }
            refresh();
        }

    }
}
