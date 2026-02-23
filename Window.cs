using System.Data;

namespace week_5_assignment
{
    public partial class Window : Form
    {
        private readonly DataTable dTable = new();
        private int rowNum = 0;

        public Window()
        {
            InitializeComponent();

            dataGridView.DataSource = dTable;
            dTable.Columns.Add(columnName: "id");
            dTable.Columns.Add(columnName: "Student ID");
            dTable.Columns.Add(columnName: "Student Name");
            dTable.Columns.Add(columnName: "Institutional Email");
            dTable.Columns.Add(columnName: "Facebook Link");
        }

        private void OpenAddColumn_Click(object sender, EventArgs e)
        {
            AddColumnForm addForm = new(table: dTable);
            addForm.ShowDialog();
        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            DataRow newRow = dTable.NewRow();
            newRow[columnName: "id"] = $"{++rowNum}";
            dTable.Rows.Add(row: newRow);
        }

        private void RemoveRow_Click(object sender, EventArgs e)
        {
            var rowIndices = dataGridView
                .SelectedCells.Cast<DataGridViewCell>()
                .Select(c => c.RowIndex)
                .Distinct()
                .OrderByDescending(i => i)
                .ToList();

            foreach (int idx in rowIndices)
                if (idx >= 0 && idx < dTable.Rows.Count)
                    dTable.Rows.RemoveAt(idx);
        }

        private void DataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (e.Button == MouseButtons.Right)
            {
                if (!dataGridView.Rows[index: e.RowIndex].Cells[index: e.ColumnIndex].Selected)
                {
                    dataGridView.ClearSelection();
                    dataGridView.Rows[index: e.RowIndex].Cells[index: e.ColumnIndex].Selected =
                        true;
                }

                ContextMenuStrip menu = new();
                menu.Closed += (_, _) => menu.Dispose();

                ToolStripMenuItem alignmentMenu = new(text: "Change Alignment for Selection");

                void SetAlignment(DataGridViewContentAlignment align)
                {
                    foreach (DataGridViewCell selectedCell in dataGridView.SelectedCells)
                        selectedCell.Style.Alignment = align;
                }

                foreach (
                    DataGridViewContentAlignment alignment in Enum.GetValues<DataGridViewContentAlignment>()
                )
                {
                    alignmentMenu.DropDownItems.Add(
                        text: alignment.ToString(),
                        image: null,
                        onClick: (s, a) => SetAlignment(align: alignment)
                    );
                }
                menu.Items.Add(value: alignmentMenu);

                ToolStripMenuItem deleteMenu = new(text: "Clear selection contents");
                deleteMenu.Click += (sender, args) =>
                {
                    foreach (DataGridViewCell selectedCell in dataGridView.SelectedCells)
                        if (!selectedCell.ReadOnly)
                            selectedCell.Value = DBNull.Value;
                };
                menu.Items.Add(value: new ToolStripSeparator());
                menu.Items.Add(value: deleteMenu);

                menu.Show(screenLocation: Cursor.Position);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            studentIdTextBox.Clear();
            studentNameTextBox.Clear();
            institutionalEmailTextBox.Clear();
            facebookLinkTextBox.Clear();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string studentId = studentIdTextBox.Text.Trim();
            string studentName = studentNameTextBox.Text.Trim();
            string email = institutionalEmailTextBox.Text.Trim();
            string fbLink = facebookLinkTextBox.Text.Trim();

            if (string.IsNullOrEmpty(studentId))
            {
                new ErrorForm("Student ID cannot be empty.").ShowDialog();
                return;
            }

            if (string.IsNullOrEmpty(studentName))
            {
                new ErrorForm("Student Name cannot be empty.").ShowDialog();
                return;
            }

            if (
                string.IsNullOrEmpty(email)
                || !email.EndsWith("@cit.edu", StringComparison.OrdinalIgnoreCase)
            )
            {
                new ErrorForm("Institutional Email must be a valid @cit.edu address.").ShowDialog();
                return;
            }

            DataRow newRow = dTable.NewRow();
            newRow["id"] = $"{++rowNum}";
            newRow["Student ID"] = studentId;
            newRow["Student Name"] = studentName;
            newRow["Institutional Email"] = email;
            newRow["Facebook Link"] = fbLink;
            dTable.Rows.Add(row: newRow);

            clearButton_Click(sender, e);
        }
    }
}
