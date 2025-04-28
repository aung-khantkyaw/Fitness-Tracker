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
            rBtnFemale = new RadioButton();
            rBtnMale = new RadioButton();
            label11 = new Label();
            label10 = new Label();
            tbAge = new TextBox();
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
            panelGoal = new Panel();
            label17 = new Label();
            label15 = new Label();
            label16 = new Label();
            label14 = new Label();
            labelGole = new Label();
            label13 = new Label();
            labelBurn = new Label();
            labelEnd = new Label();
            labelStart = new Label();
            labelId = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panelGoal.SuspendLayout();
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
            btnActivity.Click += btnActivity_Click;
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
            panel2.Controls.Add(panelGoal);
            panel2.Controls.Add(rBtnFemale);
            panel2.Controls.Add(rBtnMale);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(tbAge);
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
            panel2.Paint += panel2_Paint;
            // 
            // rBtnFemale
            // 
            rBtnFemale.AutoSize = true;
            rBtnFemale.Enabled = false;
            rBtnFemale.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            rBtnFemale.Location = new Point(161, 260);
            rBtnFemale.Name = "rBtnFemale";
            rBtnFemale.Size = new Size(70, 21);
            rBtnFemale.TabIndex = 17;
            rBtnFemale.TabStop = true;
            rBtnFemale.Text = "Female";
            rBtnFemale.UseVisualStyleBackColor = true;
            // 
            // rBtnMale
            // 
            rBtnMale.AutoSize = true;
            rBtnMale.Enabled = false;
            rBtnMale.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            rBtnMale.Location = new Point(44, 260);
            rBtnMale.Name = "rBtnMale";
            rBtnMale.Size = new Size(56, 21);
            rBtnMale.TabIndex = 16;
            rBtnMale.TabStop = true;
            rBtnMale.Text = "Male";
            rBtnMale.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label11.Location = new Point(45, 229);
            label11.Name = "label11";
            label11.Size = new Size(52, 17);
            label11.TabIndex = 15;
            label11.Text = "Gender";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label10.Location = new Point(45, 172);
            label10.Name = "label10";
            label10.Size = new Size(32, 17);
            label10.TabIndex = 14;
            label10.Text = "Age";
            // 
            // tbAge
            // 
            tbAge.Enabled = false;
            tbAge.Location = new Point(45, 192);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(179, 23);
            tbAge.TabIndex = 13;
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
            label8.Location = new Point(194, 373);
            label8.Name = "label8";
            label8.Size = new Size(30, 20);
            label8.TabIndex = 11;
            label8.Text = "cm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.Location = new Point(198, 314);
            label7.Name = "label7";
            label7.Size = new Size(26, 20);
            label7.TabIndex = 10;
            label7.Text = "kg";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(45, 350);
            label6.Name = "label6";
            label6.Size = new Size(50, 17);
            label6.TabIndex = 9;
            label6.Text = "Height";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(45, 291);
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
            btnReset.Location = new Point(141, 413);
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
            btnUpdate.Location = new Point(45, 413);
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
            tbHeight.Location = new Point(45, 370);
            tbHeight.Name = "tbHeight";
            tbHeight.Size = new Size(147, 23);
            tbHeight.TabIndex = 3;
            // 
            // tbWeight
            // 
            tbWeight.Enabled = false;
            tbWeight.Location = new Point(45, 311);
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
            // panelGoal
            // 
            panelGoal.Controls.Add(label17);
            panelGoal.Controls.Add(label15);
            panelGoal.Controls.Add(label16);
            panelGoal.Controls.Add(label14);
            panelGoal.Controls.Add(labelGole);
            panelGoal.Controls.Add(label13);
            panelGoal.Controls.Add(labelBurn);
            panelGoal.Controls.Add(labelEnd);
            panelGoal.Controls.Add(labelStart);
            panelGoal.Controls.Add(labelId);
            panelGoal.Controls.Add(label12);
            panelGoal.Location = new Point(396, 3);
            panelGoal.Name = "panelGoal";
            panelGoal.Size = new Size(286, 331);
            panelGoal.TabIndex = 18;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9.75F);
            label17.Location = new Point(203, 208);
            label17.Name = "label17";
            label17.Size = new Size(50, 17);
            label17.TabIndex = 38;
            label17.Text = "label17";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F);
            label15.Location = new Point(203, 169);
            label15.Name = "label15";
            label15.Size = new Size(50, 17);
            label15.TabIndex = 37;
            label15.Text = "label15";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9.75F);
            label16.Location = new Point(203, 130);
            label16.Name = "label16";
            label16.Size = new Size(50, 17);
            label16.TabIndex = 36;
            label16.Text = "label16";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F);
            label14.Location = new Point(203, 90);
            label14.Name = "label14";
            label14.Size = new Size(50, 17);
            label14.TabIndex = 35;
            label14.Text = "label14";
            // 
            // labelGole
            // 
            labelGole.AutoSize = true;
            labelGole.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelGole.Location = new Point(24, 90);
            labelGole.Name = "labelGole";
            labelGole.Size = new Size(109, 17);
            labelGole.TabIndex = 34;
            labelGole.Text = "Calories To Burn";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F);
            label13.Location = new Point(203, 54);
            label13.Name = "label13";
            label13.Size = new Size(50, 17);
            label13.TabIndex = 33;
            label13.Text = "label13";
            // 
            // labelBurn
            // 
            labelBurn.AutoSize = true;
            labelBurn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelBurn.Location = new Point(24, 208);
            labelBurn.Name = "labelBurn";
            labelBurn.Size = new Size(140, 17);
            labelBurn.TabIndex = 32;
            labelBurn.Text = "Total Calories Burned";
            // 
            // labelEnd
            // 
            labelEnd.AutoSize = true;
            labelEnd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelEnd.Location = new Point(24, 169);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(64, 17);
            labelEnd.TabIndex = 31;
            labelEnd.Text = "End Date";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelStart.Location = new Point(24, 130);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(70, 17);
            labelStart.TabIndex = 30;
            labelStart.Text = "Start Date";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelId.Location = new Point(24, 54);
            labelId.Name = "labelId";
            labelId.Size = new Size(52, 17);
            labelId.TabIndex = 29;
            labelId.Text = "Goal Id";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.Location = new Point(24, 13);
            label12.Name = "label12";
            label12.Size = new Size(97, 21);
            label12.TabIndex = 28;
            label12.Text = "Active Goal";
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
            panelGoal.ResumeLayout(false);
            panelGoal.PerformLayout();
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
        private RadioButton rBtnFemale;
        private RadioButton rBtnMale;
        private Label label11;
        private Label label10;
        private TextBox tbAge;
        private Panel panelGoal;
        private Label label17;
        private Label label15;
        private Label label16;
        private Label label14;
        private Label labelGole;
        private Label label13;
        private Label labelBurn;
        private Label labelEnd;
        private Label labelStart;
        private Label labelId;
        private Label label12;
    }
}