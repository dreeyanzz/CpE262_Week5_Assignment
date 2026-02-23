using System.Data;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace week_5_assignment
{
    public partial class Window : Form
    {
        private readonly DataTable dTable = new();
        private int rowNum = 0;
        private readonly List<string[]> studentList = new();

        public Window()
        {
            InitializeComponent();

            dataGridView.DataSource = dTable;
            dTable.Columns.Add(columnName: "id");
            dTable.Columns["id"]!.ReadOnly = true;
            dTable.Columns.Add(columnName: "Student ID");
            dTable.Columns.Add(columnName: "Student Name");
            dTable.Columns.Add(columnName: "Institutional Email");
            dTable.Columns.Add(columnName: "Facebook Link");

            // List tab: columns added manually (no DataSource binding)
            listDataGridView.Columns.Add("num", "#");
            listDataGridView.Columns.Add("studentId", "Student ID");
            listDataGridView.Columns.Add("name", "Student Name");
            listDataGridView.Columns.Add("email", "Institutional Email");
            listDataGridView.Columns.Add("fbLink", "Facebook Link");
            listDataGridView.Columns["num"]!.ReadOnly = true;
            listDataGridView.Columns["num"]!.FillWeight = 30;
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

            if (rowIndices.Count == 0)
                return;

            string msg =
                rowIndices.Count == 1
                    ? "Remove the selected row?"
                    : $"Remove {rowIndices.Count} selected rows?";

            if (
                MessageBox.Show(
                    msg,
                    "Confirm Removal",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                ) != DialogResult.Yes
            )
                return;

            foreach (int idx in rowIndices)
                if (idx >= 0 && idx < dTable.Rows.Count)
                    dTable.Rows.RemoveAt(idx);
        }

        private void Tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            AcceptButton =
                Tabs.SelectedTab == user ? submitButton
                : Tabs.SelectedTab == listTab ? listAddButton
                : null;
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

            var idParts = studentId.Split('-');
            bool validIdFormat =
                idParts.Length == 3
                && idParts[0].Length == 2
                && idParts[0].All(char.IsDigit)
                && idParts[1].Length == 4
                && idParts[1].All(char.IsDigit)
                && idParts[2].Length == 3
                && idParts[2].All(char.IsDigit);

            if (!validIdFormat)
            {
                new ErrorForm(
                    "Student ID must follow the format YY-NNNN-NNN (e.g. 24-4339-705)."
                ).ShowDialog();
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

        // ── LIST TAB ─────────────────────────────────────────────────────────────

        private void RefreshListGrid()
        {
            listDataGridView.Rows.Clear();
            for (int i = 0; i < studentList.Count; i++)
            {
                string[] s = studentList[i];
                listDataGridView.Rows.Add($"{i + 1}", s[0], s[1], s[2], s[3]);
            }
        }

        private void ListAddButton_Click(object sender, EventArgs e)
        {
            string studentId = listIdTextBox.Text.Trim();
            string studentName = listNameTextBox.Text.Trim();
            string email = listEmailTextBox.Text.Trim();
            string fbLink = listFbLinkTextBox.Text.Trim();

            if (string.IsNullOrEmpty(studentId))
            {
                new ErrorForm("Student ID cannot be empty.").ShowDialog();
                return;
            }

            var idParts = studentId.Split('-');
            bool validIdFormat =
                idParts.Length == 3
                && idParts[0].Length == 2
                && idParts[0].All(char.IsDigit)
                && idParts[1].Length == 4
                && idParts[1].All(char.IsDigit)
                && idParts[2].Length == 3
                && idParts[2].All(char.IsDigit);

            if (!validIdFormat)
            {
                new ErrorForm(
                    "Student ID must follow the format YY-NNNN-NNN (e.g. 24-4339-705)."
                ).ShowDialog();
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

            studentList.Add(new[] { studentId, studentName, email, fbLink });
            RefreshListGrid();
            ListClearButton_Click(sender, e);
        }

        private void ListRemoveButton_Click(object sender, EventArgs e)
        {
            var rowIndices = listDataGridView
                .SelectedCells.Cast<DataGridViewCell>()
                .Select(c => c.RowIndex)
                .Distinct()
                .OrderByDescending(i => i)
                .ToList();

            if (rowIndices.Count == 0)
                return;

            string msg =
                rowIndices.Count == 1
                    ? "Remove the selected row?"
                    : $"Remove {rowIndices.Count} selected rows?";

            if (
                MessageBox.Show(
                    msg,
                    "Confirm Removal",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                ) != DialogResult.Yes
            )
                return;

            foreach (int idx in rowIndices)
                if (idx >= 0 && idx < studentList.Count)
                    studentList.RemoveAt(idx);

            RefreshListGrid();
        }

        private void ListClearButton_Click(object sender, EventArgs e)
        {
            listIdTextBox.Clear();
            listNameTextBox.Clear();
            listEmailTextBox.Clear();
            listFbLinkTextBox.Clear();
        }

        // ── IMPORT / EXPORT HELPERS ──────────────────────────────────────────────

        private static string CsvEscape(string? value)
        {
            if (value is null)
                return "";
            if (value.Contains(',') || value.Contains('"') || value.Contains('\n'))
                return $"\"{value.Replace("\"", "\"\"")}\"";
            return value;
        }

        private static List<string> ParseCsvLine(string line)
        {
            var fields = new List<string>();
            int i = 0;
            while (i <= line.Length)
            {
                if (i == line.Length)
                {
                    fields.Add("");
                    break;
                }
                if (line[i] == '"')
                {
                    i++;
                    var sb = new System.Text.StringBuilder();
                    while (i < line.Length)
                    {
                        if (line[i] == '"' && i + 1 < line.Length && line[i + 1] == '"')
                        {
                            sb.Append('"');
                            i += 2;
                        }
                        else if (line[i] == '"')
                        {
                            i++;
                            break;
                        }
                        else
                        {
                            sb.Append(line[i++]);
                        }
                    }
                    fields.Add(sb.ToString());
                    if (i < line.Length && line[i] == ',')
                        i++;
                }
                else
                {
                    int start = i;
                    while (i < line.Length && line[i] != ',')
                        i++;
                    fields.Add(line[start..i]);
                    if (i < line.Length)
                        i++;
                }
            }
            return fields;
        }

        private static (string path, bool isCsv)? ShowSaveDialog()
        {
            using SaveFileDialog dlg = new();
            dlg.Filter = "CSV files (*.csv)|*.csv|JSON files (*.json)|*.json|All files (*.*)|*.*";
            dlg.FilterIndex = 1;
            if (dlg.ShowDialog() != DialogResult.OK)
                return null;
            return (dlg.FileName, dlg.FilterIndex == 1);
        }

        private static (string path, bool isCsv)? ShowOpenDialog()
        {
            using OpenFileDialog dlg = new();
            dlg.Filter = "CSV files (*.csv)|*.csv|JSON files (*.json)|*.json|All files (*.*)|*.*";
            dlg.FilterIndex = 1;
            if (dlg.ShowDialog() != DialogResult.OK)
                return null;
            bool isCsv = Path.GetExtension(dlg.FileName)
                .Equals(".csv", StringComparison.OrdinalIgnoreCase);
            return (dlg.FileName, isCsv);
        }

        // ── ADMIN EXPORT ─────────────────────────────────────────────────────────

        private void AdminExportButton_Click(object sender, EventArgs e)
        {
            var result = ShowSaveDialog();
            if (result is null)
                return;
            var (path, isCsv) = result.Value;

            try
            {
                if (isCsv)
                {
                    var lines = new List<string>();
                    var headers = dTable
                        .Columns.Cast<DataColumn>()
                        .Select(c => CsvEscape(c.ColumnName));
                    lines.Add(string.Join(",", headers));
                    foreach (DataRow row in dTable.Rows)
                    {
                        var cells = dTable
                            .Columns.Cast<DataColumn>()
                            .Select(c => CsvEscape(row[c]?.ToString()));
                        lines.Add(string.Join(",", cells));
                    }
                    File.WriteAllLines(path, lines);
                }
                else
                {
                    var arr = new JsonArray();
                    foreach (DataRow row in dTable.Rows)
                    {
                        var obj = new JsonObject();
                        foreach (DataColumn col in dTable.Columns)
                            obj[col.ColumnName] = JsonValue.Create(row[col]?.ToString() ?? "");
                        arr.Add(obj);
                    }
                    File.WriteAllText(
                        path,
                        arr.ToJsonString(new JsonSerializerOptions { WriteIndented = true })
                    );
                }
                MessageBox.Show(
                    $"Data exported successfully to:\n{path}",
                    "Export Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                new ErrorForm($"Export failed: {ex.Message}").ShowDialog();
            }
        }

        // ── ADMIN IMPORT ─────────────────────────────────────────────────────────

        private void AdminImportButton_Click(object sender, EventArgs e)
        {
            if (dTable.Rows.Count > 0)
            {
                if (
                    MessageBox.Show(
                        "This will replace all existing data. Continue?",
                        "Confirm Import",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    ) != DialogResult.Yes
                )
                    return;
            }

            var result = ShowOpenDialog();
            if (result is null)
                return;
            var (path, isCsv) = result.Value;

            try
            {
                List<string> headers = [];
                List<List<string>> dataRows = [];

                if (isCsv)
                {
                    var lines = File.ReadAllLines(path);
                    if (lines.Length == 0)
                        throw new InvalidDataException("CSV file is empty.");
                    headers = ParseCsvLine(lines[0]);
                    dataRows = lines.Skip(1).Select(ParseCsvLine).ToList();
                }
                else
                {
                    var json = File.ReadAllText(path);
                    var arr =
                        JsonNode.Parse(json)?.AsArray()
                        ?? throw new InvalidDataException("JSON file must contain an array.");
                    if (arr.Count > 0)
                    {
                        var firstObj = arr[0]!.AsObject();
                        headers = firstObj.Select(kvp => kvp.Key).ToList();
                        dataRows = arr.Select(node =>
                            {
                                var obj = node!.AsObject();
                                return headers
                                    .Select(h => obj[h]?.GetValue<string>() ?? "")
                                    .ToList();
                            })
                            .ToList();
                    }
                }

                dTable.Rows.Clear();
                dTable.Columns.Clear();
                foreach (string header in headers)
                {
                    dTable.Columns.Add(header);
                    if (header == "id")
                        dTable.Columns["id"]!.ReadOnly = true;
                }
                foreach (var rowData in dataRows)
                {
                    DataRow row = dTable.NewRow();
                    for (int i = 0; i < Math.Min(rowData.Count, dTable.Columns.Count); i++)
                        row[i] = rowData[i];
                    dTable.Rows.Add(row);
                }
                rowNum = dTable.Rows.Count;
                MessageBox.Show(
                    $"Data imported successfully. {dTable.Rows.Count} row(s) loaded.",
                    "Import Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                new ErrorForm($"Import failed: {ex.Message}").ShowDialog();
            }
        }

        // ── LIST EXPORT ──────────────────────────────────────────────────────────

        private void ListExportButton_Click(object sender, EventArgs e)
        {
            var result = ShowSaveDialog();
            if (result is null)
                return;
            var (path, isCsv) = result.Value;

            string[] fixedHeaders =
            [
                "Student ID",
                "Student Name",
                "Institutional Email",
                "Facebook Link",
            ];
            try
            {
                if (isCsv)
                {
                    var lines = new List<string>();
                    lines.Add(string.Join(",", fixedHeaders.Select(CsvEscape)));
                    foreach (var s in studentList)
                        lines.Add(string.Join(",", s.Select(CsvEscape)));
                    File.WriteAllLines(path, lines);
                }
                else
                {
                    var arr = new JsonArray();
                    foreach (var s in studentList)
                    {
                        var obj = new JsonObject();
                        for (int i = 0; i < fixedHeaders.Length; i++)
                            obj[fixedHeaders[i]] = JsonValue.Create(s[i]);
                        arr.Add(obj);
                    }
                    File.WriteAllText(
                        path,
                        arr.ToJsonString(new JsonSerializerOptions { WriteIndented = true })
                    );
                }
                MessageBox.Show(
                    $"Data exported successfully to:\n{path}",
                    "Export Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                new ErrorForm($"Export failed: {ex.Message}").ShowDialog();
            }
        }

        // ── LIST IMPORT ──────────────────────────────────────────────────────────

        private void ListImportButton_Click(object sender, EventArgs e)
        {
            if (studentList.Count > 0)
            {
                if (
                    MessageBox.Show(
                        "This will replace all existing data. Continue?",
                        "Confirm Import",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    ) != DialogResult.Yes
                )
                    return;
            }

            var result = ShowOpenDialog();
            if (result is null)
                return;
            var (path, isCsv) = result.Value;

            try
            {
                List<string[]> parsed = [];
                int skipped = 0;

                if (isCsv)
                {
                    var lines = File.ReadAllLines(path);
                    foreach (var line in lines.Skip(1))
                    {
                        var fields = ParseCsvLine(line);
                        if (fields.Count >= 4)
                            parsed.Add([fields[0], fields[1], fields[2], fields[3]]);
                        else
                            skipped++;
                    }
                }
                else
                {
                    var json = File.ReadAllText(path);
                    var arr =
                        JsonNode.Parse(json)?.AsArray()
                        ?? throw new InvalidDataException("JSON file must contain an array.");
                    string[] keys =
                    [
                        "Student ID",
                        "Student Name",
                        "Institutional Email",
                        "Facebook Link",
                    ];
                    foreach (var node in arr)
                    {
                        var obj = node!.AsObject();
                        if (keys.All(k => obj.ContainsKey(k)))
                            parsed.Add(
                                keys.Select(k => obj[k]?.GetValue<string>() ?? "").ToArray()
                            );
                        else
                            skipped++;
                    }
                }

                studentList.Clear();
                studentList.AddRange(parsed);
                RefreshListGrid();

                string msg = $"Data imported successfully. {studentList.Count} row(s) loaded.";
                if (skipped > 0)
                    msg += $"\n{skipped} malformed row(s) were skipped.";
                MessageBox.Show(
                    msg,
                    "Import Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                new ErrorForm($"Import failed: {ex.Message}").ShowDialog();
            }
        }
    }
}
