namespace Fitness_Tracker
{
    partial class GoalForm
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
            monthCalendar1 = new MonthCalendar();
            panel2 = new Panel();
            tbId = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnCreate = new Button();
            dataGridViewGoal = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtpEnd = new DateTimePicker();
            dtpStart = new DateTimePicker();
            tbCalBurn = new TextBox();
            panel1 = new Panel();
            btnLogout = new Button();
            btnProfile = new Button();
            label1 = new Label();
            btnActivity = new Button();
            btnGoal = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGoal).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(11, 252);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tbId);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnCreate);
            panel2.Controls.Add(dataGridViewGoal);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dtpEnd);
            panel2.Controls.Add(dtpStart);
            panel2.Controls.Add(tbCalBurn);
            panel2.Location = new Point(250, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(724, 537);
            panel2.TabIndex = 9;
            // 
            // tbId
            // 
            tbId.Location = new Point(132, 16);
            tbId.Name = "tbId";
            tbId.Size = new Size(100, 23);
            tbId.TabIndex = 12;
            tbId.Visible = false;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnDelete.Location = new Point(587, 188);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnUpdate.Location = new Point(452, 188);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 30);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCreate.Location = new Point(320, 188);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(100, 30);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dataGridViewGoal
            // 
            dataGridViewGoal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGoal.Location = new Point(3, 239);
            dataGridViewGoal.Name = "dataGridViewGoal";
            dataGridViewGoal.Size = new Size(716, 293);
            dataGridViewGoal.TabIndex = 8;
            dataGridViewGoal.CellClick += dataGridViewGoal_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(204, 82);
            label6.Name = "label6";
            label6.Size = new Size(28, 20);
            label6.TabIndex = 7;
            label6.Text = "cal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 16);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 6;
            label5.Text = "Set Goal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 171);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 5;
            label4.Text = "End Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 115);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 4;
            label3.Text = "Start Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 59);
            label2.Name = "label2";
            label2.Size = new Size(107, 17);
            label2.TabIndex = 3;
            label2.Text = "Calories to Burn";
            // 
            // dtpEnd
            // 
            dtpEnd.CustomFormat = "M/d/yyyy";
            dtpEnd.Location = new Point(32, 191);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(200, 23);
            dtpEnd.TabIndex = 2;
            // 
            // dtpStart
            // 
            dtpStart.CustomFormat = "M/d/yyyy";
            dtpStart.Location = new Point(32, 135);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(200, 23);
            dtpStart.TabIndex = 1;
            // 
            // tbCalBurn
            // 
            tbCalBurn.Location = new Point(32, 79);
            tbCalBurn.Name = "tbCalBurn";
            tbCalBurn.Size = new Size(149, 23);
            tbCalBurn.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnProfile);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnActivity);
            panel1.Controls.Add(btnGoal);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 228);
            panel1.TabIndex = 8;
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
            // GoalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(monthCalendar1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "GoalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Goal";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGoal).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MonthCalendar monthCalendar1;
        private Panel panel2;
        private Panel panel1;
        private Button btnLogout;
        private Button btnProfile;
        private Label label1;
        private Button btnActivity;
        private Button btnGoal;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpStart;
        private TextBox tbCalBurn;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCreate;
        private DataGridView dataGridViewGoal;
        private TextBox tbId;
    }
}