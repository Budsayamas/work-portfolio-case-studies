# Architecture Notes

This portfolio version describes the system at a high level without exposing internal company implementation details.

## Application Flow

1. Operator opens the desktop application.
2. Operator enters employee identifier and selects line or section.
3. Application validates required fields and employee status.
4. Application records eyesight screening result to SQL Server.
5. Report screen retrieves monthly records by date range and section.
6. Operator exports report data to an Excel workbook.

## Main Components

- **Windows Forms UI**: Login/data-entry screen and report screen.
- **Validation Logic**: Required field checks, employee status checks, selected line/period validation.
- **Data Access**: Parameterized SQL queries and stored procedure calls.
- **Reporting**: DataGridView display with user-friendly headers.
- **Excel Export**: ClosedXML inserts report data into a workbook template.

## Privacy Boundary

The public portfolio should describe the shape of the solution, not the exact private implementation. Use generic names such as:

- `EmployeeRecords`
- `ShiftPeriods`
- `ProductionLines`
- `GetActiveEmployee`
- `SaveEyesightRecord`
- `GetMonthlyEyesightReport`

Avoid publishing exact internal database object names or network details.
