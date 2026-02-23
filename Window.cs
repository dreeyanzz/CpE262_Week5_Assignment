using System.Data;
using System.Windows.Forms;

namespace week_5_assignment
{
    public partial class Window : Form
    {
        public readonly DataTable dTable = new();
        private int rowNum = 0;

        public Window()
        {
            InitializeComponent();

            dataGridView.DataSource = dTable;
            dTable.Columns.Add(columnName: "id");
        }

        private void OpenAddColumn_Click(object sender, EventArgs e)
        {
            AddColumnForm addForm = new(parent: this);
            addForm.ShowDialog();
        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            DataRow newRow = dTable.NewRow();
            newRow[columnName: "id"] = $"{++rowNum}";

            dTable.Rows.Add(row: newRow);
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

                ToolStripMenuItem alignmentMenu = new(text: "Change Alignment for Selection");

                // Helper to apply to all highlighted cells
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

        }

    }
}
