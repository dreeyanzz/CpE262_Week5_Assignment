using System.Data;

namespace week_5_assignment
{
    public partial class AddColumnForm : Form
    {
        private readonly DataTable _table;

        public AddColumnForm(DataTable table)
        {
            InitializeComponent();
            _table = table;
        }

        private void AddColBtn_Click(object sender, EventArgs e)
        {
            string name = colNameInput.Text.Trim();

            if (string.IsNullOrEmpty(value: name))
            {
                new ErrorForm("Column name cannot be empty!").ShowDialog();
                return;
            }

            if (_table.Columns.Contains(name: name))
            {
                new ErrorForm(error: "That column already exists!").ShowDialog();
                return;
            }

            _table.Columns.Add(columnName: name);
            Close();
        }
    }
}
