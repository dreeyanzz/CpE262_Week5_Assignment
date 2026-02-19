using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace week_5_assignment
{
    public partial class AddColumnForm : Form
    {
        private readonly Window _pWindow;

        public AddColumnForm(Window parent)
        {
            InitializeComponent();

            _pWindow = parent;
        }

        private void AddColBtn_Click(object sender, EventArgs e)
        {
            string name = colNameInput.Text.Trim();

            if (string.IsNullOrEmpty(value: name))
            {
                new ErrorForm("Column name cannot be empty!").ShowDialog();
                return;
            }

            // 🛡️ Guard: Check if column already exists to prevent a crash
            if (_pWindow.dTable.Columns.Contains(name: name))
            {
                new ErrorForm(error: "That column already exists!").ShowDialog();
                return;
            }

            // Now you access the table through the parent reference
            _pWindow.dTable.Columns.Add(columnName: name);
            Close();
        }
    }
}
