# Personal Info Management System

A simple **ASP.NET MVC CRUD application** that manages personal information records.  
The system allows users to **create, view, update, and delete personal records** with a searchable and paginated data table.

This project demonstrates a clean **MVC architecture**, **Entity Framework Code-First approach**, and **jQuery DataTables integration**.

---

## Features

- Create personal information
- Edit personal information
- Delete personal information
- View all records
- Pagination using jQuery DataTables
- Searching functionality
- Column sorting
- Form validation
- SweetAlert delete confirmation
- Dummy data generation (Seed Data)

---

## Technologies Used

| Technology | Description |
|------------|-------------|
| ASP.NET MVC | Web framework |
| C# | Backend language |
| Entity Framework | ORM (Code First) |
| SQL Server | Database |
| jQuery | JavaScript library |
| jQuery DataTables | Table pagination, search, sorting |
| Bootstrap | UI styling |
| SweetAlert | Delete confirmation popup |

---

## Project Architecture

The project follows **MVC Architecture**.

```
Controllers
│
├── PersonalInfoController.cs
│
Models
│
├── PersonalInfo.cs
│
Data
│
├── ApplicationDbContext.cs
├── SeedData.cs
│
Views
│
├── PersonalInfo
│   ├── Index.cshtml
│   ├── Create.cshtml
│   └── Edit.cshtml
│
wwwroot
│
├── css
├── js
```

---

## Database Model

Table: **PersonalInfos**

| Column | Type |
|------|------|
| Id | int (Primary Key) |
| FirstName | string |
| LastName | string |
| Email | string |
| PhoneNumber | string |
| DateOfBirth | datetime |
| Gender | string |
| Address | string |
| Nationality | string |
| CreatedDate | datetime |

---

## Setup Instructions

Follow these steps to run the project locally.

### 1. Clone the Repository

```bash
git clone https://github.com/ARASIF1-6/PersonalInfoManageSystem.git
```

### 2. Open the Project

Open the project using:

```
Visual Studio 2022
```

---

## Database Configuration

Open **appsettings.json** and update the connection string:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=PersonalInfoDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

Example:

```json
Server=.;Database=PersonalInfoDB;Trusted_Connection=True;TrustServerCertificate=True;
```

---

## Create Database (Code First)

Open **Package Manager Console** and run:

```powershell
Add-Migration InitialCreate
Update-Database
```

This will automatically create the database using **Entity Framework Code First**.

---

## Dummy Data Generation

The project includes a **SeedData class** that generates **1000 dummy records** automatically.

Example generated data:

- First Name
- Last Name
- Email
- Phone Number
- Nationality
- Date of Birth

---

## Steps to Run the Project

1. Clone the repository
2. Open the project in Visual Studio
3. Configure database connection string
4. Run migration commands
5. Build the project
6. Press **F5** or click **Run**

The application will open in the browser.

---

## UI Pages

| Page | Description |
|-----|-------------|
| Index | Displays all personal information records |
| Create | Form to add new personal information |
| Edit | Form to update existing information |

---

## DataTable Features

The list page uses **jQuery DataTables** with:

- Pagination
- Searching
- Column Sorting

Example configuration:

```javascript
$('#infoTable').DataTable({
 paging: true,
 searching: true,
 ordering: true
});
```

---

## CRUD Operations

| Operation | Description |
|----------|-------------|
| Create | Add new personal information |
| Read | View all records |
| Update | Edit personal data |
| Delete | Remove record with confirmation |

---

## License

This project was created for **technical assessment / interview assignment purposes**.
