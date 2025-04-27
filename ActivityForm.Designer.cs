namespace Fitness_Tracker
{
    partial class ActivityForm
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
            label1 = new Label();
            btnGoal = new Button();
            tbId = new TextBox();
            btnCreate = new Button();
            dataGridViewActivity = new DataGridView();
            label5 = new Label();
            btnLogout = new Button();
            btnActivity = new Button();
            panel2 = new Panel();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            tbThree = new TextBox();
            tbTwo = new TextBox();
            tbOne = new TextBox();
            label2 = new Label();
            cbType = new ComboBox();
            panel1 = new Panel();
            monthCalendar1 = new MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)dataGridViewActivity).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
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
            // tbId
            // 
            tbId.Location = new Point(132, 16);
            tbId.Name = "tbId";
            tbId.Size = new Size(100, 23);
            tbId.TabIndex = 12;
            tbId.Visible = false;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCreate.Location = new Point(285, 232);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(100, 30);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dataGridViewActivity
            // 
            dataGridViewActivity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewActivity.Location = new Point(3, 268);
            dataGridViewActivity.Name = "dataGridViewActivity";
            dataGridViewActivity.Size = new Size(716, 264);
            dataGridViewActivity.TabIndex = 8;
            dataGridViewActivity.CellClick += dataGridViewActivity_CellClick;
            dataGridViewActivity.CellContentClick += dataGridViewActivity_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 16);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 6;
            label5.Text = "Set Activity";
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
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(tbThree);
            panel2.Controls.Add(tbTwo);
            panel2.Controls.Add(tbOne);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cbType);
            panel2.Controls.Add(tbId);
            panel2.Controls.Add(btnCreate);
            panel2.Controls.Add(dataGridViewActivity);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(250, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(724, 537);
            panel2.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(34, 219);
            label6.Name = "label6";
            label6.Size = new Size(86, 17);
            label6.TabIndex = 21;
            label6.Text = "Metric Three";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 162);
            label4.Name = "label4";
            label4.Size = new Size(76, 17);
            label4.TabIndex = 20;
            label4.Text = "Metric Two";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 108);
            label3.Name = "label3";
            label3.Size = new Size(76, 17);
            label3.TabIndex = 19;
            label3.Text = "Metric One";
            // 
            // tbThree
            // 
            tbThree.Location = new Point(32, 239);
            tbThree.Name = "tbThree";
            tbThree.Size = new Size(200, 23);
            tbThree.TabIndex = 18;
            // 
            // tbTwo
            // 
            tbTwo.Location = new Point(32, 182);
            tbTwo.Name = "tbTwo";
            tbTwo.Size = new Size(200, 23);
            tbTwo.TabIndex = 17;
            // 
            // tbOne
            // 
            tbOne.Location = new Point(32, 128);
            tbOne.Name = "tbOne";
            tbOne.Size = new Size(200, 23);
            tbOne.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 57);
            label2.Name = "label2";
            label2.Size = new Size(88, 17);
            label2.TabIndex = 15;
            label2.Text = "Activity Type";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(32, 77);
            cbType.Name = "cbType";
            cbType.Size = new Size(200, 23);
            cbType.TabIndex = 14;
            cbType.SelectedIndexChanged += cbType_SelectedIndexChanged;
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
            panel1.TabIndex = 11;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(11, 252);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 13;
            // 
            // ActivityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(monthCalendar1);
            Name = "ActivityForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ActivityForm";
            Load += ActivityForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewActivity).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnProfile;
        private Label label1;
        private Button btnGoal;
        private TextBox tbId;
        private Button btnCreate;
        private DataGridView dataGridViewActivity;
        private Label label5;
        private Button btnLogout;
        private Button btnActivity;
        private Panel panel2;
        private Panel panel1;
        private MonthCalendar monthCalendar1;
        private Label label2;
        private ComboBox cbType;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox tbThree;
        private TextBox tbTwo;
        private TextBox tbOne;
    }
}