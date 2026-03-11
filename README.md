Personal Info Management System

A simple ASP.NET CORE MVC CRUD application that manages personal information records. The system allows users to create, view, update, and delete personal records with a searchable and paginated data table.
This project demonstrates a clean MVC architecture, Entity Framework Core Code-First approach, and jQuery DataTables integration.

Project Features

. Create personal information
. Edit personal information
. Delete personal information
. View all records
. DataTables integration
. Pagination
. Searching
. Column sorting
. Form validation

Architecture

The project follows MVC Architecture.

Controllers
    PersonalInfoController.cs

Models
    PersonalInfo.cs

Data
    ApplicationDbContext.cs
    SeedData.cs

Views
    PersonalInfo
        Index.cshtml
        Create.cshtml
        Edit.cshtml

Setup Instructions

Follow these steps to run the project locally.

1 Clone the Repository
git clone https://github.com/ARASIF1-6/PersonalInfoManageSystem.git

2 Open Project
Open the project in:
Visual Studio 2022

Database Configuration

Open appsettings.json

Update SQL Server connection string:

"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=PersonalInfoDB;Trusted_Connection=True;TrustServerCertificate=True;"
}

Example:
Server=.;Database=PersonalInfoDB;Trusted_Connection=True;TrustServerCertificate=True;


Create Database (Code First)

Open Package Manager Console

Run the following commands:

Add-Migration InitialCreate
Update-Database

This will create the database automatically using Entity Framework Code First.

SweetAlert confirmation for delete

Dummy data generation (Seed Data)

Generate Dummy Data

The project includes a SeedData class that generates 1000 dummy records.

Seed data runs automatically when the application starts.

Example fields generated:
. Name
. Email
. Phone
. Nationality
. Date of Birth

Steps to Run the Project

1. Clone the repository
2. Open project in Visual Studio
3. Configure database connection string
4. Run migration commands
5. Build the project
6. Press F5 or click Run

Application will start in browser.
