<div align="center">

# 🌍 TasteTheWorld

**Discover the world's most iconic dishes, one city at a time.**

<p>
  <img src="https://img.shields.io/badge/.NET-10.0-512BD4?style=flat-square&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/Bootstrap-5.3-7952B3?style=flat-square&logo=bootstrap&logoColor=white" />
  <img src="https://img.shields.io/badge/SQLite-EF%20Core-003B57?style=flat-square&logo=sqlite&logoColor=white" />
  <img src="https://img.shields.io/badge/C%23-ASP.NET%20MVC-239120?style=flat-square&logo=csharp&logoColor=white" />
</p>

<p>
  <a href="#-overview">Overview</a> •
  <a href="#-features">Features</a> •
  <a href="#-getting-started">Getting Started</a> •
  <a href="#-architecture">Architecture</a>
</p>

</div>

---

## 📖 Overview

**TasteTheWorld** is a full-stack web application built with **ASP.NET Core MVC** and **Entity Framework Core**. It allows users to explore iconic dishes from 15 cities around the world, manage a personal food bucket list, and write reviews.

The app follows the **MVC pattern** with a **Code First** database approach using **SQLite**. Authentication is handled via **ASP.NET Core Session**. All data is seeded automatically on first run through EF Core migrations.

---

## ✨ Features

| Feature | Details |
|---|---|
| 🔍 Search & Filter | Filter by name, city, category, spicy, or vegetarian |
| 🏙️ City Explorer | 15 cities with dedicated pages and dish listings |
| ❤️ Bucket List | Per-user saved dishes with tried/untried tracking |
| ⭐ Reviews | Star ratings and comments per dish |
| 🔐 Auth | Register, login, logout with session management |
| ➕ CRUD | Full create, read, update, delete for foods |
| 📱 Responsive | Bootstrap 5 grid — mobile, tablet, desktop |

---

## 🛠️ Tech Stack

| Layer | Technology |
|---|---|
| Framework | ASP.NET Core MVC (.NET 10) |
| ORM | Entity Framework Core 9 |
| Database | SQLite — Code First with Migrations |
| UI | Bootstrap 5.3, Bootstrap Icons |
| Auth | ASP.NET Core Session |
| Frontend Logic | Vanilla JavaScript — DOM manipulation, form validation |

---

## 🚀 Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- EF Core CLI:

```bash
dotnet tool install --global dotnet-ef
```

### Run Locally

```bash
git clone https://github.com/gulcinyzglc/Taste-The-World.git
cd Taste-The-World
dotnet restore
dotnet ef database update
dotnet run
```

Open `https://localhost:5128` in your browser.

> 💡 Place city images in `wwwroot/images/cities/` and food images in `wwwroot/images/foods/` — the app falls back to emojis if images are missing.

---

## 🏗️ Architecture

```
TasteTheWorld/
├── Controllers/
│   ├── AccountController.cs        # Register, Login, Logout
│   ├── BucketListController.cs     # Index, Toggle, MarkTried
│   ├── CityController.cs           # Index, Details
│   ├── FoodController.cs           # Index, Details, Create, Edit, Delete, AddReview
│   └── HomeController.cs           # Index, About
│
├── Data/
│   └── AppDbContext.cs             # DbContext + seed data (15 cities, 40 foods)
│
├── Migrations/
│   └── InitialCreate               # EF Core initial migration
│
├── Models/
│   ├── BucketList.cs               # BucketList + Review models
│   ├── City.cs
│   ├── ErrorViewModel.cs
│   ├── Food.cs
│   └── User.cs
│
├── Views/
│   ├── Account/                    # Login, Register
│   ├── BucketList/                 # Index
│   ├── City/                       # Index, Details
│   ├── Food/                       # Index, Details, Create, Edit
│   ├── Home/                       # Index, About
│   └── Shared/                     # _Layout, _ViewImports, _ViewStart
│
├── wwwroot/
│   ├── css/site.css
│   ├── js/site.js
│   └── images/
│       ├── cities/
│       └── foods/
│
├── Properties/
│   └── launchSettings.json
├── Program.cs
└── TasteTheWorld.csproj
```

---

## 🌆 Cities

```
🇹🇷 Istanbul   🇯🇵 Tokyo      🇮🇹 Naples     🇹🇭 Bangkok    🇫🇷 Paris
🇪🇸 Madrid     🇪🇸 Barcelona  🇺🇸 New York   🇦🇪 Dubai      🇸🇬 Singapore
🇩🇪 Berlin     🇮🇳 Mumbai     🇵🇪 Lima       🇲🇽 Mexico City 🇲🇦 Marrakech
```

---



## 👩‍💻 Author

Gülçin Yüzügüleç

3rd Year Computer Engineering Student

ASP.NET Core MVC | C# | SQL | Web Development
