# ASP.NET Core Login with Session & Database

This project demonstrates a **session-based authentication system** in **ASP.NET Core** using a **database-backed login**, session management, and logout functionality.  
It is designed as a **learning/demo project** to understand how custom authentication works without ASP.NET Core Identity.

---

## 🚀 Features

- User Login with database validation
- Session-based authentication
- Secure Logout
- SQL Server database integration
- ASP.NET Core MVC architecture
- Simple and clean implementation

---

## 🛠️ Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Session State
- Bootstrap (optional for UI)

---

## 📂 Project Structure

```

├── Controllers
│   └── AccountController.cs
├── Models
│   └── User.cs
├── Data
│   └── ApplicationDbContext.cs
├── Views
│   └── Account
│       ├── Login.cshtml
│       └── Dashboard.cshtml
├── appsettings.json
└── Program.cs


## ⚙️ Configuration

### 1. Database Connection

Update the connection string in `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=YOUR_DATABASE;Trusted_Connection=True;TrustServerCertificate=True;"
}



### 2. Enable Session in `Program.cs`

```csharp
builder.Services.AddSession();

app.UseSession();


## 🔐 How Authentication Works

1. User submits login credentials
2. Credentials are validated against the database
3. User data is stored in session
4. Protected pages check session before access
5. Logout clears the session

---

## ▶️ How to Run the Project

1. Clone the repository
2. Open the solution in Visual Studio
3. Update the database connection string
4. Run database migrations (if applicable)
5. Press **F5** to run the application
