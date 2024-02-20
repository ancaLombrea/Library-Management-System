
namespace Proiect
{
    partial class ClientInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonFindLoan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReturnBook = new System.Windows.Forms.Button();
            this.textBoxBookFindLoan = new System.Windows.Forms.TextBox();
            this.textBoxClientFindLoan = new System.Windows.Forms.TextBox();
            this.textBoxLoan = new System.Windows.Forms.TextBox();
            this.textBoxIdClientReturn = new System.Windows.Forms.TextBox();
            this.groupBoxBorrowBook = new System.Windows.Forms.GroupBox();
            this.buttonFindIdClient = new System.Windows.Forms.Button();
            this.labelReminderClient = new System.Windows.Forms.Label();
            this.labelIdBook = new System.Windows.Forms.Label();
            this.labelIdClient = new System.Windows.Forms.Label();
            this.textBoxBorrowFeedback = new System.Windows.Forms.TextBox();
            this.buttonBorrow = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxIdBook = new System.Windows.Forms.TextBox();
            this.textBoxIdClientBorrow = new System.Windows.Forms.TextBox();
            this.groupBoxBooks = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.orderByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNewClient = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBoxBorrowBook.SuspendLayout();
            this.groupBoxBooks.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonFindLoan);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonReturnBook);
            this.groupBox2.Controls.Add(this.textBoxBookFindLoan);
            this.groupBox2.Controls.Add(this.textBoxClientFindLoan);
            this.groupBox2.Controls.Add(this.textBoxLoan);
            this.groupBox2.Controls.Add(this.textBoxIdClientReturn);
            this.groupBox2.Location = new System.Drawing.Point(15, 673);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(804, 247);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Return book";
            // 
            // buttonFindLoan
            // 
            this.buttonFindLoan.Location = new System.Drawing.Point(691, 124);
            this.buttonFindLoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFindLoan.Name = "buttonFindLoan";
            this.buttonFindLoan.Size = new System.Drawing.Size(83, 29);
            this.buttonFindLoan.TabIndex = 21;
            this.buttonFindLoan.Text = "Find ID";
            this.buttonFindLoan.UseVisualStyleBackColor = true;
            this.buttonFindLoan.Click += new System.EventHandler(this.buttonFindLoan_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "ID Loan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Book name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "ID Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 40);
            this.label2.TabIndex = 16;
            this.label2.Text = "Don\'t remember the loan ID? Please introduce \r\nyour client ID and nook name here." +
    "";
            // 
            // buttonReturnBook
            // 
            this.buttonReturnBook.Location = new System.Drawing.Point(299, 182);
            this.buttonReturnBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonReturnBook.Name = "buttonReturnBook";
            this.buttonReturnBook.Size = new System.Drawing.Size(153, 35);
            this.buttonReturnBook.TabIndex = 15;
            this.buttonReturnBook.Text = "Return book";
            this.buttonReturnBook.UseVisualStyleBackColor = true;
            this.buttonReturnBook.Click += new System.EventHandler(this.buttonReturnBook_Click);
            // 
            // textBoxBookFindLoan
            // 
            this.textBoxBookFindLoan.Location = new System.Drawing.Point(441, 146);
            this.textBoxBookFindLoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBookFindLoan.Name = "textBoxBookFindLoan";
            this.textBoxBookFindLoan.Size = new System.Drawing.Size(217, 26);
            this.textBoxBookFindLoan.TabIndex = 14;
            // 
            // textBoxClientFindLoan
            // 
            this.textBoxClientFindLoan.Location = new System.Drawing.Point(441, 114);
            this.textBoxClientFindLoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxClientFindLoan.Name = "textBoxClientFindLoan";
            this.textBoxClientFindLoan.Size = new System.Drawing.Size(217, 26);
            this.textBoxClientFindLoan.TabIndex = 13;
            // 
            // textBoxLoan
            // 
            this.textBoxLoan.Location = new System.Drawing.Point(619, 62);
            this.textBoxLoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLoan.Name = "textBoxLoan";
            this.textBoxLoan.Size = new System.Drawing.Size(114, 26);
            this.textBoxLoan.TabIndex = 9;
            // 
            // textBoxIdClientReturn
            // 
            this.textBoxIdClientReturn.Location = new System.Drawing.Point(197, 62);
            this.textBoxIdClientReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxIdClientReturn.Name = "textBoxIdClientReturn";
            this.textBoxIdClientReturn.Size = new System.Drawing.Size(114, 26);
            this.textBoxIdClientReturn.TabIndex = 6;
            // 
            // groupBoxBorrowBook
            // 
            this.groupBoxBorrowBook.Controls.Add(this.buttonFindIdClient);
            this.groupBoxBorrowBook.Controls.Add(this.labelReminderClient);
            this.groupBoxBorrowBook.Controls.Add(this.labelIdBook);
            this.groupBoxBorrowBook.Controls.Add(this.labelIdClient);
            this.groupBoxBorrowBook.Controls.Add(this.textBoxBorrowFeedback);
            this.groupBoxBorrowBook.Controls.Add(this.buttonBorrow);
            this.groupBoxBorrowBook.Controls.Add(this.textBoxEmail);
            this.groupBoxBorrowBook.Controls.Add(this.textBoxIdBook);
            this.groupBoxBorrowBook.Controls.Add(this.textBoxIdClientBorrow);
            this.groupBoxBorrowBook.Location = new System.Drawing.Point(15, 463);
            this.groupBoxBorrowBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxBorrowBook.Name = "groupBoxBorrowBook";
            this.groupBoxBorrowBook.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxBorrowBook.Size = new System.Drawing.Size(804, 202);
            this.groupBoxBorrowBook.TabIndex = 10;
            this.groupBoxBorrowBook.TabStop = false;
            this.groupBoxBorrowBook.Text = "Borrow a book";
            // 
            // buttonFindIdClient
            // 
            this.buttonFindIdClient.Location = new System.Drawing.Point(691, 80);
            this.buttonFindIdClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFindIdClient.Name = "buttonFindIdClient";
            this.buttonFindIdClient.Size = new System.Drawing.Size(83, 29);
            this.buttonFindIdClient.TabIndex = 11;
            this.buttonFindIdClient.Text = "Find ID";
            this.buttonFindIdClient.UseVisualStyleBackColor = true;
            this.buttonFindIdClient.Click += new System.EventHandler(this.buttonFindIdClient_Click);
            // 
            // labelReminderClient
            // 
            this.labelReminderClient.AutoSize = true;
            this.labelReminderClient.Location = new System.Drawing.Point(7, 85);
            this.labelReminderClient.Name = "labelReminderClient";
            this.labelReminderClient.Size = new System.Drawing.Size(424, 20);
            this.labelReminderClient.TabIndex = 10;
            this.labelReminderClient.Text = "Don\'t remember your ID? Please introduce your email here.";
            // 
            // labelIdBook
            // 
            this.labelIdBook.AutoSize = true;
            this.labelIdBook.Location = new System.Drawing.Point(514, 41);
            this.labelIdBook.Name = "labelIdBook";
            this.labelIdBook.Size = new System.Drawing.Size(67, 20);
            this.labelIdBook.TabIndex = 9;
            this.labelIdBook.Text = "ID Book";
            // 
            // labelIdClient
            // 
            this.labelIdClient.AutoSize = true;
            this.labelIdClient.Location = new System.Drawing.Point(99, 41);
            this.labelIdClient.Name = "labelIdClient";
            this.labelIdClient.Size = new System.Drawing.Size(70, 20);
            this.labelIdClient.TabIndex = 8;
            this.labelIdClient.Text = "ID Client";
            // 
            // textBoxBorrowFeedback
            // 
            this.textBoxBorrowFeedback.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxBorrowFeedback.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBorrowFeedback.Location = new System.Drawing.Point(9, 171);
            this.textBoxBorrowFeedback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBorrowFeedback.Name = "textBoxBorrowFeedback";
            this.textBoxBorrowFeedback.Size = new System.Drawing.Size(794, 19);
            this.textBoxBorrowFeedback.TabIndex = 7;
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.Location = new System.Drawing.Point(299, 135);
            this.buttonBorrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(153, 29);
            this.buttonBorrow.TabIndex = 6;
            this.buttonBorrow.Text = "Borrow book";
            this.buttonBorrow.UseVisualStyleBackColor = true;
            this.buttonBorrow.Click += new System.EventHandler(this.buttonBorrow_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(441, 80);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(231, 26);
            this.textBoxEmail.TabIndex = 5;
            // 
            // textBoxIdBook
            // 
            this.textBoxIdBook.Location = new System.Drawing.Point(612, 38);
            this.textBoxIdBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxIdBook.Name = "textBoxIdBook";
            this.textBoxIdBook.Size = new System.Drawing.Size(122, 26);
            this.textBoxIdBook.TabIndex = 3;
            // 
            // textBoxIdClientBorrow
            // 
            this.textBoxIdClientBorrow.Location = new System.Drawing.Point(197, 38);
            this.textBoxIdClientBorrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxIdClientBorrow.Name = "textBoxIdClientBorrow";
            this.textBoxIdClientBorrow.Size = new System.Drawing.Size(114, 26);
            this.textBoxIdClientBorrow.TabIndex = 2;
            // 
            // groupBoxBooks
            // 
            this.groupBoxBooks.Controls.Add(this.label1);
            this.groupBoxBooks.Controls.Add(this.listBoxBooks);
            this.groupBoxBooks.Controls.Add(this.menuStrip1);
            this.groupBoxBooks.Location = new System.Drawing.Point(12, 118);
            this.groupBoxBooks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxBooks.Name = "groupBoxBooks";
            this.groupBoxBooks.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxBooks.Size = new System.Drawing.Size(807, 338);
            this.groupBoxBooks.TabIndex = 9;
            this.groupBoxBooks.TabStop = false;
            this.groupBoxBooks.Text = "Our books";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(661, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID                   TITLE                                                    AUT" +
    "HOR                                        QUANTITY";
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.HorizontalScrollbar = true;
            this.listBoxBooks.ItemHeight = 20;
            this.listBoxBooks.Location = new System.Drawing.Point(18, 76);
            this.listBoxBooks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(734, 204);
            this.listBoxBooks.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderByToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 301);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(801, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // orderByToolStripMenuItem
            // 
            this.orderByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quantityToolStripMenuItem,
            this.titleToolStripMenuItem,
            this.idToolStripMenuItem,
            this.authorToolStripMenuItem});
            this.orderByToolStripMenuItem.Name = "orderByToolStripMenuItem";
            this.orderByToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.orderByToolStripMenuItem.Text = "Order by:";
            // 
            // quantityToolStripMenuItem
            // 
            this.quantityToolStripMenuItem.Name = "quantityToolStripMenuItem";
            this.quantityToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.quantityToolStripMenuItem.Text = "Quantity";
            this.quantityToolStripMenuItem.Click += new System.EventHandler(this.quantityToolStripMenuItem_Click);
            // 
            // titleToolStripMenuItem
            // 
            this.titleToolStripMenuItem.Name = "titleToolStripMenuItem";
            this.titleToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.titleToolStripMenuItem.Text = "Title";
            this.titleToolStripMenuItem.Click += new System.EventHandler(this.titleToolStripMenuItem_Click);
            // 
            // idToolStripMenuItem
            // 
            this.idToolStripMenuItem.Name = "idToolStripMenuItem";
            this.idToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.idToolStripMenuItem.Text = "Id";
            this.idToolStripMenuItem.Click += new System.EventHandler(this.idToolStripMenuItem_Click);
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.authorToolStripMenuItem.Text = "Author";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNewClient);
            this.groupBox1.Controls.Add(this.labelWelcome);
            this.groupBox1.Controls.Add(this.buttonCreateAccount);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(795, 98);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // labelNewClient
            // 
            this.labelNewClient.AutoSize = true;
            this.labelNewClient.Location = new System.Drawing.Point(74, 58);
            this.labelNewClient.Name = "labelNewClient";
            this.labelNewClient.Size = new System.Drawing.Size(272, 20);
            this.labelNewClient.TabIndex = 4;
            this.labelNewClient.Text = "New client? Please make an account!";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(299, 22);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(235, 20);
            this.labelWelcome.TabIndex = 3;
            this.labelWelcome.Text = "WELCOME TO OUR LIBRARY!";
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Location = new System.Drawing.Point(521, 59);
            this.buttonCreateAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(155, 29);
            this.buttonCreateAccount.TabIndex = 2;
            this.buttonCreateAccount.Text = "Create account!";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // ClientInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(837, 949);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxBorrowBook);
            this.Controls.Add(this.groupBoxBooks);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClientInterface";
            this.Text = "ClientInterface";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxBorrowBook.ResumeLayout(false);
            this.groupBoxBorrowBook.PerformLayout();
            this.groupBoxBooks.ResumeLayout(false);
            this.groupBoxBooks.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonFindLoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReturnBook;
        private System.Windows.Forms.TextBox textBoxBookFindLoan;
        private System.Windows.Forms.TextBox textBoxClientFindLoan;
        private System.Windows.Forms.TextBox textBoxLoan;
        private System.Windows.Forms.TextBox textBoxIdClientReturn;
        private System.Windows.Forms.GroupBox groupBoxBorrowBook;
        private System.Windows.Forms.Button buttonFindIdClient;
        private System.Windows.Forms.Label labelReminderClient;
        private System.Windows.Forms.Label labelIdBook;
        private System.Windows.Forms.Label labelIdClient;
        private System.Windows.Forms.TextBox textBoxBorrowFeedback;
        private System.Windows.Forms.Button buttonBorrow;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxIdBook;
        private System.Windows.Forms.TextBox textBoxIdClientBorrow;
        private System.Windows.Forms.GroupBox groupBoxBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quantityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNewClient;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonCreateAccount;
    }
}