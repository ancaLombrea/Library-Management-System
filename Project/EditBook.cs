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
    public partial class EditBook : Form
    {
        public EditBook()
        {
            InitializeComponent();
        }

        private void button_title_Click(object sender, EventArgs e)
        {
            String BookSelected = null;
            String title = null;
            try
            {
                BookSelected = textBoxID.Text;
                title = textBox_title.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Choose an id!");
            }

            if (VerifyIdBook(BookSelected))
            {      
                ChangeTitleOfBook(BookSelected, title);
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void button_author_Click(object sender, EventArgs e)
        {
            String BookSelected = null;
            String author = null;
            try
            {
                BookSelected = textBoxID.Text;
                author = textBox_author.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Choose an id!");
            }

            if (VerifyIdBook(BookSelected))
            {
                ChangeAuthorOfBook(BookSelected, author);
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void button_quantity_Click(object sender, EventArgs e)
        {
            String BookSelected = null;
            String quantity = null;
            try
            {
                BookSelected = textBoxID.Text;
                quantity = textBox_quantity.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Choose an id!");
            }

            if (VerifyIdBook(BookSelected))
            {
                ChangeQuantityOfBook(BookSelected, quantity);
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void ChangeQuantityOfBook(String bookSelected, String quantity)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string Connection = @"Data Source = (LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=" + projectDirectory + @"\Database1.mdf;" +
                                        "Integrated Security = True";
            SqlConnection DataConnection = new SqlConnection(Connection);
            DataConnection.Open();

            SqlCommand command = new SqlCommand("UPDATE Books SET quantity = @quantity " +
                                                 "WHERE Id LIKE @oldId", DataConnection);

            command.Parameters.AddWithValue("@quantity", textBox_quantity.Text);

            if (quantity != "")
            {
                SqlParameter parameter = command.Parameters.AddWithValue("@oldId", bookSelected);
                parameter.SourceVersion = DataRowVersion.Original;
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Done.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!");
                }
            }
            else
            {
                MessageBox.Show("Change quantity!");
            }
            DataConnection.Close();
        }

        private void ChangeTitleOfBook(String bookSelected, String title)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string Connection = @"Data Source = (LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=" + projectDirectory + @"\Database1.mdf;" +
                                        "Integrated Security = True";
            SqlConnection DataConnection = new SqlConnection(Connection);
            DataConnection.Open();

            SqlCommand command = new SqlCommand("UPDATE Books SET title = @title " +
                                                 "WHERE Id LIKE @oldId", DataConnection);

            command.Parameters.AddWithValue("@title", textBox_title.Text);

            if (title != "")
            {
                SqlParameter parameter = command.Parameters.AddWithValue("@oldId", bookSelected);
                parameter.SourceVersion = DataRowVersion.Original;
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Done.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!");
                }
            }
            else
            {
                MessageBox.Show("Change title!");
            }
            DataConnection.Close();
        }

        private void ChangeAuthorOfBook(String bookSelected, String author)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string Connection = @"Data Source = (LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=" + projectDirectory + @"\Database1.mdf;" +
                                        "Integrated Security = True";
            SqlConnection DataConnection = new SqlConnection(Connection);
            DataConnection.Open();

            SqlCommand command = new SqlCommand("UPDATE Books SET author = @author " +
                                                 "WHERE Id LIKE @oldId", DataConnection);

            command.Parameters.AddWithValue("@author", textBox_author.Text);

            if (author != "")
            {
                SqlParameter parameter = command.Parameters.AddWithValue("@oldId", bookSelected);
                parameter.SourceVersion = DataRowVersion.Original;
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Done.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!");
                }
            }
            else
            {
                MessageBox.Show("Change author!");
            }
            DataConnection.Close();
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
                return false;
        }

        private void IdMouseClick(object sender, MouseEventArgs e)
        {
            textBoxID.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_title.Clear();
            textBox_author.Clear();
            textBox_quantity.Clear();

            String BookSelected = null;
            try
            {
                BookSelected = textBoxID.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Choose an id!");
            }
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string Connection = @"Data Source = (LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=" + projectDirectory + @"\Database1.mdf;" +
                                        "Integrated Security = True";
            SqlConnection DataConnection = new SqlConnection(Connection);
            DataConnection.Open();
            DataSet dataSet;
            dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Books", DataConnection);
            adapter.Fill(dataSet, "Books");

            foreach (DataRow dataRow in dataSet.Tables["Books"].Rows)
            {
                if (BookSelected == dataRow.ItemArray.GetValue(0).ToString())
                {
                    textBox_title.Text = dataRow.ItemArray.GetValue(1).ToString();
                    textBox_author.Text = dataRow.ItemArray.GetValue(2).ToString();
                    textBox_quantity.Text = dataRow.ItemArray.GetValue(3).ToString();
                }
            }
            DataConnection.Close();
        }     
    }
}
