<h1 align="center">Library Management System</h1>

<p align="center">
A desktop app that helps a small library keep track of its **books**, **students**, **librarians**, and **who borrowed what**.

I built this for my **Object Oriented Programming 2** course. The goal of the course was to stop writing "everything in one form" code and start thinking in classes, layers, and responsibilities. This project is where I practiced that. It is not a commercial product, but it does work end to end, and I learned a lot building it.
</p>
---
## What it can do

###  Admin
- Add, update, and remove **librarians**
- See the full **book list** and **student list**
- View and edit their own profile
- Change their password

###  Librarian
- **Manage books**: add new ones, update the title and number of copies, remove old ones
- **Manage students**: add, update, and remove student accounts
- **Manage borrowed books**: issue a book to a student and mark it as returned
- View and edit their own profile and change their password

###  Student
- **Register** a new account straight from the login screen
- Browse and **search all books**
- See their **own borrowing activity**
- View and edit their own profile and change their password
- 
--- 

## 💡 Why I built it

Libraries still run on paper registers and spreadsheets a lot of the time. Someone borrows a book, someone forgets to write it down, and a week later nobody knows where the book went.

I wanted to build something simple that answers three questions quickly:

- **What books do we have?**
- **Who is allowed to do what?** (the admin, the librarian, and the student should not see the same screens)
- **Who has borrowed a book, and has it been returned?**

---

## ✨ What it can do

The app has **three kinds of users**. Each one logs in and sees a different home screen.

---

## 🧱 How it's put together (the OOP part)

This is the part my course cared about most, so here is how I structured it. The code is split into three layers, similar to MVC:

```
Library Management System/
├── Models/        → what the data is, and how it is saved/loaded
├── Controllers/   → the middle layer the screens talk to
└── Views/         → the Windows Forms screens (what the user sees)
```

**Models** are plain classes like `Book`, `Student`, `Librarian`, `Admin`, `Borrow`, and `Login`. They hold data through properties. Next to each one is a "collection" class (`Books`, `Students`, `Borrows`, and so on) that talks to the database for that entity.

**Controllers** (`BookController`, `StudentController`, `BorrowController`, and so on) sit between the screens and the models. A form never touches SQL directly. It just calls something like `BookController.GetBookList()`.

**Views** are the forms: login, registration, the three home screens, and the manage/profile/change-password screens.

A few OOP ideas you can spot in the code:

| Concept | Where you can see it |
|---|---|
| **Encapsulation** | Models keep private fields and expose them through properties |
| **Abstraction** | Forms only know about controllers, not about SQL |
| **Composition** | The `Database` class is made up of `Logins`, `Students`, `Books`, `Borrows`, and the others |
| **Inheritance** | Every screen inherits from `System.Windows.Forms.Form` |
| **Single responsibility** | One class per entity, and one place (`SqlDbDataAccess`) that creates database commands |
| **Reuse** | All database access goes through one data access class |

---

## 🛠️ Built with

- **C#** on **.NET Framework 4.7.2**
- **Windows Forms** for the user interface
- **Microsoft SQL Server** for storage
- **ADO.NET** (`System.Data.SqlClient`) for database access
- **Visual Studio** as the IDE
