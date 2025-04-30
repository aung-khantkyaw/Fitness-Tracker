namespace Fitness_Tracker
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            label1 = new Label();
            label2 = new Label();
            linkToLogin = new LinkLabel();
            tbUsername = new TextBox();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            tbConfirmPassword = new TextBox();
            btnRegistration = new Button();
            btnReset = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(606, 83);
            label1.Name = "label1";
            label1.Size = new Size(214, 30);
            label1.TabIndex = 0;
            label1.Text = "Create New Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(15, 353);
            label2.Name = "label2";
            label2.Size = new Size(165, 19);
            label2.TabIndex = 1;
            label2.Text = "Already have an account?";
            // 
            // linkToLogin
            // 
            linkToLogin.AutoSize = true;
            linkToLogin.Font = new Font("Segoe UI", 10F);
            linkToLogin.Location = new Point(186, 353);
            linkToLogin.Name = "linkToLogin";
            linkToLogin.Size = new Size(43, 19);
            linkToLogin.TabIndex = 2;
            linkToLogin.TabStop = true;
            linkToLogin.Text = "Login";
            linkToLogin.LinkClicked += linkToLogin_LinkClicked;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(606, 150);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(214, 23);
            tbUsername.TabIndex = 3;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(606, 218);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(214, 23);
            tbEmail.TabIndex = 4;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(606, 288);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(214, 23);
            tbPassword.TabIndex = 5;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Location = new Point(606, 355);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.PasswordChar = '*';
            tbConfirmPassword.Size = new Size(214, 23);
            tbConfirmPassword.TabIndex = 6;
            // 
            // btnRegistration
            // 
            btnRegistration.Location = new Point(606, 403);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(96, 23);
            btnRegistration.TabIndex = 7;
            btnRegistration.Text = "Registration";
            btnRegistration.UseVisualStyleBackColor = true;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(724, 403);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(96, 23);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(14, 259);
            label3.Name = "label3";
            label3.Size = new Size(305, 19);
            label3.TabIndex = 9;
            label3.Text = "Username can only contain letters and numbers.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(14, 291);
            label4.Name = "label4";
            label4.Size = new Size(286, 19);
            label4.TabIndex = 10;
            label4.Text = "Password must be exactly 12 characters long.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(14, 322);
            label5.Name = "label5";
            label5.Size = new Size(448, 19);
            label5.TabIndex = 11;
            label5.Text = "Password must contain at least one lowercase and one uppercase letter.";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(linkToLogin);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 562);
            panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(364, 110);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(603, 130);
            label6.Name = "label6";
            label6.Size = new Size(69, 17);
            label6.TabIndex = 13;
            label6.Text = "Username";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(606, 198);
            label7.Name = "label7";
            label7.Size = new Size(42, 17);
            label7.TabIndex = 14;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonHighlight;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(606, 268);
            label8.Name = "label8";
            label8.Size = new Size(66, 17);
            label8.TabIndex = 15;
            label8.Text = "Password";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonHighlight;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(606, 335);
            label9.Name = "label9";
            label9.Size = new Size(120, 17);
            label9.TabIndex = 16;
            label9.Text = "Confirm Password";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(984, 561);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnReset);
            Controls.Add(btnRegistration);
            Controls.Add(tbConfirmPassword);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(tbUsername);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private LinkLabel linkToLogin;
        private TextBox tbUsername;
        private TextBox tbEmail;
        private TextBox tbPassword;
        private TextBox tbConfirmPassword;
        private Button btnRegistration;
        private Button btnReset;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}