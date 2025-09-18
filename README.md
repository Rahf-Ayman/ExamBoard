# ExamBoard

ExamBoard is a web-based exam management system built with **Blazor Server**, **.NET 9**, and **SQL Server**.  
It allows creating, managing, and taking exams for students, tracking results, and managing questions and choices.

---

## Features

- Manage **Students**: Add, edit, and delete students.
- Manage **Questions**: Add questions with multiple choices and select the correct one.
- Create and take **Exams**.
- View **Exam Results**.
- Dashboard with exam statistics and user-friendly UI.
- Data validation and error handling.

---

## Tech Stack

- **Frontend / Backend:** Blazor Server with .NET 9
- **Database:** SQL Server
- **ORM:** Entity Framework Core
- **UI:** Bootstrap 5, custom CSS
- **Version Control:** Git

---

## Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (Express or Full)
- Visual Studio 2022 / VS Code

---

## Setup Instructions

### 1. Clone the repository

```bash
git clone https://github.com/yourusername/ExamBoard.git
cd ExamBoard
```

### 2. Apply Migrations

1. Open Terminal in VS Code or Package Manager Console in Visual Studio.

1. Run:

```bash
dotnet ef database update
```
This will create the database schema based on the current models.

### 3. Run the Project

```bash
dotnet run --project .\ExamBoard\ExamBoard.csproj
```
Open your browser at http://localhost:5125 .

## Project Structure
```bash
/ExamBoard
  /Components        # Razor components
  /Data              # DbContext and migrations
  /Models            # Entities: Student, Exam, Question, Choice, ExamQuestion
  /Pages             # Blazor pages
  /wwwroot           # CSS, JS, images

```
## Usage
- Students Page: Add, edit, delete students.
- Questions Page: Add multiple-choice questions.
- Exams Page: Create exams, take exams, view results.
- Dashboard: View statistics for students and exams.