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

- **Admin tab** — A dynamic `DataGridView` backed by an in-memory `DataTable` (`Window.dTable`, which is `public readonly`). Users can add columns (via `AddColumnForm` dialog) and add rows. Right-clicking a cell opens a context menu for per-cell alignment changes or clearing cell contents.
- **User tab** — A student registration form with fields for Student ID, Student Name, Institutional Email, and Facebook Link, plus Submit and Clear buttons. The CIT University logo is embedded via `Properties/Resources.resx`.

### Form structure

| File | Role |
|------|------|
| `Window.cs` / `Window.Designer.cs` | Main form with both tabs; owns the `DataTable` |
| `AddColumnForm.cs` / `AddColumnForm.Designer.cs` | Modal dialog for adding a named column; receives a `Window` reference to access `dTable` directly |
| `ErrorForm.cs` / `ErrorForm.Designer.cs` | Programmatically-built modal error dialog (no `.Designer.cs` logic used); takes an error string and displays it |
| `Program.cs` | Entry point; calls `Application.Run(new Window())` |

### Key patterns

- `AddColumnForm` takes a `Window parent` reference in its constructor to mutate `dTable` directly — the parent's `dTable` is `public readonly`.
- `ErrorForm` builds its entire UI in code (constructor) rather than using the designer; the `.Designer.cs` / `.resx` files for it are empty stubs.
- The `DataGridView` is data-bound to `dTable` via `dataGridView.DataSource = dTable` — adding columns/rows to the `DataTable` automatically reflects in the grid.
- `RemoveColumnButton` in the designer has no click handler wired up yet (stub).
- `clearButton_Click` in `Window.cs` has no implementation yet (stub).
- `submitButton` has no click handler wired up yet (stub).

### Resources

Images are stored in `Resources/` and referenced through the strongly-typed `Properties.Resources` class generated from `Properties/Resources.resx`.
