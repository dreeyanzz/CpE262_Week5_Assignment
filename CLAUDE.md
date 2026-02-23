# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Build & Run

This is a .NET 10 Windows Forms project. Use the .NET CLI or Visual Studio 2022+.

```bash
# Build
dotnet build

# Run
dotnet run

# Build release
dotnet build -c Release
```

The solution file is `week-5-assignment.slnx` (new XML-based solution format). The project targets `net10.0-windows` and requires Windows to run.

## Architecture

The app is a **Student Management System** GUI built with Windows Forms. It has three tabs inside the main `Window` form, each demonstrating a different data structure as required by the assignment:

- **Admin tab** — Implementation #1: `DataTable`. A dynamic `DataGridView` bound via `dataGridView.DataSource = dTable`. Starts with predefined columns: `id`, `Student ID`, `Student Name`, `Institutional Email`, `Facebook Link`. Users can add extra columns (via `AddColumnForm` dialog), add blank rows, or remove selected rows with a Yes/No confirmation. Right-clicking a cell opens a context menu for per-cell alignment changes or clearing cell contents. `AllowUserToAddRows = false` prevents the default `*` new-row entry.
- **User tab** — A student registration form with a `formCard` white panel on a light-gray background. On submit, validates: Student ID non-empty and matching `YY-NNNN-NNN` format, Student Name non-empty, and Institutional Email ending with `@cit.edu`. On success, appends a row to the shared `DataTable` (Admin tab) and clears the inputs.
- **List tab** — Implementation #2: `List<string[]>`. A `listFormCard` on the left (same input fields and validation as the User tab) and a `listDataGridView` on the right. The grid is **not data-bound** — `RefreshListGrid()` clears `Rows` and re-adds each `string[]` from `studentList` manually via `Rows.Add()`. Row numbers are generated from the list index at refresh time, so they renumber automatically after deletions. The grid is `ReadOnly = true` with `FullRowSelect` mode.

### Form structure

| File | Role |
|------|------|
| `Window.cs` / `Window.Designer.cs` | Main form with all three tabs; owns `dTable` (DataTable) and `studentList` (List) |
| `AddColumnForm.cs` / `AddColumnForm.Designer.cs` | Modal dialog for adding a named column; receives a `DataTable` reference |
| `ErrorForm.cs` / `ErrorForm.Designer.cs` | Modal error dialog; takes an error string; constructor sets `errLbl.Text` after `InitializeComponent()` |
| `Program.cs` | Entry point; calls `Application.Run(new Window())` |

### Key patterns

- `AddColumnForm` takes a `DataTable` directly (not the parent `Window`), keeping it decoupled from the main form.
- `ErrorForm` follows the standard designer pattern — all controls declared as fields and initialized in `InitializeComponent()` inside `ErrorForm.Designer.cs`.
- The `DataGridView` is data-bound via `dataGridView.DataSource = dTable` — adding/removing columns or rows on the `DataTable` automatically reflects in the grid.
- The `id` column is marked `ReadOnly = true` on the `DataColumn`, making it non-editable in the grid.
- The `ContextMenuStrip` created on right-click disposes itself via `menu.Closed += (_, _) => menu.Dispose()` to avoid accumulating instances.
- `Tabs_SelectedIndexChanged` sets `AcceptButton` per-tab: `submitButton` on User, `listAddButton` on List, `null` on Admin — so Enter key submits the correct form.
- Student ID format is validated without Regex: `Split('-')` into three parts and `All(char.IsDigit)` with length checks `[2, 4, 3]`. The same validation runs on both the User tab and the List tab.
- `adminToolTip` is a `ToolTip` component held in `components` (`IContainer`) for proper disposal; tooltips are set on toolbar buttons across all three tabs.
- `RefreshListGrid()` (List tab) clears `listDataGridView.Rows` and re-populates from `studentList` using a `for` loop and `Rows.Add()` — the row number `#` is computed from the index, not stored in the list entry.

### UI / Branding

CIT-U brand colors used throughout (defined inline in `Window.Designer.cs`):
- Maroon `Color.FromArgb(120, 0, 30)` — primary (buttons, header, labels, divider, DataGridView column headers, row headers, selection highlight)
- Dark red `Color.FromArgb(160, 30, 30)` — destructive actions (Remove Row button)
- Gold `Color.FromArgb(255, 215, 100)` — accent (system title label in header)

**Shared header:** A `headerPanel` (maroon, `DockStyle.Top`, 165px tall) is inside the User tab and holds the CIT-U seal (`pictureBox1`), school name (`citLbl`, white 20pt Bold), and system title (`titleLbl`, gold 14pt).

**User tab layout:** Background is light gray `Color.FromArgb(242, 243, 247)`. A white `formCard` Panel (`BorderStyle.FixedSingle`) groups the four labeled input fields and Submit/Clear buttons in a centered card. Submit is filled maroon; Clear is outlined maroon.

**Admin tab:** `Divider` is a `Panel` (3px tall, maroon) between the toolbar and the DataGridView. Toolbar buttons use `FlatStyle.Flat` with colored backgrounds.

**List tab:** Same light-gray background as User tab. `listDivider` separates the toolbar (Remove Row button) from the content area. `listFormCard` (white, bordered, 580×510px) sits on the left; `listGridPanel` (bordered, 1272×800px) sits on the right. The grid uses `ReadOnly = true` and `FullRowSelect` — users click rows to select them for deletion.

**DataGridView styling:** White background, light-gray `(220, 220, 220)` grid lines, maroon column header style (`EnableHeadersVisualStyles = false`), maroon row header cell style (white text).

**Dialogs:** `AddColumnForm` and `ErrorForm` match the CIT-U palette — white background, maroon label/button, `FormBorderStyle.FixedDialog`, `StartPosition.CenterParent`.

### Resources

Images are stored in `Resources/` and referenced through the strongly-typed `Properties.Resources` class generated from `Properties/Resources.resx`.
