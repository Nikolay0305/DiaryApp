# 📘 DiaryApp – Diary Entry Web Application

## 📌 Description

DiaryApp is an ASP.NET MVC web application that allows users to create and manage personal diary entries. It demonstrates software development practices such as CRUD operations, data persistence with Entity Framework Core, and a clean MVC architecture.

This project is intended for learning and demonstration purposes. It is not intended for production use and does not include authentication or encryption mechanisms.

---

## ✨ Features

- Create, view, edit, and delete diary entries
- Use of Entity Framework Core with SQL Server
- Clean MVC structure with separation of concerns
- Optional database seeding for demonstration

---

## ⚙️ How to Set Up the Connection String

1. **Clone** the repository to your local machine.
2. Open the project in Visual Studio (or your preferred IDE).
3. Locate the file named `example.json`.
4. **Rename** `example.json` to `appsettings.json`.
5. Open the new `appsettings.json` file and update your SQL Server connection string, for example:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=<your-server>;Database=<your-database>;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

## To ensure appsettings.json is available when the application runs follow these steps:
1. Go to Solution Explorer

2. Find appsettings.json and right-click on it

3. Go to Properties and Set "Copy to Output Directory" to "Copy if newer"

4. Save and Rebuild the Solution
   


## Restore NuGet Packages

1. Open the project in Visual Studio.
2. Right-click on the solution in Solution Explorer and click Restore NuGet Packages.
3. Alternatively, you can run this in the Package Manager Console:\
dotnet restore

4. Install required NuGet Packages
Run these commands:\
dotnet add package Microsoft.EntityFrameworkCore.SqlServer\
dotnet add package Microsoft.EntityFrameworkCore.Design\
dotnet add package Microsoft.EntityFrameworkCore.Tools\
or go to Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution and search for installs.

## Apply migrations and Update the Database

If the migrations haven’t been applied yet, you can update the database schema:

1. Open the **Package Manager Console** in Visual Studio and run:\
Update-Database


3. Alternatively, use the .NET CLI:\
dotnet ef database update

5. If you need to create a new migration, run:\
dotnet ef migrations add InitialMigration\
dotnet ef database update  


