
namespace DatabaseExample
{
    partial class AdminLandingPage
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
            this.logOutBtn = new System.Windows.Forms.Button();
            this.testBtn = new System.Windows.Forms.Button();
            this.musicBtn = new System.Windows.Forms.Button();
            this.usersBtn = new System.Windows.Forms.Button();
            this.songDBBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logOutBtn
            // 
            this.logOutBtn.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.Location = new System.Drawing.Point(52, 167);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(170, 47);
            this.logOutBtn.TabIndex = 0;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // testBtn
            // 
            this.testBtn.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testBtn.Location = new System.Drawing.Point(22, 220);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(228, 47);
            this.testBtn.TabIndex = 1;
            this.testBtn.Text = "Testing Ground";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // musicBtn
            // 
            this.musicBtn.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicBtn.Location = new System.Drawing.Point(52, 8);
            this.musicBtn.Name = "musicBtn";
            this.musicBtn.Size = new System.Drawing.Size(170, 47);
            this.musicBtn.TabIndex = 2;
            this.musicBtn.Text = "Music";
            this.musicBtn.UseVisualStyleBackColor = true;
            // 
            // usersBtn
            // 
            this.usersBtn.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersBtn.Location = new System.Drawing.Point(52, 114);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Size = new System.Drawing.Size(170, 47);
            this.usersBtn.TabIndex = 3;
            this.usersBtn.Text = "Users";
            this.usersBtn.UseVisualStyleBackColor = true;
            this.usersBtn.Click += new System.EventHandler(this.usersBtn_Click);
            // 
            // songDBBtn
            // 
            this.songDBBtn.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songDBBtn.Location = new System.Drawing.Point(52, 61);
            this.songDBBtn.Name = "songDBBtn";
            this.songDBBtn.Size = new System.Drawing.Size(170, 47);
            this.songDBBtn.TabIndex = 4;
            this.songDBBtn.Text = "Songs DB";
            this.songDBBtn.UseVisualStyleBackColor = true;
            this.songDBBtn.Click += new System.EventHandler(this.songDBBtn_Click);
            // 
            // AdminLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 326);
            this.Controls.Add(this.songDBBtn);
            this.Controls.Add(this.usersBtn);
            this.Controls.Add(this.musicBtn);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.logOutBtn);
            this.Name = "AdminLandingPage";
            this.Text = "Admin Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Button musicBtn;
        private System.Windows.Forms.Button usersBtn;
        private System.Windows.Forms.Button songDBBtn;
    }
}