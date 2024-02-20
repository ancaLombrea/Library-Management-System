namespace Proiect
{
    partial class LibraryInterface
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
        public void InitializeComponent()
        {
            this.libraryLabel = new System.Windows.Forms.Label();
            this.groupBox_librarianLogin = new System.Windows.Forms.GroupBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.clientButton = new System.Windows.Forms.Button();
            this.groupBox_librarianLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // libraryLabel
            // 
            this.libraryLabel.AutoSize = true;
            this.libraryLabel.Font = new System.Drawing.Font("Elephant", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libraryLabel.Location = new System.Drawing.Point(-2, 28);
            this.libraryLabel.Name = "libraryLabel";
            this.libraryLabel.Size = new System.Drawing.Size(846, 46);
            this.libraryLabel.TabIndex = 0;
            this.libraryLabel.Text = "LIBRARY MANAGEMENT PROJECT";
            // 
            // groupBox_librarianLogin
            // 
            this.groupBox_librarianLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox_librarianLogin.Controls.Add(this.loginButton);
            this.groupBox_librarianLogin.Controls.Add(this.password);
            this.groupBox_librarianLogin.Controls.Add(this.username);
            this.groupBox_librarianLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_librarianLogin.Location = new System.Drawing.Point(39, 103);
            this.groupBox_librarianLogin.Name = "groupBox_librarianLogin";
            this.groupBox_librarianLogin.Size = new System.Drawing.Size(778, 331);
            this.groupBox_librarianLogin.TabIndex = 1;
            this.groupBox_librarianLogin.TabStop = false;
            this.groupBox_librarianLogin.Text = "Librarian Login";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(252, 246);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(242, 49);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(216, 155);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(306, 39);
            this.password.TabIndex = 1;
            this.password.Text = "password";
            this.password.UseSystemPasswordChar = true;
            this.password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passwordMouseClick);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(216, 77);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(306, 39);
            this.username.TabIndex = 0;
            this.username.Text = "username";
            this.username.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UsernameMouseClick);
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // clientButton
            // 
            this.clientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientButton.Location = new System.Drawing.Point(258, 471);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(302, 62);
            this.clientButton.TabIndex = 2;
            this.clientButton.Text = "Client home page";
            this.clientButton.UseVisualStyleBackColor = true;
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
            // 
            // LibraryInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(858, 574);
            this.Controls.Add(this.clientButton);
            this.Controls.Add(this.groupBox_librarianLogin);
            this.Controls.Add(this.libraryLabel);
            this.Name = "LibraryInterface";
            this.Text = "Library management application ";
            this.groupBox_librarianLogin.ResumeLayout(false);
            this.groupBox_librarianLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label libraryLabel;
        private System.Windows.Forms.GroupBox groupBox_librarianLogin;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button clientButton;
    

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
  

        #endregion
    }
}


