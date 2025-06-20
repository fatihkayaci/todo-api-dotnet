# 📋 Todo API - ASP.NET Core

A modern RESTful Web API built with **ASP.NET Core 8** demonstrating **Clean Architecture**, **Repository Pattern**, and industry best practices.

## 🚀 Features

- ✅ **Clean Architecture** with proper separation of concerns
- ✅ **Repository Pattern** for data access abstraction
- ✅ **Service Layer** for business logic
- ✅ **DTO Pattern** for API data transfer
- ✅ **Entity Framework Core** with SQL Server
- ✅ **Dependency Injection** throughout the application
- ✅ **Async/Await** for optimal performance
- ✅ **RESTful API** design principles
- ✅ **Swagger Documentation** for API testing
- ✅ **Proper HTTP Status Codes** and error handling

## 🏗️ Architecture

```
┌─────────────────┐
│   Controllers   │ ← HTTP Layer (API Endpoints)
└─────────────────┘
         │
┌─────────────────┐
│    Services     │ ← Business Logic + DTO Mapping
└─────────────────┘
         │
┌─────────────────┐
│  Repositories   │ ← Data Access Layer
└─────────────────┘
         │
┌─────────────────┐
│   Entity EF     │ ← Database Context
└─────────────────┘
```

## 🛠️ Tech Stack

- **Framework:** ASP.NET Core 8
- **Database:** SQL Server (LocalDB)
- **ORM:** Entity Framework Core
- **Documentation:** Swagger/OpenAPI
- **Architecture:** Clean Architecture
- **Patterns:** Repository, Service Layer, DTO

## 📁 Project Structure

```
TodoAPI/
├── Controllers/          # API Controllers
├── Services/            # Business Logic Layer
├── Repositories/        # Data Access Layer
├── DTOs/               # Data Transfer Objects
├── Models/             # Entity Models
├── Data/               # Database Context
├── Interfaces/         # Service & Repository Contracts
└── Migrations/         # EF Core Migrations
```

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [SQL Server LocalDB](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb) (comes with Visual Studio)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/fatihkayaci/todo-api-dotnet.git
   cd todo-api-dotnet
   ```

2. **Restore packages**
   ```bash
   dotnet restore
   ```

3. **Update database**
   ```bash
   dotnet ef database update
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

5. **Open Swagger UI**
   ```
   https://localhost:7148/swagger
   ```

## 📚 API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| `GET` | `/api/todo` | Get all todos |
| `GET` | `/api/todo/{id}` | Get todo by ID |
| `POST` | `/api/todo` | Create new todo |
| `PUT` | `/api/todo/{id}` | Update existing todo |
| `DELETE` | `/api/todo/{id}` | Delete todo |

### Example Requests

**Create Todo**
```json
POST /api/todo
{
  "title": "Learn ASP.NET Core",
  "description": "Study Clean Architecture patterns"
}
```

**Update Todo**
```json
PUT /api/todo/1
{
  "title": "Master ASP.NET Core",
  "isCompleted": true
}
```

## 🧪 Testing

Use the integrated **Swagger UI** at `/swagger` to test all endpoints interactively.

Alternatively, test with cURL:
```bash
# Get all todos
curl -X GET "https://localhost:7148/api/todo"

# Create a new todo
curl -X POST "https://localhost:7148/api/todo" \
  -H "Content-Type: application/json" \
  -d '{"title":"Test Todo","description":"Testing API"}'
```

## 💾 Database

The application uses **SQL Server LocalDB** with Entity Framework Core. The database is automatically created on first run.

**Connection String:** `Server=(localdb)\\mssqllocaldb;Database=TodoDB;Trusted_Connection=true`

## 🏛️ Design Patterns Used

- **Repository Pattern** - Abstracts data access logic
- **Service Layer Pattern** - Encapsulates business logic
- **DTO Pattern** - Separates internal models from API contracts
- **Dependency Injection** - Promotes loose coupling
- **Async/Await Pattern** - Non-blocking operations

## 📝 Key Learning Points

This project demonstrates:
- How to structure a **scalable Web API**
- **Separation of concerns** in Clean Architecture
- **Professional API design** with proper DTOs
- **Entity Framework** best practices
- **Dependency Injection** implementation
- **RESTful API** conventions

## 🤝 Contributing

1. Fork the project
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📧 Contact

**Fatih Kayacı** - [GitHub](https://github.com/fatihkayaci)

Project Link: [https://github.com/fatihkayaci/todo-api-dotnet](https://github.com/fatihkayaci/todo-api-dotnet)

---

⭐ **If you found this project helpful, please give it a star!**