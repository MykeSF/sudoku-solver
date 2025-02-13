# sudoku-solver
## C# Training Tasks in Visual Studio Code

![Sudoku board](images/screencap_board.png)
![Table of solved boards](images/screencap_table.png)

### Prerequisites

1. install VS Code extensions:
- C# Dev Kit
- SQL Server (mssql)
- Live Preview *(optional)*

2. install SQL Server 2017 Express (Standard) from
https://www.microsoft.com/en-us/download/details.aspx?id=55994

4. install .NET SDK (6.0.428 x64 installer) from
https://dotnet.microsoft.com/en-us/download/dotnet/6.0

6. install Entity Framework NuGet packages (via CLI):
- `dotnet new webapi -n SudokuAPI`
- `dotnet add package Microsoft.EntityFrameworkCore -v 6.0.36`
- `dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 6.0.36`
- `dotnet add package Microsoft.EntityFrameworkCore.Tools -v 6.0.36`
- `dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.36`
- `dotnet tool install --global dotnet-ef --version 6.0.36`

### Usage

1. execute `dotnet run` inside project root folder
2. run `index.html` *(optionally in Live Preview)*
3. enter numbers and use buttons as required

## Approach

### Task 1
copy code for index.html, styles.css, script.js from
https://www.codewithfaraz.com/content/269/sudoku-solver-with-html-css-and-javascript

### Task 2
connect to SQL Server, e.g., via connection string:
> "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;; Encrypt=true; Trust Server Certificate=true;"

copy Board.cs and BoardDBContext.cs, configure Program.cs and appsettings.json following
https://medium.com/@vndpal/how-to-connect-net-web-api-with-sql-server-using-entity-framework-code-first-approach-8564192485c9

execute `dotnet ef migrations add SolvedMigration` and then `dotnet ef database update` inside project root folder

enable CORS in Program.cs following
https://stackoverflow.com/questions/70511588/how-to-enable-cors-in-asp-net-core-6-0-web-api-project
**(for Live Preview, default port is 3000)**

configure url in first line of script.js according to "applicationUrl" in SudokuAPI/Properties/launchSettings.json
**(currently employed port is 7118)**

### Task 3
use plain HTML/CSS/JavaScript instead of DevExtreme
