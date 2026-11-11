<h1 align="center">Library Management System</h1>

<p align="center">
A desktop app that helps a small library keep track of its books, students, librarians, and who borrowed what.
I built this for my **Object Oriented Programming 2** course. The goal of the course was to stop writing "everything in one form" code and start thinking in classes, layers, and responsibilities. This project is where I practiced that. It is not a commercial product, but it does work end to end, and I learned a lot building it.
</p>

---

##  What it can do

### Admin
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

##  OOP ideas

The code is split into three layers, similar to MVC: **Models** (the data), **Controllers** (the middle layer), and **Views** (the Windows Forms screens). Here is how the OOP ideas from my course show up in it:

| Idea | Where you can see it |
|---|---|
| **Classes and objects** | Every entity is its own class (`Book`, `Student`, `Librarian`, `Admin`, `Borrow`, `Login`) and every screen is its own class (`Loginview`, `Registration`, `Adminhome`, `Managebook`, `Manageborrowbook`, and so on). Screens create other screen objects to open the next window and pass the logged-in `Login` object along. |
| **Encapsulation** | Model classes keep private fields and expose them through properties. Database connection code lives in one class, `SqlDbDataAccess`. Forms never write connection code or SQL; they call a controller such as `BookController.GetBookList()`. |
| **Abstraction** | The Views only know about the Controllers, and the Controllers only know about the `Database` class. A screen has no idea how or where the data is stored. |
| **Composition** | The `Database` class is built from the other objects: `Logins`, `Admins`, `Libririans`, `Students`, `Books` and `Borrows`. Each controller holds one `Database` object and delegates to it. |
| **Inheritance** | Every screen inherits from `System.Windows.Forms.Form`, so it gets windows, controls, and events for free. |
| **Reusability (DRY)** | The same `SqlDbDataAccess` class is used by every model to create its database commands. The same controllers serve every screen that needs books, students, or borrow records. |
| **Separation of concerns** | Layout code lives in the `*.Designer.cs` files and behaviour in the matching `.cs` file (partial classes). Data, logic, and screens live in separate folders. |
| **Event-driven programming** | Button clicks, row clicks in the grids, checkbox changes, and form loading all trigger event handlers. |

---

## Built with

* C# and Windows Forms (.NET Framework 4.7.2)
* Microsoft SQL Server and ADO.NET (`System.Data.SqlClient`)
* Visual Studio 2022

---

## Project structure

```
Library-Management-System/
├── Database/
│   └── Library_Database.sql        Creates the database, tables and sample data
└── Library Management System/
    ├── Program.cs                  Starts the app (opens the login screen)
    ├── App.config                  Runtime settings
    ├── Models/
    │   ├── SqlDbDataAccess.cs      Database connection helper (the one place for the connection string)
    │   ├── Database.cs             Groups all the data classes together
    │   ├── Login.cs, Logins.cs     User account entity + its database work
    │   ├── Admin.cs, Admins.cs     Admin entity + its database work
    │   ├── Librarian.cs, Libririans.cs
    │   ├── Student.cs, Students.cs
    │   ├── Book.cs, Books.cs
    │   └── Borrow.cs, Borrows.cs
    ├── Controllers/                Middle layer the screens talk to
    │   ├── LoginController.cs
    │   ├── AdminController.cs
    │   ├── LibrarianController.cs
    │   ├── StudentController.cs
    │   ├── BookController.cs
    │   └── BorrowController.cs
    ├── Views/
    │   ├── LoginView.cs            Sign in, opens the admin, librarian or student home
    │   ├── Registration.cs         Student sign-up
    │   ├── Adminhome.cs            Admin menu
    │   ├── Librarianhome.cs        Librarian menu
    │   ├── Studenthome.cs          Student menu
    │   ├── Managelibrarian.cs      Admin: librarians
    │   ├── Managebook.cs           Librarian: books
    │   ├── Managestudent.cs        Librarian: students
    │   ├── Manageborrowbook.cs     Librarian: issue and return books
    │   ├── Booklist.cs, StudentList.cs, Allbooksdetails.cs, Ownactivity.cs
    │   ├── Profile.cs, Librarianprofile.cs, Studentprofile.cs
    │   ├── Changepassword.cs, librarianchangepassword.cs, Studentchangepassword.cs
    │   └── *.Designer.cs           Layouts (open them in the Visual Studio designer)
    └── Properties/                 Assembly info and resources
```
