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

The app is a **Student Management System** GUI built with Windows Forms. It has two tabs inside the main `Window` form:

- **Admin tab** — A dynamic `DataGridView` backed by an in-memory `DataTable` (`Window.dTable`, private). Starts with predefined columns: `id`, `Student ID`, `Student Name`, `Institutional Email`, `Facebook Link`. Users can add extra columns (via `AddColumnForm` dialog), add blank rows, or remove selected rows. Right-clicking a cell opens a context menu for per-cell alignment changes or clearing cell contents.
- **User tab** — A student registration form. On submit, validates Student ID (non-empty), Student Name (non-empty), and Institutional Email (must end with `@cit.edu`), then appends a row to the shared `DataTable` and clears the inputs.

### Form structure

| File | Role |
|------|------|
| `Window.cs` / `Window.Designer.cs` | Main form with both tabs; owns the `DataTable` |
| `AddColumnForm.cs` / `AddColumnForm.Designer.cs` | Modal dialog for adding a named column; receives a `DataTable` reference |
| `ErrorForm.cs` / `ErrorForm.Designer.cs` | Modal error dialog; takes an error string; constructor sets `errLbl.Text` after `InitializeComponent()` |
| `Program.cs` | Entry point; calls `Application.Run(new Window())` |

### Key patterns

- `AddColumnForm` takes a `DataTable` directly (not the parent `Window`), keeping it decoupled from the main form.
- `ErrorForm` follows the standard designer pattern — all controls are declared as fields and initialized in `InitializeComponent()` in `ErrorForm.Designer.cs`.
- The `DataGridView` is data-bound to `dTable` via `dataGridView.DataSource = dTable` — adding/removing columns or rows on the `DataTable` automatically reflects in the grid.
- The `ContextMenuStrip` created on right-click disposes itself via `menu.Closed += (_, _) => menu.Dispose()` to avoid accumulating instances.

### Resources

Images are stored in `Resources/` and referenced through the strongly-typed `Properties.Resources` class generated from `Properties/Resources.resx`.
