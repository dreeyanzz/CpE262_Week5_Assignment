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
            components = new System.ComponentModel.Container();
            adminToolTip = new ToolTip(components);

            // Styles for dataGridView (DataTable tab)
            DataGridViewCellStyle dgvHeaderStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvAltRowStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvDefaultStyle = new DataGridViewCellStyle();

            // Styles for listDataGridView (List tab)
            DataGridViewCellStyle listHeaderStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle listAltRowStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle listDefaultStyle = new DataGridViewCellStyle();

            Tabs = new TabControl();
            admin = new TabPage();
            AddColumnButton = new Button();
            AddRowButton = new Button();
            RemoveColumnButton = new Button();
            adminExportButton = new Button();
            adminImportButton = new Button();
            Divider = new Panel();
            panel1 = new Panel();
            dataGridView = new DataGridView();
            user = new TabPage();
            headerPanel = new Panel();
            pictureBox1 = new PictureBox();
            citLbl = new Label();
            titleLbl = new Label();
            formCard = new Panel();
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
            listTab = new TabPage();
            listRemoveButton = new Button();
            listExportButton = new Button();
            listImportButton = new Button();
            listDivider = new Panel();
            listFormCard = new Panel();
            listIdLbl = new Label();
            listIdTextBox = new TextBox();
            listNameLbl = new Label();
            listNameTextBox = new TextBox();
            listEmailLbl = new Label();
            listEmailTextBox = new TextBox();
            listFbLinkLbl = new Label();
            listFbLinkTextBox = new TextBox();
            listClearButton = new Button();
            listAddButton = new Button();
            listGridPanel = new Panel();
            listDataGridView = new DataGridView();

            Tabs.SuspendLayout();
            admin.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            formCard.SuspendLayout();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            user.SuspendLayout();
            listTab.SuspendLayout();
            listFormCard.SuspendLayout();
            listGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listDataGridView).BeginInit();
            SuspendLayout();
            //
            // Tabs
            //
            Tabs.Controls.Add(admin);
            Tabs.Controls.Add(user);
            Tabs.Controls.Add(listTab);
            Tabs.Dock = DockStyle.Fill;
            Tabs.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Tabs.ItemSize = new Size(120, 48);
            Tabs.Location = new Point(0, 0);
            Tabs.Name = "Tabs";
            Tabs.Padding = new Point(16, 0);
            Tabs.SelectedIndex = 0;
            Tabs.Size = new Size(1920, 991);
            Tabs.TabIndex = 0;
            Tabs.SelectedIndexChanged += Tabs_SelectedIndexChanged;
            //
            // admin
            //
            admin.BackColor = Color.White;
            admin.Controls.Add(AddColumnButton);
            admin.Controls.Add(AddRowButton);
            admin.Controls.Add(RemoveColumnButton);
            admin.Controls.Add(adminExportButton);
            admin.Controls.Add(adminImportButton);
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
            adminToolTip.SetToolTip(AddColumnButton, "Add a new column to the table");
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
            adminToolTip.SetToolTip(AddRowButton, "Add a blank row to the table");
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
            adminToolTip.SetToolTip(RemoveColumnButton, "Remove all selected rows (with confirmation)");
            //
            // adminExportButton  (maroon — export action)
            //
            adminExportButton.BackColor = Color.FromArgb(120, 0, 30);
            adminExportButton.FlatStyle = FlatStyle.Flat;
            adminExportButton.FlatAppearance.BorderColor = Color.FromArgb(80, 0, 20);
            adminExportButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            adminExportButton.ForeColor = Color.White;
            adminExportButton.Location = new Point(458, 18);
            adminExportButton.Margin = new Padding(0);
            adminExportButton.Name = "adminExportButton";
            adminExportButton.Size = new Size(130, 60);
            adminExportButton.TabIndex = 5;
            adminExportButton.Text = "Export";
            adminExportButton.UseVisualStyleBackColor = false;
            adminExportButton.Click += AdminExportButton_Click;
            adminToolTip.SetToolTip(adminExportButton, "Export table data to CSV or JSON");
            //
            // adminImportButton  (outlined maroon — import action)
            //
            adminImportButton.BackColor = Color.White;
            adminImportButton.FlatStyle = FlatStyle.Flat;
            adminImportButton.FlatAppearance.BorderColor = Color.FromArgb(120, 0, 30);
            adminImportButton.FlatAppearance.BorderSize = 2;
            adminImportButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            adminImportButton.ForeColor = Color.FromArgb(120, 0, 30);
            adminImportButton.Location = new Point(604, 18);
            adminImportButton.Margin = new Padding(0);
            adminImportButton.Name = "adminImportButton";
            adminImportButton.Size = new Size(130, 60);
            adminImportButton.TabIndex = 6;
            adminImportButton.Text = "Import";
            adminImportButton.UseVisualStyleBackColor = false;
            adminImportButton.Click += AdminImportButton_Click;
            adminToolTip.SetToolTip(adminImportButton, "Import table data from CSV or JSON");
            //
            // Divider  (maroon Panel separator)
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
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.FromArgb(220, 220, 220);
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
            dgvDefaultStyle.BackColor = Color.White;
            dgvDefaultStyle.Font = new Font("Segoe UI", 9F);
            dgvDefaultStyle.ForeColor = SystemColors.ControlText;
            dgvDefaultStyle.SelectionBackColor = Color.FromArgb(120, 0, 30);
            dgvDefaultStyle.SelectionForeColor = Color.White;
            dgvDefaultStyle.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dgvDefaultStyle;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(120, 0, 30);
            dataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(80, 0, 20);
            dataGridView.RowHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1874, 798);
            dataGridView.TabIndex = 0;
            dataGridView.CellMouseDown += DataGridView_CellMouseDown;
            //
            // user  (light gray background so the white card stands out)
            //
            user.BackColor = Color.FromArgb(242, 243, 247);
            user.Controls.Add(headerPanel);
            user.Controls.Add(formCard);
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
            // formCard  (white card panel, centered below the header)
            //
            formCard.BackColor = Color.White;
            formCard.BorderStyle = BorderStyle.FixedSingle;
            formCard.Controls.Add(studentIdLbl);
            formCard.Controls.Add(studentIdTextBox);
            formCard.Controls.Add(studentNameLabel);
            formCard.Controls.Add(studentNameTextBox);
            formCard.Controls.Add(institutionalEmailLbl);
            formCard.Controls.Add(institutionalEmailTextBox);
            formCard.Controls.Add(fbLinkLabel);
            formCard.Controls.Add(facebookLinkTextBox);
            formCard.Controls.Add(clearButton);
            formCard.Controls.Add(submitButton);
            formCard.Location = new Point(576, 286);
            formCard.Name = "formCard";
            formCard.Size = new Size(760, 524);
            formCard.TabIndex = 15;
            //
            // studentIdLbl  (relative to formCard)
            //
            studentIdLbl.AutoSize = true;
            studentIdLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            studentIdLbl.ForeColor = Color.FromArgb(120, 0, 30);
            studentIdLbl.Location = new Point(50, 40);
            studentIdLbl.Name = "studentIdLbl";
            studentIdLbl.TabIndex = 1;
            studentIdLbl.Text = "Student ID:";
            //
            // studentIdTextBox
            //
            studentIdTextBox.BorderStyle = BorderStyle.FixedSingle;
            studentIdTextBox.Font = new Font("Segoe UI", 12F);
            studentIdTextBox.Location = new Point(50, 73);
            studentIdTextBox.Name = "studentIdTextBox";
            studentIdTextBox.PlaceholderText = "24-4339-705";
            studentIdTextBox.Size = new Size(660, 34);
            studentIdTextBox.TabIndex = 2;
            studentIdTextBox.WordWrap = false;
            //
            // studentNameLabel
            //
            studentNameLabel.AutoSize = true;
            studentNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            studentNameLabel.ForeColor = Color.FromArgb(120, 0, 30);
            studentNameLabel.Location = new Point(50, 137);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.TabIndex = 3;
            studentNameLabel.Text = "Student Name:";
            //
            // studentNameTextBox
            //
            studentNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            studentNameTextBox.Font = new Font("Segoe UI", 12F);
            studentNameTextBox.Location = new Point(50, 170);
            studentNameTextBox.Name = "studentNameTextBox";
            studentNameTextBox.PlaceholderText = "Tabotabo, Adrian Seth M.";
            studentNameTextBox.Size = new Size(660, 34);
            studentNameTextBox.TabIndex = 4;
            studentNameTextBox.WordWrap = false;
            //
            // institutionalEmailLbl
            //
            institutionalEmailLbl.AutoSize = true;
            institutionalEmailLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            institutionalEmailLbl.ForeColor = Color.FromArgb(120, 0, 30);
            institutionalEmailLbl.Location = new Point(50, 234);
            institutionalEmailLbl.Name = "institutionalEmailLbl";
            institutionalEmailLbl.TabIndex = 5;
            institutionalEmailLbl.Text = "Institutional Email:";
            //
            // institutionalEmailTextBox
            //
            institutionalEmailTextBox.BorderStyle = BorderStyle.FixedSingle;
            institutionalEmailTextBox.Font = new Font("Segoe UI", 12F);
            institutionalEmailTextBox.Location = new Point(50, 267);
            institutionalEmailTextBox.Name = "institutionalEmailTextBox";
            institutionalEmailTextBox.PlaceholderText = "adrianseth.tabotabo@cit.edu";
            institutionalEmailTextBox.Size = new Size(660, 34);
            institutionalEmailTextBox.TabIndex = 6;
            institutionalEmailTextBox.WordWrap = false;
            //
            // fbLinkLabel
            //
            fbLinkLabel.AutoSize = true;
            fbLinkLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            fbLinkLabel.ForeColor = Color.FromArgb(120, 0, 30);
            fbLinkLabel.Location = new Point(50, 331);
            fbLinkLabel.Name = "fbLinkLabel";
            fbLinkLabel.TabIndex = 7;
            fbLinkLabel.Text = "Facebook Link:";
            //
            // facebookLinkTextBox
            //
            facebookLinkTextBox.BorderStyle = BorderStyle.FixedSingle;
            facebookLinkTextBox.Font = new Font("Segoe UI", 12F);
            facebookLinkTextBox.Location = new Point(50, 364);
            facebookLinkTextBox.Name = "facebookLinkTextBox";
            facebookLinkTextBox.PlaceholderText = "https://facebook.com/dreeyanzz";
            facebookLinkTextBox.Size = new Size(660, 34);
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
            clearButton.Location = new Point(165, 428);
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
            submitButton.Location = new Point(395, 428);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(200, 55);
            submitButton.TabIndex = 10;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += SubmitButton_Click;
            //
            // ── LIST TAB ─────────────────────────────────────────────────────────
            //
            // listTab  (light gray background, mirrors admin layout)
            //
            listTab.BackColor = Color.FromArgb(242, 243, 247);
            listTab.Controls.Add(listRemoveButton);
            listTab.Controls.Add(listExportButton);
            listTab.Controls.Add(listImportButton);
            listTab.Controls.Add(listDivider);
            listTab.Controls.Add(listFormCard);
            listTab.Controls.Add(listGridPanel);
            listTab.Location = new Point(4, 56);
            listTab.Margin = new Padding(0);
            listTab.Name = "listTab";
            listTab.Size = new Size(1912, 931);
            listTab.TabIndex = 2;
            listTab.Text = "List";
            listTab.UseVisualStyleBackColor = false;
            //
            // listRemoveButton  (dark red — destructive)
            //
            listRemoveButton.BackColor = Color.FromArgb(160, 30, 30);
            listRemoveButton.FlatStyle = FlatStyle.Flat;
            listRemoveButton.FlatAppearance.BorderColor = Color.FromArgb(120, 20, 20);
            listRemoveButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            listRemoveButton.ForeColor = Color.White;
            listRemoveButton.Location = new Point(20, 18);
            listRemoveButton.Margin = new Padding(0);
            listRemoveButton.Name = "listRemoveButton";
            listRemoveButton.Size = new Size(130, 60);
            listRemoveButton.TabIndex = 0;
            listRemoveButton.Text = "Remove Row";
            listRemoveButton.UseVisualStyleBackColor = false;
            listRemoveButton.Click += ListRemoveButton_Click;
            adminToolTip.SetToolTip(listRemoveButton, "Remove selected rows from the list (with confirmation)");
            //
            // listExportButton  (maroon — export action)
            //
            listExportButton.BackColor = Color.FromArgb(120, 0, 30);
            listExportButton.FlatStyle = FlatStyle.Flat;
            listExportButton.FlatAppearance.BorderColor = Color.FromArgb(80, 0, 20);
            listExportButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            listExportButton.ForeColor = Color.White;
            listExportButton.Location = new Point(166, 18);
            listExportButton.Margin = new Padding(0);
            listExportButton.Name = "listExportButton";
            listExportButton.Size = new Size(130, 60);
            listExportButton.TabIndex = 1;
            listExportButton.Text = "Export";
            listExportButton.UseVisualStyleBackColor = false;
            listExportButton.Click += ListExportButton_Click;
            adminToolTip.SetToolTip(listExportButton, "Export list data to CSV or JSON");
            //
            // listImportButton  (outlined maroon — import action)
            //
            listImportButton.BackColor = Color.White;
            listImportButton.FlatStyle = FlatStyle.Flat;
            listImportButton.FlatAppearance.BorderColor = Color.FromArgb(120, 0, 30);
            listImportButton.FlatAppearance.BorderSize = 2;
            listImportButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            listImportButton.ForeColor = Color.FromArgb(120, 0, 30);
            listImportButton.Location = new Point(312, 18);
            listImportButton.Margin = new Padding(0);
            listImportButton.Name = "listImportButton";
            listImportButton.Size = new Size(130, 60);
            listImportButton.TabIndex = 2;
            listImportButton.Text = "Import";
            listImportButton.UseVisualStyleBackColor = false;
            listImportButton.Click += ListImportButton_Click;
            adminToolTip.SetToolTip(listImportButton, "Import list data from CSV or JSON");
            //
            // listDivider  (maroon Panel separator)
            //
            listDivider.BackColor = Color.FromArgb(120, 0, 30);
            listDivider.Location = new Point(0, 96);
            listDivider.Name = "listDivider";
            listDivider.Size = new Size(1912, 3);
            listDivider.TabIndex = 1;
            //
            // listFormCard  (white card — input form on the left)
            //
            listFormCard.BackColor = Color.White;
            listFormCard.BorderStyle = BorderStyle.FixedSingle;
            listFormCard.Controls.Add(listIdLbl);
            listFormCard.Controls.Add(listIdTextBox);
            listFormCard.Controls.Add(listNameLbl);
            listFormCard.Controls.Add(listNameTextBox);
            listFormCard.Controls.Add(listEmailLbl);
            listFormCard.Controls.Add(listEmailTextBox);
            listFormCard.Controls.Add(listFbLinkLbl);
            listFormCard.Controls.Add(listFbLinkTextBox);
            listFormCard.Controls.Add(listClearButton);
            listFormCard.Controls.Add(listAddButton);
            listFormCard.Location = new Point(20, 115);
            listFormCard.Name = "listFormCard";
            listFormCard.Size = new Size(580, 510);
            listFormCard.TabIndex = 2;
            //
            // listIdLbl
            //
            listIdLbl.AutoSize = true;
            listIdLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            listIdLbl.ForeColor = Color.FromArgb(120, 0, 30);
            listIdLbl.Location = new Point(50, 35);
            listIdLbl.Name = "listIdLbl";
            listIdLbl.TabIndex = 0;
            listIdLbl.Text = "Student ID:";
            //
            // listIdTextBox
            //
            listIdTextBox.BorderStyle = BorderStyle.FixedSingle;
            listIdTextBox.Font = new Font("Segoe UI", 12F);
            listIdTextBox.Location = new Point(50, 68);
            listIdTextBox.Name = "listIdTextBox";
            listIdTextBox.PlaceholderText = "24-4339-705";
            listIdTextBox.Size = new Size(480, 34);
            listIdTextBox.TabIndex = 1;
            listIdTextBox.WordWrap = false;
            //
            // listNameLbl
            //
            listNameLbl.AutoSize = true;
            listNameLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            listNameLbl.ForeColor = Color.FromArgb(120, 0, 30);
            listNameLbl.Location = new Point(50, 132);
            listNameLbl.Name = "listNameLbl";
            listNameLbl.TabIndex = 2;
            listNameLbl.Text = "Student Name:";
            //
            // listNameTextBox
            //
            listNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            listNameTextBox.Font = new Font("Segoe UI", 12F);
            listNameTextBox.Location = new Point(50, 165);
            listNameTextBox.Name = "listNameTextBox";
            listNameTextBox.PlaceholderText = "Tabotabo, Adrian Seth M.";
            listNameTextBox.Size = new Size(480, 34);
            listNameTextBox.TabIndex = 3;
            listNameTextBox.WordWrap = false;
            //
            // listEmailLbl
            //
            listEmailLbl.AutoSize = true;
            listEmailLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            listEmailLbl.ForeColor = Color.FromArgb(120, 0, 30);
            listEmailLbl.Location = new Point(50, 229);
            listEmailLbl.Name = "listEmailLbl";
            listEmailLbl.TabIndex = 4;
            listEmailLbl.Text = "Institutional Email:";
            //
            // listEmailTextBox
            //
            listEmailTextBox.BorderStyle = BorderStyle.FixedSingle;
            listEmailTextBox.Font = new Font("Segoe UI", 12F);
            listEmailTextBox.Location = new Point(50, 262);
            listEmailTextBox.Name = "listEmailTextBox";
            listEmailTextBox.PlaceholderText = "adrianseth.tabotabo@cit.edu";
            listEmailTextBox.Size = new Size(480, 34);
            listEmailTextBox.TabIndex = 5;
            listEmailTextBox.WordWrap = false;
            //
            // listFbLinkLbl
            //
            listFbLinkLbl.AutoSize = true;
            listFbLinkLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            listFbLinkLbl.ForeColor = Color.FromArgb(120, 0, 30);
            listFbLinkLbl.Location = new Point(50, 326);
            listFbLinkLbl.Name = "listFbLinkLbl";
            listFbLinkLbl.TabIndex = 6;
            listFbLinkLbl.Text = "Facebook Link:";
            //
            // listFbLinkTextBox
            //
            listFbLinkTextBox.BorderStyle = BorderStyle.FixedSingle;
            listFbLinkTextBox.Font = new Font("Segoe UI", 12F);
            listFbLinkTextBox.Location = new Point(50, 359);
            listFbLinkTextBox.Name = "listFbLinkTextBox";
            listFbLinkTextBox.PlaceholderText = "https://facebook.com/dreeyanzz";
            listFbLinkTextBox.Size = new Size(480, 34);
            listFbLinkTextBox.TabIndex = 7;
            listFbLinkTextBox.WordWrap = false;
            //
            // listClearButton  (secondary — outlined maroon)
            //
            listClearButton.BackColor = Color.White;
            listClearButton.FlatStyle = FlatStyle.Flat;
            listClearButton.FlatAppearance.BorderColor = Color.FromArgb(120, 0, 30);
            listClearButton.FlatAppearance.BorderSize = 2;
            listClearButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            listClearButton.ForeColor = Color.FromArgb(120, 0, 30);
            listClearButton.Location = new Point(100, 428);
            listClearButton.Name = "listClearButton";
            listClearButton.Size = new Size(165, 50);
            listClearButton.TabIndex = 8;
            listClearButton.Text = "Clear";
            listClearButton.UseVisualStyleBackColor = false;
            listClearButton.Click += ListClearButton_Click;
            //
            // listAddButton  (primary — filled maroon)
            //
            listAddButton.BackColor = Color.FromArgb(120, 0, 30);
            listAddButton.FlatStyle = FlatStyle.Flat;
            listAddButton.FlatAppearance.BorderColor = Color.FromArgb(80, 0, 20);
            listAddButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            listAddButton.ForeColor = Color.White;
            listAddButton.Location = new Point(315, 428);
            listAddButton.Name = "listAddButton";
            listAddButton.Size = new Size(165, 50);
            listAddButton.TabIndex = 9;
            listAddButton.Text = "Add to List";
            listAddButton.UseVisualStyleBackColor = false;
            listAddButton.Click += ListAddButton_Click;
            adminToolTip.SetToolTip(listAddButton, "Validate and add student to the list");
            //
            // listGridPanel  (DataGridView container — right side)
            //
            listGridPanel.BorderStyle = BorderStyle.FixedSingle;
            listGridPanel.Controls.Add(listDataGridView);
            listGridPanel.Location = new Point(620, 115);
            listGridPanel.Margin = new Padding(0);
            listGridPanel.Name = "listGridPanel";
            listGridPanel.Size = new Size(1272, 800);
            listGridPanel.TabIndex = 3;
            //
            // listDataGridView  (manually populated — no DataSource binding)
            //
            listDataGridView.AllowUserToAddRows = false;
            listDataGridView.AllowUserToOrderColumns = true;
            listDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listDataGridView.BackgroundColor = Color.White;
            listDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listDataGridView.EnableHeadersVisualStyles = false;
            listDataGridView.GridColor = Color.FromArgb(220, 220, 220);
            listDataGridView.ReadOnly = true;
            listDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            listHeaderStyle.BackColor = Color.FromArgb(120, 0, 30);
            listHeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            listHeaderStyle.ForeColor = Color.White;
            listHeaderStyle.SelectionBackColor = Color.FromArgb(120, 0, 30);
            listHeaderStyle.SelectionForeColor = Color.White;
            listDataGridView.ColumnHeadersDefaultCellStyle = listHeaderStyle;
            listAltRowStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            listAltRowStyle.BackColor = Color.FromArgb(255, 245, 248);
            listAltRowStyle.ForeColor = Color.Black;
            listAltRowStyle.SelectionBackColor = Color.FromArgb(120, 0, 30);
            listAltRowStyle.SelectionForeColor = Color.White;
            listDataGridView.AlternatingRowsDefaultCellStyle = listAltRowStyle;
            listDefaultStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            listDefaultStyle.BackColor = Color.White;
            listDefaultStyle.Font = new Font("Segoe UI", 9F);
            listDefaultStyle.ForeColor = SystemColors.ControlText;
            listDefaultStyle.SelectionBackColor = Color.FromArgb(120, 0, 30);
            listDefaultStyle.SelectionForeColor = Color.White;
            listDefaultStyle.WrapMode = DataGridViewTriState.False;
            listDataGridView.DefaultCellStyle = listDefaultStyle;
            listDataGridView.Dock = DockStyle.Fill;
            listDataGridView.Location = new Point(0, 0);
            listDataGridView.Name = "listDataGridView";
            listDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(120, 0, 30);
            listDataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            listDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(80, 0, 20);
            listDataGridView.RowHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            listDataGridView.RowHeadersWidth = 51;
            listDataGridView.Size = new Size(1270, 798);
            listDataGridView.TabIndex = 0;
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
            formCard.ResumeLayout(false);
            formCard.PerformLayout();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            user.ResumeLayout(false);
            listTab.ResumeLayout(false);
            listFormCard.ResumeLayout(false);
            listFormCard.PerformLayout();
            listGridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Tabs;
        private TabPage admin;
        private TabPage user;
        private TabPage listTab;
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
        private Panel formCard;
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
        private Button listRemoveButton;
        private Button adminExportButton;
        private Button adminImportButton;
        private Button listExportButton;
        private Button listImportButton;
        private Panel listDivider;
        private Panel listFormCard;
        private Label listIdLbl;
        private TextBox listIdTextBox;
        private Label listNameLbl;
        private TextBox listNameTextBox;
        private Label listEmailLbl;
        private TextBox listEmailTextBox;
        private Label listFbLinkLbl;
        private TextBox listFbLinkTextBox;
        private Button listClearButton;
        private Button listAddButton;
        private Panel listGridPanel;
        private DataGridView listDataGridView;
        private ToolTip adminToolTip;
    }
}
