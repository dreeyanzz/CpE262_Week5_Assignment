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
            dataTable = new TabPage();
            AddRowButton = new Button();
            panel1 = new Panel();
            dataGridView = new DataGridView();
            Divider = new Label();
            AddColumnButton = new Button();
            list = new TabPage();
            Tabs.SuspendLayout();
            dataTable.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // Tabs
            // 
            Tabs.Controls.Add(dataTable);
            Tabs.Controls.Add(list);
            Tabs.Dock = DockStyle.Top;
            Tabs.ItemSize = new Size(100, 50);
            Tabs.Location = new Point(0, 0);
            Tabs.Name = "Tabs";
            Tabs.Padding = new Point(0, 0);
            Tabs.SelectedIndex = 0;
            Tabs.Size = new Size(1920, 991);
            Tabs.TabIndex = 0;
            // 
            // dataTable
            // 
            dataTable.Controls.Add(AddRowButton);
            dataTable.Controls.Add(panel1);
            dataTable.Controls.Add(Divider);
            dataTable.Controls.Add(AddColumnButton);
            dataTable.Location = new Point(4, 54);
            dataTable.Margin = new Padding(0);
            dataTable.Name = "dataTable";
            dataTable.Size = new Size(1912, 933);
            dataTable.TabIndex = 0;
            dataTable.Text = "Data Table";
            dataTable.UseVisualStyleBackColor = true;
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
            // list
            // 
            list.Location = new Point(4, 54);
            list.Margin = new Padding(0);
            list.Name = "list";
            list.Size = new Size(1912, 933);
            list.TabIndex = 1;
            list.Text = "List";
            list.UseVisualStyleBackColor = true;
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
            dataTable.ResumeLayout(false);
            dataTable.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Tabs;
        private TabPage dataTable;
        private TabPage list;
        private Button AddColumnButton;
        private Label Divider;
        private Panel panel1;
        private DataGridView dataGridView;
        private Button AddRowButton;
    }
}
