namespace Proiect
{
    partial class LibrarianInterface
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
            this.groupBox_librarianInteface3 = new System.Windows.Forms.GroupBox();
            this.listBox_clients = new System.Windows.Forms.ListBox();
            this.viewClients = new System.Windows.Forms.Button();
            this.formatClientLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_librarianInteface2 = new System.Windows.Forms.GroupBox();
            this.deleteBook = new System.Windows.Forms.Button();
            this.idTextField = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.groupBox_librarianInteface1 = new System.Windows.Forms.GroupBox();
            this.addBook = new System.Windows.Forms.Button();
            this.nrOfBooksTextField = new System.Windows.Forms.TextBox();
            this.authorTextField = new System.Windows.Forms.TextBox();
            this.titleTextField = new System.Windows.Forms.TextBox();
            this.nrOfBooksLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label_welcome = new System.Windows.Forms.Label();
            this.groupBox_librarianInteface4 = new System.Windows.Forms.GroupBox();
            this.viewBorrowedBooks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox_loans = new System.Windows.Forms.ListBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.orderByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.idClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_librarianInteface3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox_librarianInteface2.SuspendLayout();
            this.groupBox_librarianInteface1.SuspendLayout();
            this.groupBox_librarianInteface4.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_librarianInteface3
            // 
            this.groupBox_librarianInteface3.Controls.Add(this.listBox_clients);
            this.groupBox_librarianInteface3.Controls.Add(this.viewClients);
            this.groupBox_librarianInteface3.Controls.Add(this.formatClientLabel);
            this.groupBox_librarianInteface3.Controls.Add(this.menuStrip1);
            this.groupBox_librarianInteface3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_librarianInteface3.Location = new System.Drawing.Point(28, 406);
            this.groupBox_librarianInteface3.Name = "groupBox_librarianInteface3";
            this.groupBox_librarianInteface3.Size = new System.Drawing.Size(906, 319);
            this.groupBox_librarianInteface3.TabIndex = 10;
            this.groupBox_librarianInteface3.TabStop = false;
            // 
            // listBox_clients
            // 
            this.listBox_clients.FormattingEnabled = true;
            this.listBox_clients.ItemHeight = 29;
            this.listBox_clients.Location = new System.Drawing.Point(24, 54);
            this.listBox_clients.Name = "listBox_clients";
            this.listBox_clients.Size = new System.Drawing.Size(742, 236);
            this.listBox_clients.TabIndex = 3;
            // 
            // viewClients
            // 
            this.viewClients.Location = new System.Drawing.Point(772, 186);
            this.viewClients.Name = "viewClients";
            this.viewClients.Size = new System.Drawing.Size(131, 75);
            this.viewClients.TabIndex = 2;
            this.viewClients.Text = "View clients list";
            this.viewClients.UseVisualStyleBackColor = true;
            this.viewClients.Click += new System.EventHandler(this.viewClients_Click);
            // 
            // formatClientLabel
            // 
            this.formatClientLabel.AutoSize = true;
            this.formatClientLabel.Location = new System.Drawing.Point(24, 22);
            this.formatClientLabel.Name = "formatClientLabel";
            this.formatClientLabel.Size = new System.Drawing.Size(733, 29);
            this.formatClientLabel.TabIndex = 0;
            this.formatClientLabel.Text = "ID     Name                            Email                              Phone N" +
    "umber     ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(791, 31);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(112, 285);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.idToolStripMenuItem,
            this.lastNameToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(103, 29);
            this.toolStripMenuItem1.Text = "Order by:";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.nameToolStripMenuItem.Text = "First name";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // idToolStripMenuItem
            // 
            this.idToolStripMenuItem.Name = "idToolStripMenuItem";
            this.idToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.idToolStripMenuItem.Text = "Id";
            this.idToolStripMenuItem.Click += new System.EventHandler(this.idToolStripMenuItem_Click);
            // 
            // lastNameToolStripMenuItem
            // 
            this.lastNameToolStripMenuItem.Name = "lastNameToolStripMenuItem";
            this.lastNameToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.lastNameToolStripMenuItem.Text = "Last name";
            this.lastNameToolStripMenuItem.Click += new System.EventHandler(this.lastNameToolStripMenuItem_Click);
            // 
            // groupBox_librarianInteface2
            // 
            this.groupBox_librarianInteface2.Controls.Add(this.deleteBook);
            this.groupBox_librarianInteface2.Controls.Add(this.idTextField);
            this.groupBox_librarianInteface2.Controls.Add(this.idLabel);
            this.groupBox_librarianInteface2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_librarianInteface2.Location = new System.Drawing.Point(28, 228);
            this.groupBox_librarianInteface2.Name = "groupBox_librarianInteface2";
            this.groupBox_librarianInteface2.Size = new System.Drawing.Size(433, 133);
            this.groupBox_librarianInteface2.TabIndex = 9;
            this.groupBox_librarianInteface2.TabStop = false;
            // 
            // deleteBook
            // 
            this.deleteBook.Location = new System.Drawing.Point(42, 73);
            this.deleteBook.Name = "deleteBook";
            this.deleteBook.Size = new System.Drawing.Size(333, 45);
            this.deleteBook.TabIndex = 2;
            this.deleteBook.Text = "Delete book from library";
            this.deleteBook.UseVisualStyleBackColor = true;
            this.deleteBook.Click += new System.EventHandler(this.deleteBook_Click);
            // 
            // idTextField
            // 
            this.idTextField.Location = new System.Drawing.Point(225, 28);
            this.idTextField.Name = "idTextField";
            this.idTextField.Size = new System.Drawing.Size(150, 35);
            this.idTextField.TabIndex = 1;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(37, 31);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(164, 29);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Id of the book:";
            // 
            // groupBox_librarianInteface1
            // 
            this.groupBox_librarianInteface1.Controls.Add(this.addBook);
            this.groupBox_librarianInteface1.Controls.Add(this.nrOfBooksTextField);
            this.groupBox_librarianInteface1.Controls.Add(this.authorTextField);
            this.groupBox_librarianInteface1.Controls.Add(this.titleTextField);
            this.groupBox_librarianInteface1.Controls.Add(this.nrOfBooksLabel);
            this.groupBox_librarianInteface1.Controls.Add(this.authorLabel);
            this.groupBox_librarianInteface1.Controls.Add(this.titleLabel);
            this.groupBox_librarianInteface1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_librarianInteface1.Location = new System.Drawing.Point(28, 32);
            this.groupBox_librarianInteface1.Name = "groupBox_librarianInteface1";
            this.groupBox_librarianInteface1.Size = new System.Drawing.Size(808, 190);
            this.groupBox_librarianInteface1.TabIndex = 8;
            this.groupBox_librarianInteface1.TabStop = false;
            this.groupBox_librarianInteface1.Text = " ";
            // 
            // addBook
            // 
            this.addBook.Location = new System.Drawing.Point(590, 59);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(187, 72);
            this.addBook.TabIndex = 6;
            this.addBook.Text = "Add new book!";
            this.addBook.UseVisualStyleBackColor = true;
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // nrOfBooksTextField
            // 
            this.nrOfBooksTextField.Location = new System.Drawing.Point(131, 121);
            this.nrOfBooksTextField.Name = "nrOfBooksTextField";
            this.nrOfBooksTextField.Size = new System.Drawing.Size(444, 35);
            this.nrOfBooksTextField.TabIndex = 5;
            this.nrOfBooksTextField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.quantityMouseClick);
            // 
            // authorTextField
            // 
            this.authorTextField.Location = new System.Drawing.Point(131, 75);
            this.authorTextField.Name = "authorTextField";
            this.authorTextField.Size = new System.Drawing.Size(444, 35);
            this.authorTextField.TabIndex = 4;
            this.authorTextField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.authorMouseClick);
            // 
            // titleTextField
            // 
            this.titleTextField.Location = new System.Drawing.Point(131, 25);
            this.titleTextField.Name = "titleTextField";
            this.titleTextField.Size = new System.Drawing.Size(444, 35);
            this.titleTextField.TabIndex = 3;
            this.titleTextField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.titleMouseClick);
            this.titleTextField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.titleTextField_KeyDown);
            // 
            // nrOfBooksLabel
            // 
            this.nrOfBooksLabel.AutoSize = true;
            this.nrOfBooksLabel.Location = new System.Drawing.Point(19, 127);
            this.nrOfBooksLabel.Name = "nrOfBooksLabel";
            this.nrOfBooksLabel.Size = new System.Drawing.Size(106, 29);
            this.nrOfBooksLabel.TabIndex = 2;
            this.nrOfBooksLabel.Text = "Quantity:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(37, 81);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(88, 29);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Author:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(58, 31);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(67, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.Location = new System.Drawing.Point(23, 0);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(198, 29);
            this.label_welcome.TabIndex = 7;
            this.label_welcome.Text = "Welcome back! ";
            // 
            // groupBox_librarianInteface4
            // 
            this.groupBox_librarianInteface4.Controls.Add(this.listBox_loans);
            this.groupBox_librarianInteface4.Controls.Add(this.viewBorrowedBooks);
            this.groupBox_librarianInteface4.Controls.Add(this.label1);
            this.groupBox_librarianInteface4.Controls.Add(this.menuStrip2);
            this.groupBox_librarianInteface4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_librarianInteface4.Location = new System.Drawing.Point(28, 731);
            this.groupBox_librarianInteface4.Name = "groupBox_librarianInteface4";
            this.groupBox_librarianInteface4.Size = new System.Drawing.Size(900, 314);
            this.groupBox_librarianInteface4.TabIndex = 11;
            this.groupBox_librarianInteface4.TabStop = false;
            this.groupBox_librarianInteface4.Text = " ";
            // 
            // viewBorrowedBooks
            // 
            this.viewBorrowedBooks.Location = new System.Drawing.Point(763, 164);
            this.viewBorrowedBooks.Name = "viewBorrowedBooks";
            this.viewBorrowedBooks.Size = new System.Drawing.Size(131, 97);
            this.viewBorrowedBooks.TabIndex = 2;
            this.viewBorrowedBooks.Text = "View borrowed books";
            this.viewBorrowedBooks.UseVisualStyleBackColor = true;
            this.viewBorrowedBooks.Click += new System.EventHandler(this.viewBorrowedBooks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID         ID-Client                         ID-Book                          Ret" +
    "urned";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "Edit book features";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox_loans
            // 
            this.listBox_loans.FormattingEnabled = true;
            this.listBox_loans.ItemHeight = 29;
            this.listBox_loans.Location = new System.Drawing.Point(24, 54);
            this.listBox_loans.Name = "listBox_loans";
            this.listBox_loans.Size = new System.Drawing.Size(733, 236);
            this.listBox_loans.TabIndex = 4;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderByToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(788, 31);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(109, 280);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // orderByToolStripMenuItem
            // 
            this.orderByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idBookToolStripMenuItem,
            this.idClientToolStripMenuItem,
            this.idToolStripMenuItem1});
            this.orderByToolStripMenuItem.Name = "orderByToolStripMenuItem";
            this.orderByToolStripMenuItem.Size = new System.Drawing.Size(173, 29);
            this.orderByToolStripMenuItem.Text = "Order by:";
            // 
            // idToolStripMenuItem1
            // 
            this.idToolStripMenuItem1.Name = "idToolStripMenuItem1";
            this.idToolStripMenuItem1.Size = new System.Drawing.Size(177, 34);
            this.idToolStripMenuItem1.Text = "Id";
            this.idToolStripMenuItem1.Click += new System.EventHandler(this.idToolStripMenuItem1_Click);
            // 
            // idClientToolStripMenuItem
            // 
            this.idClientToolStripMenuItem.Name = "idClientToolStripMenuItem";
            this.idClientToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.idClientToolStripMenuItem.Text = "Id client";
            this.idClientToolStripMenuItem.Click += new System.EventHandler(this.idClientToolStripMenuItem_Click);
            // 
            // idBookToolStripMenuItem
            // 
            this.idBookToolStripMenuItem.Name = "idBookToolStripMenuItem";
            this.idBookToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.idBookToolStripMenuItem.Text = "Id book";
            this.idBookToolStripMenuItem.Click += new System.EventHandler(this.idBookToolStripMenuItem_Click);
            // 
            // LibrarianInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(946, 1050);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox_librarianInteface4);
            this.Controls.Add(this.groupBox_librarianInteface3);
            this.Controls.Add(this.groupBox_librarianInteface2);
            this.Controls.Add(this.groupBox_librarianInteface1);
            this.Controls.Add(this.label_welcome);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Proiect.Properties.Settings.Default, "b", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::Proiect.Properties.Settings.Default.b;
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "LibrarianInterface";
            this.Text = "LibrarianInterface";
            this.groupBox_librarianInteface3.ResumeLayout(false);
            this.groupBox_librarianInteface3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_librarianInteface2.ResumeLayout(false);
            this.groupBox_librarianInteface2.PerformLayout();
            this.groupBox_librarianInteface1.ResumeLayout(false);
            this.groupBox_librarianInteface1.PerformLayout();
            this.groupBox_librarianInteface4.ResumeLayout(false);
            this.groupBox_librarianInteface4.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_librarianInteface3;
        private System.Windows.Forms.Button viewClients;
        private System.Windows.Forms.Label formatClientLabel;
        private System.Windows.Forms.GroupBox groupBox_librarianInteface2;
        private System.Windows.Forms.Button deleteBook;
        private System.Windows.Forms.TextBox idTextField;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.GroupBox groupBox_librarianInteface1;
        private System.Windows.Forms.Button addBook;
        private System.Windows.Forms.TextBox nrOfBooksTextField;
        private System.Windows.Forms.TextBox authorTextField;
        private System.Windows.Forms.TextBox titleTextField;
        private System.Windows.Forms.Label nrOfBooksLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.GroupBox groupBox_librarianInteface4;
        private System.Windows.Forms.Button viewBorrowedBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox_clients;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastNameToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox_loans;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem orderByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idToolStripMenuItem1;
    }
}