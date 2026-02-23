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
            DataGridViewCellStyle dgvHeaderStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvAltRowStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvDefaultStyle = new DataGridViewCellStyle();
            Tabs = new TabControl();
            admin = new TabPage();
            AddColumnButton = new Button();
            AddRowButton = new Button();
            RemoveColumnButton = new Button();
            Divider = new Panel();
            panel1 = new Panel();
            dataGridView = new DataGridView();
            user = new TabPage();
            headerPanel = new Panel();
            pictureBox1 = new PictureBox();
            citLbl = new Label();
            titleLbl = new Label();
            studentIdLbl = new Label();
            studentIdTextBox = new TextBox();
            studentNameLabel = new Label();
            studentNameTextBox = new TextBox();
            institutionalEmailLbl = new Label();
            institutionalEmailTextBox = new TextBox();
            fbLinkLabel = new Label();
            facebookLinkTextBox = new TextBox();
            clearButton = new Button();
            submitButton = new Button();
            Tabs.SuspendLayout();
            admin.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            user.SuspendLayout();
            SuspendLayout();
            //
            // Tabs
            //
            Tabs.Controls.Add(admin);
            Tabs.Controls.Add(user);
            Tabs.Dock = DockStyle.Fill;
            Tabs.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Tabs.ItemSize = new Size(120, 48);
            Tabs.Location = new Point(0, 0);
            Tabs.Name = "Tabs";
            Tabs.Padding = new Point(16, 0);
            Tabs.SelectedIndex = 0;
            Tabs.Size = new Size(1920, 991);
            Tabs.TabIndex = 0;
            //
            // admin
            //
            admin.BackColor = Color.White;
            admin.Controls.Add(AddColumnButton);
            admin.Controls.Add(AddRowButton);
            admin.Controls.Add(RemoveColumnButton);
            admin.Controls.Add(Divider);
            admin.Controls.Add(panel1);
            admin.Location = new Point(4, 56);
            admin.Margin = new Padding(0);
            admin.Name = "admin";
            admin.Size = new Size(1912, 931);
            admin.TabIndex = 0;
            admin.Text = "Admin";
            admin.UseVisualStyleBackColor = false;
            //
            // AddColumnButton  (maroon — constructive)
            //
            AddColumnButton.BackColor = Color.FromArgb(120, 0, 30);
            AddColumnButton.FlatStyle = FlatStyle.Flat;
            AddColumnButton.FlatAppearance.BorderColor = Color.FromArgb(80, 0, 20);
            AddColumnButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            AddColumnButton.ForeColor = Color.White;
            AddColumnButton.Location = new Point(20, 18);
            AddColumnButton.Margin = new Padding(0);
            AddColumnButton.Name = "AddColumnButton";
            AddColumnButton.Size = new Size(130, 60);
            AddColumnButton.TabIndex = 0;
            AddColumnButton.Text = "Add Column";
            AddColumnButton.UseVisualStyleBackColor = false;
            AddColumnButton.Click += OpenAddColumn_Click;
            //
            // AddRowButton  (maroon — constructive)
            //
            AddRowButton.BackColor = Color.FromArgb(120, 0, 30);
            AddRowButton.FlatStyle = FlatStyle.Flat;
            AddRowButton.FlatAppearance.BorderColor = Color.FromArgb(80, 0, 20);
            AddRowButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            AddRowButton.ForeColor = Color.White;
            AddRowButton.Location = new Point(166, 18);
            AddRowButton.Margin = new Padding(0);
            AddRowButton.Name = "AddRowButton";
            AddRowButton.Size = new Size(130, 60);
            AddRowButton.TabIndex = 3;
            AddRowButton.Text = "Add Row";
            AddRowButton.UseVisualStyleBackColor = false;
            AddRowButton.Click += AddRow_Click;
            //
            // RemoveColumnButton  (dark red — destructive)
            //
            RemoveColumnButton.BackColor = Color.FromArgb(160, 30, 30);
            RemoveColumnButton.FlatStyle = FlatStyle.Flat;
            RemoveColumnButton.FlatAppearance.BorderColor = Color.FromArgb(120, 20, 20);
            RemoveColumnButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            RemoveColumnButton.ForeColor = Color.White;
            RemoveColumnButton.Location = new Point(312, 18);
            RemoveColumnButton.Margin = new Padding(0);
            RemoveColumnButton.Name = "RemoveColumnButton";
            RemoveColumnButton.Size = new Size(130, 60);
            RemoveColumnButton.TabIndex = 4;
            RemoveColumnButton.Text = "Remove Row";
            RemoveColumnButton.UseVisualStyleBackColor = false;
            RemoveColumnButton.Click += RemoveRow_Click;
            //
            // Divider  (maroon Panel replacing the old dash-string Label)
            //
            Divider.BackColor = Color.FromArgb(120, 0, 30);
            Divider.Location = new Point(0, 96);
            Divider.Name = "Divider";
            Divider.Size = new Size(1912, 3);
            Divider.TabIndex = 1;
            //
            // panel1  (DataGridView container)
            //
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataGridView);
            panel1.Location = new Point(20, 115);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1876, 800);
            panel1.TabIndex = 2;
            //
            // dataGridView
            //
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.EnableHeadersVisualStyles = false;
            dgvHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHeaderStyle.BackColor = Color.FromArgb(120, 0, 30);
            dgvHeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvHeaderStyle.ForeColor = Color.White;
            dgvHeaderStyle.SelectionBackColor = Color.FromArgb(120, 0, 30);
            dgvHeaderStyle.SelectionForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            dgvAltRowStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAltRowStyle.BackColor = Color.FromArgb(255, 245, 248);
            dgvAltRowStyle.ForeColor = Color.Black;
            dgvAltRowStyle.SelectionBackColor = Color.FromArgb(120, 0, 30);
            dgvAltRowStyle.SelectionForeColor = Color.White;
            dataGridView.AlternatingRowsDefaultCellStyle = dgvAltRowStyle;
            dgvDefaultStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDefaultStyle.BackColor = SystemColors.Window;
            dgvDefaultStyle.Font = new Font("Segoe UI", 9F);
            dgvDefaultStyle.ForeColor = SystemColors.ControlText;
            dgvDefaultStyle.SelectionBackColor = Color.FromArgb(120, 0, 30);
            dgvDefaultStyle.SelectionForeColor = Color.White;
            dgvDefaultStyle.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dgvDefaultStyle;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1874, 798);
            dataGridView.TabIndex = 0;
            dataGridView.CellMouseDown += DataGridView_CellMouseDown;
            //
            // user
            //
            user.BackColor = Color.White;
            user.Controls.Add(headerPanel);
            user.Controls.Add(studentIdLbl);
            user.Controls.Add(studentIdTextBox);
            user.Controls.Add(studentNameLabel);
            user.Controls.Add(studentNameTextBox);
            user.Controls.Add(institutionalEmailLbl);
            user.Controls.Add(institutionalEmailTextBox);
            user.Controls.Add(fbLinkLabel);
            user.Controls.Add(facebookLinkTextBox);
            user.Controls.Add(clearButton);
            user.Controls.Add(submitButton);
            user.Location = new Point(4, 56);
            user.Margin = new Padding(0);
            user.Name = "user";
            user.Size = new Size(1912, 931);
            user.TabIndex = 1;
            user.Text = "User";
            user.UseVisualStyleBackColor = false;
            //
            // headerPanel  (maroon branded header bar)
            //
            headerPanel.BackColor = Color.FromArgb(120, 0, 30);
            headerPanel.Controls.Add(pictureBox1);
            headerPanel.Controls.Add(citLbl);
            headerPanel.Controls.Add(titleLbl);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1912, 165);
            headerPanel.TabIndex = 14;
            //
            // pictureBox1  (CIT-U seal, inside headerPanel)
            //
            pictureBox1.Image = Properties.Resources.cit_official_seal__1_;
            pictureBox1.Location = new Point(25, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            //
            // citLbl  (school name, inside headerPanel)
            //
            citLbl.AutoSize = true;
            citLbl.BackColor = Color.Transparent;
            citLbl.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            citLbl.ForeColor = Color.White;
            citLbl.Location = new Point(180, 42);
            citLbl.Name = "citLbl";
            citLbl.TabIndex = 1;
            citLbl.Text = "Cebu Institute of Technology \u2014 University";
            //
            // titleLbl  (system title, inside headerPanel)
            //
            titleLbl.AutoSize = true;
            titleLbl.BackColor = Color.Transparent;
            titleLbl.Font = new Font("Segoe UI", 14F);
            titleLbl.ForeColor = Color.FromArgb(255, 215, 100);
            titleLbl.Location = new Point(180, 95);
            titleLbl.Name = "titleLbl";
            titleLbl.TabIndex = 2;
            titleLbl.Text = "Student Management System";
            //
            // studentIdLbl
            //
            studentIdLbl.AutoSize = true;
            studentIdLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            studentIdLbl.ForeColor = Color.FromArgb(120, 0, 30);
            studentIdLbl.Location = new Point(616, 185);
            studentIdLbl.Name = "studentIdLbl";
            studentIdLbl.TabIndex = 1;
            studentIdLbl.Text = "Student ID:";
            //
            // studentIdTextBox
            //
            studentIdTextBox.Font = new Font("Segoe UI", 12F);
            studentIdTextBox.Location = new Point(616, 219);
            studentIdTextBox.Name = "studentIdTextBox";
            studentIdTextBox.PlaceholderText = "(ex. 24-4339-705)";
            studentIdTextBox.Size = new Size(680, 34);
            studentIdTextBox.TabIndex = 2;
            studentIdTextBox.WordWrap = false;
            //
            // studentNameLabel
            //
            studentNameLabel.AutoSize = true;
            studentNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            studentNameLabel.ForeColor = Color.FromArgb(120, 0, 30);
            studentNameLabel.Location = new Point(616, 305);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.TabIndex = 3;
            studentNameLabel.Text = "Student Name:";
            //
            // studentNameTextBox
            //
            studentNameTextBox.Font = new Font("Segoe UI", 12F);
            studentNameTextBox.Location = new Point(616, 339);
            studentNameTextBox.Name = "studentNameTextBox";
            studentNameTextBox.PlaceholderText = "(ex. Tabotabo, Adrian Seth M.)";
            studentNameTextBox.Size = new Size(680, 34);
            studentNameTextBox.TabIndex = 4;
            studentNameTextBox.WordWrap = false;
            //
            // institutionalEmailLbl
            //
            institutionalEmailLbl.AutoSize = true;
            institutionalEmailLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            institutionalEmailLbl.ForeColor = Color.FromArgb(120, 0, 30);
            institutionalEmailLbl.Location = new Point(616, 425);
            institutionalEmailLbl.Name = "institutionalEmailLbl";
            institutionalEmailLbl.TabIndex = 5;
            institutionalEmailLbl.Text = "Institutional Email:";
            //
            // institutionalEmailTextBox
            //
            institutionalEmailTextBox.Font = new Font("Segoe UI", 12F);
            institutionalEmailTextBox.Location = new Point(616, 459);
            institutionalEmailTextBox.Name = "institutionalEmailTextBox";
            institutionalEmailTextBox.PlaceholderText = "(ex. adrianseth.tabotabo@cit.edu)";
            institutionalEmailTextBox.Size = new Size(680, 34);
            institutionalEmailTextBox.TabIndex = 6;
            institutionalEmailTextBox.WordWrap = false;
            //
            // fbLinkLabel
            //
            fbLinkLabel.AutoSize = true;
            fbLinkLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            fbLinkLabel.ForeColor = Color.FromArgb(120, 0, 30);
            fbLinkLabel.Location = new Point(616, 545);
            fbLinkLabel.Name = "fbLinkLabel";
            fbLinkLabel.TabIndex = 7;
            fbLinkLabel.Text = "Facebook Link:";
            //
            // facebookLinkTextBox
            //
            facebookLinkTextBox.Font = new Font("Segoe UI", 12F);
            facebookLinkTextBox.Location = new Point(616, 579);
            facebookLinkTextBox.Name = "facebookLinkTextBox";
            facebookLinkTextBox.PlaceholderText = "(ex. https://facebook.com/dreeyanzz)";
            facebookLinkTextBox.Size = new Size(680, 34);
            facebookLinkTextBox.TabIndex = 8;
            facebookLinkTextBox.WordWrap = false;
            //
            // clearButton  (secondary — outlined maroon)
            //
            clearButton.BackColor = Color.White;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.FlatAppearance.BorderColor = Color.FromArgb(120, 0, 30);
            clearButton.FlatAppearance.BorderSize = 2;
            clearButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            clearButton.ForeColor = Color.FromArgb(120, 0, 30);
            clearButton.Location = new Point(741, 650);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(200, 55);
            clearButton.TabIndex = 9;
            clearButton.Text = "Clear Inputs";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            //
            // submitButton  (primary — filled maroon)
            //
            submitButton.BackColor = Color.FromArgb(120, 0, 30);
            submitButton.FlatStyle = FlatStyle.Flat;
            submitButton.FlatAppearance.BorderColor = Color.FromArgb(80, 0, 20);
            submitButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            submitButton.ForeColor = Color.White;
            submitButton.Location = new Point(971, 650);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(200, 55);
            submitButton.TabIndex = 10;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += SubmitButton_Click;
            //
            // Window
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 991);
            Controls.Add(Tabs);
            Name = "Window";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Management System";
            WindowState = FormWindowState.Maximized;
            Tabs.ResumeLayout(false);
            admin.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            user.ResumeLayout(false);
            user.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Tabs;
        private TabPage admin;
        private TabPage user;
        private Button AddColumnButton;
        private Button AddRowButton;
        private Button RemoveColumnButton;
        private Panel Divider;
        private Panel panel1;
        private DataGridView dataGridView;
        private Panel headerPanel;
        private PictureBox pictureBox1;
        private Label citLbl;
        private Label titleLbl;
        private Label studentIdLbl;
        private TextBox studentIdTextBox;
        private Label studentNameLabel;
        private TextBox studentNameTextBox;
        private Label institutionalEmailLbl;
        private TextBox institutionalEmailTextBox;
        private Label fbLinkLabel;
        private TextBox facebookLinkTextBox;
        private Button clearButton;
        private Button submitButton;
    }
}
