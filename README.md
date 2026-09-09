# MediTrack – Patient Record Management System

MediTrack is a desktop based **Patient Record Management System (PRMS)** developed using **C# Windows Forms** and **SQL Server Express LocalDB**.

The system is designed to digitally manage patient medical records and appointments while providing separate functionality for doctors and patients. It replaces traditional paper based record management with a structured, searchable, and user friendly desktop application.

---

## Project Overview

MediTrack provides a centralized desktop application for managing patient information, medical records, doctors, and appointments.

The system supports two main types of users:

- **Doctor**
- **Patient**

Doctors can manage their patients' records and appointments, while patients can access their own medical information and interact with the appointment system.

The application uses a relational SQL Server database with foreign key relationships to maintain data consistency.

---

## Objectives

The main objectives of MediTrack are:

- Develop a desktop based patient record management system.
- Digitally manage patient medical records.
- Provide secure doctor and patient authentication.
- Allow doctors to manage patient records.
- Restrict doctors to their relevant patient records.
- Allow patients to view their own medical information.
- Provide appointment management functionality.
- Support searching, sorting, and filtering of records.
- Reduce dependency on manual paper-based records.
- Provide a simple and user friendly interface.
- Store application data in a relational SQL Server database.

---

## Main Features

### Doctor Features

Doctors can:

- Register an account.
- Log in to the system.
- Access the Doctor Dashboard.
- Add patient records.
- View patient records.
- Update patient information.
- Delete patient records.
- Search patient records.
- Filter and sort records.
- Manage appointments.
- View appointment information.
- Generate/view summaries.
- Generate PDF reports.

### Patient Features

Patients can:

- Log in to the system.
- Access the Patient Dashboard.
- View their medical record.
- View doctor information.
- Book appointments.
- View appointment information and history.
- Export medical information to PDF where supported by the application.

---

## Authentication and Access Control

MediTrack provides separate login functionality for doctors and patients.

The system is designed so that:

- Doctors access doctor specific functionality.
- Patients access patient specific functionality.
- Doctors can work with the patient records associated with them.
- Patients can access their own records.

This separation helps prevent users from accessing functionality intended for another user type.

---

## Technology Stack

- **Language:** C#
- **Application:** Windows Forms
- **Framework:** .NET Framework 4.7.2
- **Database:** SQL Server Express LocalDB
- **Database Access:** ADO.NET
- **Installer:** Visual Studio Installer Projects
- **Database Script:** T-SQL

---

## System Requirements

- Windows operating system
- .NET Framework 4.7.2
- SQL Server Express LocalDB
- Sufficient disk space for the application and database

---

## Installation

1. Download **`setup.exe`** from the GitHub Release.
2. Run `setup.exe`.
3. Follow the installation wizard.
4. Launch **MediTrack** from the Desktop or Start Menu.
5. On first launch, the application automatically creates the required database.

> **Note:** The `.msi` file is also provided in the release for advanced/manual installation. `setup.exe` is recommended for normal users.

---

## Database

MediTrack uses **SQL Server Express LocalDB**.

### Main Tables

- `Doctor`
- `Patient`
- `Appointments`

The database is automatically created using:

```text
Database/CreateDatabase.sql
```

---

## Academic Information

- **Project:** Patient Record Management System
- **Product Name:** MediTrack
- **Program:** BS Computer Science
- **Department:** Computer Science
- **Institution:** PARS, University of Agriculture, Faisalabad
- **Class:** BS Computer Science (Morning)
- **Section:** B

---

## License

This project was developed as an academic project.
Unless a separate license is provided in the repository, the source code should be treated as all rights reserved by the project author.

---

## Author

**Muhammad Zain Khalid**
