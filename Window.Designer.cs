namespace week_5_assignment
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            Tabs = new TabControl();
            admin = new TabPage();
            RemoveColumnButton = new Button();
            AddRowButton = new Button();
            panel1 = new Panel();
            dataGridView = new DataGridView();
            Divider = new Label();
            AddColumnButton = new Button();
            user = new TabPage();
            titleLbl = new Label();
            citLbl = new Label();
            pictureBox1 = new PictureBox();
            submitButton = new Button();
            clearButton = new Button();
            textBox2 = new TextBox();
            fbLinkLabel = new Label();
            textBox1 = new TextBox();
            institutionalEmailLbl = new Label();
            studentNameTextBox = new TextBox();
            studentNameLabel = new Label();
            studentIdTextBox = new TextBox();
            studentIdLbl = new Label();
            Tabs.SuspendLayout();
            admin.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Tabs
            // 
            Tabs.Controls.Add(admin);
            Tabs.Controls.Add(user);
            Tabs.Dock = DockStyle.Top;
            Tabs.ItemSize = new Size(100, 50);
            Tabs.Location = new Point(0, 0);
            Tabs.Name = "Tabs";
            Tabs.Padding = new Point(0, 0);
            Tabs.SelectedIndex = 0;
            Tabs.Size = new Size(1920, 991);
            Tabs.TabIndex = 0;
            // 
            // admin
            // 
            admin.Controls.Add(RemoveColumnButton);
            admin.Controls.Add(AddRowButton);
            admin.Controls.Add(panel1);
            admin.Controls.Add(Divider);
            admin.Controls.Add(AddColumnButton);
            admin.Location = new Point(4, 54);
            admin.Margin = new Padding(0);
            admin.Name = "admin";
            admin.Size = new Size(1912, 933);
            admin.TabIndex = 0;
            admin.Text = "Admin";
            admin.UseVisualStyleBackColor = true;
            // 
            // RemoveColumnButton
            // 
            RemoveColumnButton.Location = new Point(312, 20);
            RemoveColumnButton.Margin = new Padding(0);
            RemoveColumnButton.Name = "RemoveColumnButton";
            RemoveColumnButton.Size = new Size(126, 68);
            RemoveColumnButton.TabIndex = 4;
            RemoveColumnButton.Text = "Remove Row";
            RemoveColumnButton.UseVisualStyleBackColor = true;
            // 
            // AddRowButton
            // 
            AddRowButton.Location = new Point(166, 20);
            AddRowButton.Margin = new Padding(0);
            AddRowButton.Name = "AddRowButton";
            AddRowButton.Size = new Size(126, 68);
            AddRowButton.TabIndex = 3;
            AddRowButton.Text = "Add Row";
            AddRowButton.UseVisualStyleBackColor = true;
            AddRowButton.Click += AddRow_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataGridView);
            panel1.Location = new Point(20, 121);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1876, 797);
            panel1.TabIndex = 2;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Lime;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1874, 795);
            dataGridView.TabIndex = 0;
            dataGridView.CellMouseDown += DataGridView_CellMouseDown;
            // 
            // Divider
            // 
            Divider.AutoSize = true;
            Divider.Location = new Point(-4, 88);
            Divider.Name = "Divider";
            Divider.Size = new Size(12087, 20);
            Divider.TabIndex = 1;
            Divider.Text = resources.GetString("Divider.Text");
            // 
            // AddColumnButton
            // 
            AddColumnButton.Location = new Point(20, 20);
            AddColumnButton.Margin = new Padding(0);
            AddColumnButton.Name = "AddColumnButton";
            AddColumnButton.Size = new Size(126, 68);
            AddColumnButton.TabIndex = 0;
            AddColumnButton.Text = "Add Column";
            AddColumnButton.UseVisualStyleBackColor = true;
            AddColumnButton.Click += OpenAddColumn_Click;
            // 
            // user
            // 
            user.Controls.Add(titleLbl);
            user.Controls.Add(citLbl);
            user.Controls.Add(pictureBox1);
            user.Controls.Add(submitButton);
            user.Controls.Add(clearButton);
            user.Controls.Add(textBox2);
            user.Controls.Add(fbLinkLabel);
            user.Controls.Add(textBox1);
            user.Controls.Add(institutionalEmailLbl);
            user.Controls.Add(studentNameTextBox);
            user.Controls.Add(studentNameLabel);
            user.Controls.Add(studentIdTextBox);
            user.Controls.Add(studentIdLbl);
            user.Location = new Point(4, 54);
            user.Margin = new Padding(0);
            user.Name = "user";
            user.Size = new Size(1912, 933);
            user.TabIndex = 1;
            user.Text = "User";
            user.UseVisualStyleBackColor = true;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            titleLbl.Location = new Point(1078, 556);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(606, 57);
            titleLbl.TabIndex = 13;
            titleLbl.Text = "Student Management System";
            // 
            // citLbl
            // 
            citLbl.AutoSize = true;
            citLbl.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            citLbl.Location = new Point(941, 499);
            citLbl.Name = "citLbl";
            citLbl.Size = new Size(850, 57);
            citLbl.TabIndex = 12;
            citLbl.Text = "Cebu Institute of Technology -- University";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cit_official_seal__1_;
            pictureBox1.Location = new Point(1212, 167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // submitButton
            // 
            submitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitButton.Location = new Point(1035, 824);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(291, 73);
            submitButton.TabIndex = 10;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearButton.Location = new Point(689, 824);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(291, 73);
            clearButton.TabIndex = 9;
            clearButton.Text = "Clear Inputs";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(138, 629);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "(ex. https://facebook.com/dreeyanzz)";
            textBox2.Size = new Size(631, 34);
            textBox2.TabIndex = 8;
            textBox2.WordWrap = false;
            // 
            // fbLinkLabel
            // 
            fbLinkLabel.AutoSize = true;
            fbLinkLabel.Font = new Font("Segoe UI", 16F);
            fbLinkLabel.Location = new Point(127, 579);
            fbLinkLabel.Name = "fbLinkLabel";
            fbLinkLabel.Size = new Size(191, 37);
            fbLinkLabel.TabIndex = 7;
            fbLinkLabel.Text = "Facebook Link:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(138, 475);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "(ex. adrianseth.tabotabo@cit.edu)";
            textBox1.Size = new Size(631, 34);
            textBox1.TabIndex = 6;
            textBox1.WordWrap = false;
            // 
            // institutionalEmailLbl
            // 
            institutionalEmailLbl.AutoSize = true;
            institutionalEmailLbl.Font = new Font("Segoe UI", 16F);
            institutionalEmailLbl.Location = new Point(127, 425);
            institutionalEmailLbl.Name = "institutionalEmailLbl";
            institutionalEmailLbl.Size = new Size(236, 37);
            institutionalEmailLbl.TabIndex = 5;
            institutionalEmailLbl.Text = "Institutional Email:";
            // 
            // studentNameTextBox
            // 
            studentNameTextBox.Font = new Font("Segoe UI", 12F);
            studentNameTextBox.Location = new Point(138, 321);
            studentNameTextBox.Name = "studentNameTextBox";
            studentNameTextBox.PlaceholderText = "(ex. Tabotabo, Adrian Seth M.)";
            studentNameTextBox.Size = new Size(631, 34);
            studentNameTextBox.TabIndex = 4;
            studentNameTextBox.WordWrap = false;
            // 
            // studentNameLabel
            // 
            studentNameLabel.AutoSize = true;
            studentNameLabel.Font = new Font("Segoe UI", 16F);
            studentNameLabel.Location = new Point(127, 271);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Size = new Size(192, 37);
            studentNameLabel.TabIndex = 3;
            studentNameLabel.Text = "Student Name:";
            // 
            // studentIdTextBox
            // 
            studentIdTextBox.Font = new Font("Segoe UI", 12F);
            studentIdTextBox.Location = new Point(138, 167);
            studentIdTextBox.Name = "studentIdTextBox";
            studentIdTextBox.PlaceholderText = "(ex. 24-4339-705)";
            studentIdTextBox.Size = new Size(631, 34);
            studentIdTextBox.TabIndex = 2;
            studentIdTextBox.WordWrap = false;
            // 
            // studentIdLbl
            // 
            studentIdLbl.AutoSize = true;
            studentIdLbl.Font = new Font("Segoe UI", 16F);
            studentIdLbl.Location = new Point(127, 117);
            studentIdLbl.Name = "studentIdLbl";
            studentIdLbl.Size = new Size(147, 37);
            studentIdLbl.TabIndex = 1;
            studentIdLbl.Text = "Student ID:";
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 991);
            Controls.Add(Tabs);
            Name = "Window";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Database Table UI";
            WindowState = FormWindowState.Maximized;
            Tabs.ResumeLayout(false);
            admin.ResumeLayout(false);
            admin.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            user.ResumeLayout(false);
            user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Tabs;
        private TabPage admin;
        private TabPage user;
        private Button AddColumnButton;
        private Label Divider;
        private Panel panel1;
        private DataGridView dataGridView;
        private Button AddRowButton;
        private Button RemoveColumnButton;
        private TextBox studentIdTextBox;
        private Label studentIdLbl;
        private TextBox textBox1;
        private Label institutionalEmailLbl;
        private TextBox studentNameTextBox;
        private Label studentNameLabel;
        private TextBox textBox2;
        private Label fbLinkLabel;
        private Button clearButton;
        private Button submitButton;
        private PictureBox pictureBox1;
        private Label citLbl;
        private Label titleLbl;
    }
}
