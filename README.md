# 🍽️ FoodHUB

A restaurant web application built with **ASP.NET MVC 5** and **.NET Framework 4.8**. FoodHUB offers a full dining experience online — from browsing the menu to making a table reservation.

---

## 🚀 Features

- **Home** — Landing page with a hero section and call-to-action buttons
- **Menu** — Full restaurant menu organized by category (Starters, Mains, Pasta, Grill, Desserts, Drinks) with pricing, dietary tags, and popular item highlights
- **Reservations** — Table booking form with date validation and a confirmation page
- **About** — Restaurant story and information
- **Contact** — Contact form for customer enquiries

---

## 🛠️ Tech Stack

| Technology | Details |
|---|---|
| Language | C# |
| Framework | ASP.NET MVC 5 |
| .NET Version | .NET Framework 4.8 |
| View Engine | Razor (.cshtml) |
| Styling | HTML / CSS |
| Server | IIS Express |

---

## 📁 Project Structure

```
FoodHUB/
├── Controllers/
│   ├── HomeController.cs
│   ├── MenuController.cs
│   ├── ReservationController.cs
│   ├── AboutController.cs
│   └── ContactController.cs
├── Models/
│   ├── FoodItem.cs
│   ├── Reservation.cs
│   └── ContactMessage.cs
├── Views/
│   ├── Home/
│   ├── Menu/
│   ├── Reservation/
│   ├── About/
│   ├── Contact/
│   └── Shared/
├── Content/
│   └── site.css
├── App_Start/
│   └── RouteConfig.cs
└── Web.config
```

---

## ⚙️ Getting Started

### Prerequisites
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) with the **ASP.NET and web development** workload installed
- .NET Framework 4.8

### Running the project
1. Clone the repository
2. Open `FoodHUB.sln` in Visual Studio
3. Right-click the project → **Restore NuGet Packages**
4. Press **F5** to build and run

The app will launch in your browser at `localhost` via IIS Express.

---

## 📸 Pages

- `/` — Home
- `/Menu` — Full menu
- `/Reservation` — Book a table
- `/About` — About us
- `/Contact` — Get in touch
