namespace Fitness_Tracker
{
    partial class Profile
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
            btnProfile = new Button();
            btnActivity = new Button();
            btnGoal = new Button();
            panel1 = new Panel();
            btnLogout = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnReset = new Button();
            btnUpdate = new Button();
            tbHeight = new TextBox();
            tbWeight = new TextBox();
            tbEmail = new TextBox();
            tbUsername = new TextBox();
            monthCalendar1 = new MonthCalendar();
            label2 = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnProfile
            // 
            btnProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfile.Location = new Point(35, 68);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(154, 32);
            btnProfile.TabIndex = 0;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnActivity
            // 
            btnActivity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActivity.Location = new Point(35, 144);
            btnActivity.Name = "btnActivity";
            btnActivity.Size = new Size(154, 32);
            btnActivity.TabIndex = 2;
            btnActivity.Text = "Activity";
            btnActivity.UseVisualStyleBackColor = true;
            // 
            // btnGoal
            // 
            btnGoal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoal.Location = new Point(35, 106);
            btnGoal.Name = "btnGoal";
            btnGoal.Size = new Size(154, 32);
            btnGoal.TabIndex = 1;
            btnGoal.Text = "Goal";
            btnGoal.UseVisualStyleBackColor = true;
            btnGoal.Click += btnGoal_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnProfile);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnActivity);
            panel1.Controls.Add(btnGoal);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 228);
            panel1.TabIndex = 4;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(35, 182);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(154, 32);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 16);
            label1.Name = "label1";
            label1.Size = new Size(154, 37);
            label1.TabIndex = 3;
            label1.Text = "Fit Track";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(tbHeight);
            panel2.Controls.Add(tbWeight);
            panel2.Controls.Add(tbEmail);
            panel2.Controls.Add(tbUsername);
            panel2.Location = new Point(251, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(724, 537);
            panel2.TabIndex = 5;
            panel2.Click += Profile_Load;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(45, 16);
            label9.Name = "label9";
            label9.Size = new Size(123, 21);
            label9.TabIndex = 12;
            label9.Text = "Account Detail";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label8.Location = new Point(194, 253);
            label8.Name = "label8";
            label8.Size = new Size(30, 20);
            label8.TabIndex = 11;
            label8.Text = "cm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.Location = new Point(198, 194);
            label7.Name = "label7";
            label7.Size = new Size(26, 20);
            label7.TabIndex = 10;
            label7.Text = "kg";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(45, 230);
            label6.Name = "label6";
            label6.Size = new Size(50, 17);
            label6.TabIndex = 9;
            label6.Text = "Height";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(45, 171);
            label5.Name = "label5";
            label5.Size = new Size(53, 17);
            label5.TabIndex = 8;
            label5.Text = "Weight";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(45, 113);
            label4.Name = "label4";
            label4.Size = new Size(42, 17);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(45, 57);
            label3.Name = "label3";
            label3.Size = new Size(69, 17);
            label3.TabIndex = 6;
            label3.Text = "Username";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(141, 294);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(83, 23);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Visible = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(45, 294);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(83, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Visible = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbHeight
            // 
            tbHeight.Enabled = false;
            tbHeight.Location = new Point(45, 250);
            tbHeight.Name = "tbHeight";
            tbHeight.Size = new Size(147, 23);
            tbHeight.TabIndex = 3;
            // 
            // tbWeight
            // 
            tbWeight.Enabled = false;
            tbWeight.Location = new Point(45, 191);
            tbWeight.Name = "tbWeight";
            tbWeight.Size = new Size(147, 23);
            tbWeight.TabIndex = 2;
            // 
            // tbEmail
            // 
            tbEmail.Enabled = false;
            tbEmail.Location = new Point(45, 133);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(179, 23);
            tbEmail.TabIndex = 1;
            // 
            // tbUsername
            // 
            tbUsername.Enabled = false;
            tbUsername.Location = new Point(45, 77);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(179, 23);
            tbUsername.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(12, 252);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 10);
            label2.Name = "label2";
            label2.Size = new Size(169, 21);
            label2.TabIndex = 9;
            label2.Text = "Accont Management";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(29, 81);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(169, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(29, 46);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(169, 29);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(btnDelete);
            panel3.Location = new Point(12, 426);
            panel3.Name = "panel3";
            panel3.Size = new Size(227, 123);
            panel3.TabIndex = 7;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(984, 561);
            Controls.Add(panel3);
            Controls.Add(monthCalendar1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            Load += Profile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnProfile;
        private Button btnActivity;
        private Button btnGoal;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btnLogout;
        private MonthCalendar monthCalendar1;
        private TextBox tbWeight;
        private TextBox tbEmail;
        private TextBox tbUsername;
        private TextBox tbHeight;
        private Button btnReset;
        private Button btnUpdate;
        private Label label2;
        private Button btnDelete;
        private Button btnEdit;
        private Panel panel3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label9;
    }
}