# e-Shift Management System

## 📖 Introduction

The **e-Shift Management System** is a comprehensive Windows Forms desktop application designed to streamline the operations of a household goods shifting company. Built with modern .NET technologies, this system provides a robust solution for managing customers, jobs, transport logistics, and reporting, catering to both administrative staff and registered customers.

The application is architected using the **Repository Pattern** and a **Service Layer** to ensure a clean separation of concerns, making it scalable, maintainable, and easy to test.

---

## ✨ Features

The application provides two primary user roles with distinct functionalities:

### 👨‍💼 Admin Features
- **Admin Dashboard**: A central hub to view and process new job requests from customers.
- **Job Processing**:
    - Review job details submitted by customers.
    - Add multiple loads (shipments) to a single job.
    - Assign a complete transport unit (Lorry, Driver, Assistant) to each load.
    - Update the status of a job (e.g., "In Progress", "Completed").
- **CRUD Management**: Full Create, Read, Update, and Delete capabilities for:
    - Customers
    - Drivers
    - Assistants
    - Lorries
- **Reporting**:
    - View a complete history of all jobs.
    - Search and filter jobs based on various criteria.
    - (Future) Export job data to Excel sheets for analysis.

### 🧑 Customer Features
- **Secure Login & Registration**: Customers can create a new account and log in securely.
- **Customer Dashboard**: A personalized portal for customers to manage their shifting needs.
- **Place New Orders**: An intuitive form to request a new job by providing:
    - Pickup and destination addresses.
    - Preferred date.
    - A detailed description of the goods to be transported.
    - Estimated weight and volume of the goods.
- **Order History**: View a complete list of all past and current jobs, including their real-time status.

---

## 💻 Technology Stack

- **Framework**: .NET 9
- **Application Type**: Windows Forms (WinForms)
- **Database**: MySQL Server
- **ORM**: Entity Framework Core 8/9
- **Architecture**:
    - Repository Pattern
    - Service Layer
    - Dependency Injection
- **Language**: C# 12

---

## 🛠️ Getting Started

Follow these instructions to set up and run the project on your local machine.

### Prerequisites
- **Visual Studio 2022** (or later)
- **.NET 9 SDK** (or the version targeted by the project)
- **MySQL Server** and a management tool like **MySQL Workbench**.

### 1. Database Setup
1.  Open MySQL Workbench and connect to your local server.
2.  Create a new schema (database) named `e_shift_db`.
3.  Run the SQL scripts provided in the project to create all the necessary tables.
4.  Run the dummy data scripts to populate the database with initial records for testing.
5.  **Crucially**, create the default Admin user by running the provided SQL `INSERT` statement.

### 2. Project Configuration
1.  Clone this repository to your local machine.
2.  Open the `eShift.sln` file in Visual Studio.
3.  Locate the `appsettings.json` file in the main project.
4.  Update the `DefaultConnection` string with your MySQL server details (server address, username, and password).
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "server=localhost;port=3306;database=e_shift_db;user=your_user;password=your_password"
    }
    ```
5.  **Hashing the Admin Password**:
    - The default admin password is `admin123`. You need to generate a hash for it.
    - Use the `PasswordHelper.HashPassword("admin123")` method to get the hash string.
    - Manually update the `PasswordHash` column for the admin user in the `Customers` table with this generated hash.

### 3. Build and Run
1.  Build the solution in Visual Studio (`Build > Build Solution`).
2.  Press `F5` or click the "Start" button to run the application.
3.  The login window should appear.

---

## 🔑 Default Login Credentials

- **Admin Account:**
    - **Email:** `admin@eshift.com`
    - **Password:** `admin123`

- **Sample Customer Account:**
    - **Email:** `nimal.p@email.com`
    - **Password:** `customer123` (You will need to register this user or set their password hash manually in the DB for testing).

---

## 📂 Project Structure

The project follows a clean architecture to separate responsibilities:

- `/Data`: Contains the `AppDbContext`, repository interfaces (`IRepository`), and their implementations.
- `/Models`: Contains the C# classes that represent the database tables (e.g., `Customer.cs`, `Job.cs`).
- `/View`: Contains all the WinForms UI files (`.cs` and `.Designer.cs`).
- `/Services`: (If implemented) Contains business logic classes that orchestrate repository operations.
- `appsettings.json`: For application configuration, primarily the database connection string.
- `Program.cs`: The main entry point of the application, responsible for setting up dependency injection and the application's startup flow.
