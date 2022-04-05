
namespace DatabaseExample
{
    partial class Login
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
            this.loginButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.usernameLoginTB = new System.Windows.Forms.TextBox();
            this.passwordLoginTB = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordCreateLabel = new System.Windows.Forms.Label();
            this.usernameCreateLabel = new System.Windows.Forms.Label();
            this.passwordCreateTB = new System.Windows.Forms.TextBox();
            this.usernameCreateTB = new System.Windows.Forms.TextBox();
            this.lastNameCreateLabel = new System.Windows.Forms.Label();
            this.firstNameCreateLabel = new System.Windows.Forms.Label();
            this.lastNameCreateTB = new System.Windows.Forms.TextBox();
            this.FirstNameCreateTB = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.createAccLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(785, 274);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(108, 50);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(1374, 281);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 49);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // usernameLoginTB
            // 
            this.usernameLoginTB.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLoginTB.Location = new System.Drawing.Point(1082, 103);
            this.usernameLoginTB.Multiline = true;
            this.usernameLoginTB.Name = "usernameLoginTB";
            this.usernameLoginTB.Size = new System.Drawing.Size(392, 81);
            this.usernameLoginTB.TabIndex = 2;
            // 
            // passwordLoginTB
            // 
            this.passwordLoginTB.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLoginTB.Location = new System.Drawing.Point(1082, 190);
            this.passwordLoginTB.Multiline = true;
            this.passwordLoginTB.Name = "passwordLoginTB";
            this.passwordLoginTB.PasswordChar = '?';
            this.passwordLoginTB.Size = new System.Drawing.Size(392, 78);
            this.passwordLoginTB.TabIndex = 3;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(713, 111);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(269, 76);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username: ";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(727, 190);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(251, 76);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password: ";
            // 
            // passwordCreateLabel
            // 
            this.passwordCreateLabel.AutoSize = true;
            this.passwordCreateLabel.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordCreateLabel.Location = new System.Drawing.Point(15, 181);
            this.passwordCreateLabel.Name = "passwordCreateLabel";
            this.passwordCreateLabel.Size = new System.Drawing.Size(251, 76);
            this.passwordCreateLabel.TabIndex = 9;
            this.passwordCreateLabel.Text = "Password: ";
            // 
            // usernameCreateLabel
            // 
            this.usernameCreateLabel.AutoSize = true;
            this.usernameCreateLabel.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameCreateLabel.Location = new System.Drawing.Point(3, 100);
            this.usernameCreateLabel.Name = "usernameCreateLabel";
            this.usernameCreateLabel.Size = new System.Drawing.Size(269, 76);
            this.usernameCreateLabel.TabIndex = 8;
            this.usernameCreateLabel.Text = "Username: ";
            // 
            // passwordCreateTB
            // 
            this.passwordCreateTB.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordCreateTB.Location = new System.Drawing.Point(370, 180);
            this.passwordCreateTB.Multiline = true;
            this.passwordCreateTB.Name = "passwordCreateTB";
            this.passwordCreateTB.PasswordChar = '?';
            this.passwordCreateTB.Size = new System.Drawing.Size(343, 66);
            this.passwordCreateTB.TabIndex = 7;
            // 
            // usernameCreateTB
            // 
            this.usernameCreateTB.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameCreateTB.Location = new System.Drawing.Point(370, 101);
            this.usernameCreateTB.Multiline = true;
            this.usernameCreateTB.Name = "usernameCreateTB";
            this.usernameCreateTB.Size = new System.Drawing.Size(343, 73);
            this.usernameCreateTB.TabIndex = 6;
            // 
            // lastNameCreateLabel
            // 
            this.lastNameCreateLabel.AutoSize = true;
            this.lastNameCreateLabel.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameCreateLabel.Location = new System.Drawing.Point(-13, 334);
            this.lastNameCreateLabel.Name = "lastNameCreateLabel";
            this.lastNameCreateLabel.Size = new System.Drawing.Size(284, 76);
            this.lastNameCreateLabel.TabIndex = 13;
            this.lastNameCreateLabel.Text = "Last Name: ";
            // 
            // firstNameCreateLabel
            // 
            this.firstNameCreateLabel.AutoSize = true;
            this.firstNameCreateLabel.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameCreateLabel.Location = new System.Drawing.Point(-13, 252);
            this.firstNameCreateLabel.Name = "firstNameCreateLabel";
            this.firstNameCreateLabel.Size = new System.Drawing.Size(288, 76);
            this.firstNameCreateLabel.TabIndex = 12;
            this.firstNameCreateLabel.Text = "First Name: ";
            // 
            // lastNameCreateTB
            // 
            this.lastNameCreateTB.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameCreateTB.Location = new System.Drawing.Point(370, 334);
            this.lastNameCreateTB.Multiline = true;
            this.lastNameCreateTB.Name = "lastNameCreateTB";
            this.lastNameCreateTB.Size = new System.Drawing.Size(343, 72);
            this.lastNameCreateTB.TabIndex = 11;
            // 
            // FirstNameCreateTB
            // 
            this.FirstNameCreateTB.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameCreateTB.Location = new System.Drawing.Point(370, 252);
            this.FirstNameCreateTB.Multiline = true;
            this.FirstNameCreateTB.Name = "FirstNameCreateTB";
            this.FirstNameCreateTB.Size = new System.Drawing.Size(343, 74);
            this.FirstNameCreateTB.TabIndex = 10;
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(0, 407);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(143, 50);
            this.createButton.TabIndex = 14;
            this.createButton.Text = "Register";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(610, 407);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(103, 50);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // createAccLabel
            // 
            this.createAccLabel.AutoSize = true;
            this.createAccLabel.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccLabel.Location = new System.Drawing.Point(161, 7);
            this.createAccLabel.Name = "createAccLabel";
            this.createAccLabel.Size = new System.Drawing.Size(381, 76);
            this.createAccLabel.TabIndex = 16;
            this.createAccLabel.Text = "Create Account";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(987, 27);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(156, 76);
            this.loginLabel.TabIndex = 17;
            this.loginLabel.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 460);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.createAccLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.lastNameCreateLabel);
            this.Controls.Add(this.firstNameCreateLabel);
            this.Controls.Add(this.lastNameCreateTB);
            this.Controls.Add(this.FirstNameCreateTB);
            this.Controls.Add(this.passwordCreateLabel);
            this.Controls.Add(this.usernameCreateLabel);
            this.Controls.Add(this.passwordCreateTB);
            this.Controls.Add(this.usernameCreateTB);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordLoginTB);
            this.Controls.Add(this.usernameLoginTB);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loginButton);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox usernameLoginTB;
        private System.Windows.Forms.TextBox passwordLoginTB;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label passwordCreateLabel;
        private System.Windows.Forms.Label usernameCreateLabel;
        private System.Windows.Forms.TextBox passwordCreateTB;
        private System.Windows.Forms.TextBox usernameCreateTB;
        private System.Windows.Forms.Label lastNameCreateLabel;
        private System.Windows.Forms.Label firstNameCreateLabel;
        private System.Windows.Forms.TextBox lastNameCreateTB;
        private System.Windows.Forms.TextBox FirstNameCreateTB;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label createAccLabel;
        private System.Windows.Forms.Label loginLabel;
    }
}

