# 📒 Contact Book — C#.NET Windows Forms

A fully functional desktop **Contact Management System** built as a practice project to apply **3-Tier Architecture**, **ADO.NET**, and **OOP** principles in a real Windows Forms application.

---

## 🖥️ Screenshots

> *(Add your screenshots here)*

---

## ✨ Features

- ➕ Add new contacts with full details
- ✏️ Edit existing contacts
- 🗑️ Delete contacts with confirmation dialog
- 🖼️ Upload and remove contact photo
- 🌍 Country dropdown loaded from database
- 🎨 Clean modern UI design

---

## 🏗️ Architecture

##  Architecture

###  3-Tier Architecture

        ┌──────────────────────────────────────────────────┐
        │            PRESENTATION LAYER                    │
        │         Windows Forms (Form1, Form2)             │
        │     Handles UI, user input and navigation        │
        └─────────────────────┬────────────────────────────┘
                              │
                              ▼
        ┌──────────────────────────────────────────────────┐
        │           BUSINESS LOGIC LAYER                   │
        │         clsContacts  ·  clsCountries             │
        │    Manages rules, modes (Add/Update), Save()     │
        └─────────────────────┬────────────────────────────┘
                              │
                              ▼
        ┌──────────────────────────────────────────────────┐
        │            DATA ACCESS LAYER                     │
        │  clsContactsDataLayer · clsCountriesDataLayer    │
        │   Connects to SQL Server via ADO.NET, runs SQL   │
        └─────────────────────┬────────────────────────────┘
                              │
                              ▼
        ┌──────────────────────────────────────────────────┐
        │              SQL SERVER DATABASE                 │
        │           Contacts  ·  Countries                 │
        └──────────────────────────────────────────────────┘

---

## 🛠️ Tech Stack

| Technology | Usage |
|---|---|
| C#.NET | Main programming language |
| Windows Forms | Desktop UI |
| ADO.NET | Database connectivity |
| SQL Server | Database |
| 3-Tier Architecture | Project structure |
| OOP | Code design |

---

## 🗄️ Database Tables

**Contacts**
| Column | Type |
|---|---|
| ContactID | INT (PK, Identity) |
| FirstName | NVARCHAR(50) |
| LastName | NVARCHAR(50) |
| Email | NVARCHAR(100) |
| Phone | NVARCHAR(20) |
| Address | NVARCHAR(200) |
| DateOfBirth | DATE |
| CountryID | INT (FK) |
| ImagePath | NVARCHAR(500) |

**Countries**
| Column | Type |
|---|---|
| CountryID | INT (PK, Identity) |
| CountryName | NVARCHAR(100) |
| Code | NVARCHAR(5) |
| PhoneCode | NVARCHAR(10) |

---

## 🚀 How to Run

1. Clone the repository
2. Open `Forms_PresintationLayer.sln` in Visual Studio
3. Create the database in SQL Server and run the table scripts above
4. Update the connection string in `clsDbSettings.cs`
5. Build and run the project

---

## 📚 What I Learned

- How to structure a project using 3-Tier Architecture
- Connecting C# to SQL Server using ADO.NET
- Working with `SqlConnection`, `SqlCommand`, `SqlDataReader`
- Using `DataTable` and `DataGridView`
- Building a real Windows Forms UI from scratch
- Handling NULL values from the database correctly

---

## 👨‍💻 Author

**Anas Aburshaid**  
[GitHub](https://github.com/AnasAburshaid) • [LinkedIn](https://www.linkedin.com/in/anas-aburshaid-950192367/)

---

> ⭐ If you found this project useful, feel free to star it!
