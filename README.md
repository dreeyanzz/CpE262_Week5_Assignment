# Student Management System

A Windows Forms application built with .NET 10, demonstrating multiple data structure implementations for student record management. Developed as a Week 5 programming assignment using CIT-U branding.

## Requirements

- Windows OS
- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- Visual Studio 2022+ (optional)

## Build & Run

```bash
# Build
dotnet build

# Run
dotnet run

# Build release
dotnet build -c Release
```

The solution file is `week-5-assignment.slnx` (new XML-based solution format).

## Features

The app has three tabs, each demonstrating a different data structure:

### Admin Tab — `DataTable`
- A `DataGridView` bound to a `DataTable` as its data source
- Predefined columns: `id`, `Student ID`, `Student Name`, `Institutional Email`, `Facebook Link`
- Add extra columns via dialog, add blank rows, or remove selected rows (with confirmation)
- Right-click a cell for per-cell alignment options or to clear cell contents
- Import/export records as CSV or JSON

### User Tab — Registration Form
- Input fields for Student ID, Student Name, Institutional Email, and Facebook Link
- Validates Student ID format (`YY-NNNN-NNN`), non-empty name, and `@cit.edu` email domain
- On success, appends the record to the shared `DataTable` (visible in Admin tab)

### List Tab — `List<string[]>`
- Same registration form and validation as the User tab
- Records stored as a `List<string[]>` (not data-bound)
- Grid is manually refreshed via `RefreshListGrid()` — row numbers are computed from list index and renumber automatically after deletions
- Grid is read-only with full-row selection; select a row and click Remove to delete
- Import/export records as CSV or JSON

## Project Structure

| File | Role |
|------|------|
| `Window.cs` / `Window.Designer.cs` | Main form with all three tabs; owns `dTable` (`DataTable`) and `studentList` (`List<string[]>`) |
| `AddColumnForm.cs` / `AddColumnForm.Designer.cs` | Modal dialog for adding a named column to the Admin tab |
| `ErrorForm.cs` / `ErrorForm.Designer.cs` | Modal error dialog; displays a message passed at construction |
| `Program.cs` | Entry point; launches `Window` |
| `Properties/Resources.resx` | Embedded resources (CIT-U seal image) |
| `Resources/` | Source image assets |

## Validation Rules

Student ID must match the format `YY-NNNN-NNN`:
- Three parts separated by `-`
- Part lengths: 2, 4, 3 digits respectively
- All characters in each part must be digits

Implemented without Regex — uses `Split('-')` and `char.IsDigit` checks.

## UI / Branding

CIT-U brand colors used throughout:

| Color | Hex / ARG | Usage |
|-------|-----------|-------|
| Maroon | `rgb(120, 0, 30)` | Primary — buttons, header, labels, grid headers, selection |
| Dark red | `rgb(160, 30, 30)` | Destructive actions (Remove Row button) |
| Gold | `rgb(255, 215, 100)` | Accent — system title label in header |

- **Header** (User tab): Maroon panel with CIT-U seal, school name (white, 20pt Bold), and system title (gold, 14pt)
- **Form cards**: White panels with `BorderStyle.FixedSingle` on a light-gray `rgb(242, 243, 247)` background
- **DataGridView**: White background, light-gray grid lines, maroon column/row headers
- **Dialogs**: White background, maroon labels and buttons, `FormBorderStyle.FixedDialog`, centered on parent
