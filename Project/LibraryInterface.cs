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

namespace Proiect
{
    public partial class LibraryInterface : Form
    {
       
        public LibraryInterface()
        {
            InitializeComponent();
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            List<Librarian> librarians = new List<Librarian>();
            getLibrarians(librarians);
            Boolean registered = false;

            foreach (Librarian librarian in librarians)
            {

            if (username.Text == librarian.username.Trim() &&
                password.Text == librarian.password.Trim())
            {

                    LibrarianInterface librarianInterface = new LibrarianInterface();
                    librarianInterface.Show();
                    registered = true;
                    username.Text = "Username";
                    password.Text = "Password";
                    break;
            }
          
            }
            if (registered == false ) MessageBox.Show("Wrong username or password!"  );

        }

        private void getLibrarians(List<Librarian> librarians)
        {
            DataSet dataSetLibrarians;
            string Connection = @"Data Source = (LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=|DataDirectory|Database1.mdf;
                                        Integrated Security = True";
            SqlConnection DataConnection = new SqlConnection(Connection);
            DataConnection.Open();
            dataSetLibrarians = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Librarians", DataConnection);
            adapter.Fill(dataSetLibrarians, "Librarians");
            foreach(DataRow dataRow in dataSetLibrarians.Tables["Librarians"].Rows)
            {
                int id = Convert.ToInt32(dataRow.ItemArray.GetValue(0));
                String username = dataRow.ItemArray.GetValue(1).ToString();
                String password = dataRow.ItemArray.GetValue(2).ToString();
                Librarian librarian = new Librarian(id, username, password);
                librarians.Add(librarian);

            }

        }

        

        private void clientButton_Click(object sender, EventArgs e)
        {
            
            ClientInterface clientInterface = new ClientInterface();
            clientInterface.Show();
        }

        private void UsernameMouseClick(object sender, MouseEventArgs e)
        {
            username.Clear();
        }

        private void passwordMouseClick(object sender, MouseEventArgs e)
        {
            password.Clear();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
