<div align="center">
  <img src="https://readme-typing-svg.demolab.com?font=Fira+Code&size=32&pause=1000&color=F5A623&center=true&vCenter=true&width=500&lines=🌍+TasteTheWorld" alt="TasteTheWorld" />

  <p>
    <strong>Discover the world's most iconic dishes, one city at a time.</strong>
  </p>

  <p>
    <img src="https://img.shields.io/badge/.NET-10.0-512BD4?style=flat-square&logo=dotnet&logoColor=white" />
    <img src="https://img.shields.io/badge/Bootstrap-5.3-7952B3?style=flat-square&logo=bootstrap&logoColor=white" />
    <img src="https://img.shields.io/badge/SQLite-EF%20Core-003B57?style=flat-square&logo=sqlite&logoColor=white" />
    <img src="https://img.shields.io/badge/C%23-ASP.NET%20MVC-239120?style=flat-square&logo=csharp&logoColor=white" />
    <img src="https://img.shields.io/badge/license-MIT-brightgreen?style=flat-square" />
  </p>

  <p>
    <a href="#-features">Features</a> •
    <a href="#-cities">Cities</a> •
    <a href="#-getting-started">Getting Started</a> •
    <a href="#-tech-stack">Tech Stack</a>
  </p>
</div>

---

## 🍽️ Overview

**TasteTheWorld** is a full-stack web application for food lovers and travelers. Explore iconic dishes from 15 cities across the globe, curate your personal food bucket list, and share your dining experiences with the community.

Whether you're planning your next trip or simply hungry for discovery — every city has a flavor worth finding.

---

## ✨ Features

<table>
  <tr>
    <td>🔍 <strong>Smart Search</strong></td>
    <td>Search foods by name or city with real-time filtering</td>
  </tr>
  <tr>
    <td>🏙️ <strong>City Explorer</strong></td>
    <td>Browse 15 cities and their signature dishes</td>
  </tr>
  <tr>
    <td>❤️ <strong>Bucket List</strong></td>
    <td>Save dishes you want to try, mark them as tried</td>
  </tr>
  <tr>
    <td>⭐ <strong>Reviews</strong></td>
    <td>Rate and review any dish you've experienced</td>
  </tr>
  <tr>
    <td>🔐 <strong>Authentication</strong></td>
    <td>Secure register & login with session management</td>
  </tr>
  <tr>
    <td>➕ <strong>Contribute</strong></td>
    <td>Add new dishes and help grow the collection</td>
  </tr>
  <tr>
    <td>📱 <strong>Responsive</strong></td>
    <td>Seamless experience on mobile, tablet, and desktop</td>
  </tr>
</table>

---

## 🌆 Cities

```
🇹🇷 Istanbul    🇯🇵 Tokyo       🇮🇹 Naples      🇹🇭 Bangkok     🇫🇷 Paris
🇪🇸 Madrid      🇪🇸 Barcelona   🇺🇸 New York    🇦🇪 Dubai       🇸🇬 Singapore
🇩🇪 Berlin      🇮🇳 Mumbai      🇵🇪 Lima        🇲🇽 Mexico City  🇲🇦 Marrakech
```

---

## 🛠️ Tech Stack

| Layer | Technology |
|---|---|
| Framework | ASP.NET Core MVC (.NET 10) |
| ORM | Entity Framework Core |
| Database | SQLite (Code First + Migrations) |
| UI | Bootstrap 5, Bootstrap Icons |
| Scripting | JavaScript (Vanilla) |
| Auth | Session-based |

---

## 🚀 Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- [EF Core CLI Tools](https://learn.microsoft.com/en-us/ef/core/cli/dotnet)

```bash
dotnet tool install --global dotnet-ef
```

### Installation

```bash
# 1. Clone the repository
git clone https://github.com/YOUR_USERNAME/Taste-The-World.git
cd Taste-The-World

# 2. Restore dependencies
dotnet restore

# 3. Apply database migrations
dotnet ef database update

# 4. Run the application
dotnet run
```

Visit `https://localhost:5128` in your browser.

> 💡 **Tip:** Add images to `wwwroot/images/cities/` and `wwwroot/images/foods/` for the full visual experience.

---

## 📂 Project Structure

```
TasteTheWorld/
├── Controllers/          # Request handling & business logic
├── Data/                 # AppDbContext + seed data
├── Models/               # Food, City, User, BucketList, Review
├── Views/                # Razor views (.cshtml)
│   ├── Home/
│   ├── Food/
│   ├── City/
│   ├── BucketList/
│   ├── Account/
│   └── Shared/
├── Migrations/           # EF Core database migrations
├── wwwroot/              # Static assets (CSS, JS, images)
├── Program.cs
└── TasteTheWorld.csproj
```



<div align="center">
  <p>Made with ❤️ by <a href="https://github.com/gulcinyzglc"><strong>Gülçin Yüzgüleç</strong></a></p>
</div>
