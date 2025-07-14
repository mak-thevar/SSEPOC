# SSEPOC

A .NET 8 ASP.NET Core MVC application that demonstrates real-time updates using Server-Sent Events (SSE) with a Clean Architecture approach.

[![Contributors][contributors-shield]][contributors-url]
[![Issues][issues-shield]][issues-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

## 📋 Table of Contents
* [Getting Started](#-getting-started)
* [File Structure](#-file-structure)
* [Installation](#installation)
* [Features](#-features)
* [Contributing](#-contributing)
* [Screenshots](#-screenshots)
* [License](#-license)
* [Contact](#-contact)

## 🏁 Getting Started
### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio](https://visualstudio.microsoft.com/) OR [Visual Studio Code](https://code.visualstudio.com/)

## 🗃️ File Structure
```
├───SseDemo.Application
│   ├───Interfaces
│   │       IAppDbContext.cs
│   │
│   └───DependencyInjection.cs
│
├───SseDemo.Domain
│   └───Entities
│           Feed.cs
│
├───SseDemo.Infrastructure
│   │   DependencyInjection.cs
│   └───Persistence
│           AppDbContext.cs
│           DataSeeder.cs
│
└───SseDemo (Presentation)
    │   Program.cs
    ├───Controllers
    │       SseController.cs
    └───Views
        ├───Sse
        │       Index.cshtml
        └───Shared
                _Layout.cshtml
```

## Installation
- Clone the repository
```sh
git clone <repository-url>
```
- Open the solution file `SseDemoSolution.sln` directly in Visual Studio.
- Build and run the project. The in-memory database will be seeded automatically.

## ✅ Features
- **Server-Sent Events (SSE):** Demonstrates real-time, unidirectional communication from the server to the client.
- **Clean Architecture:** Separates the solution into `Domain`, `Application`, `Infrastructure`, and `Presentation` layers for a decoupled and maintainable design.
- **Entity Framework Core (In-Memory):** Uses an in-memory database for easy setup and demonstration purposes.
- **jQuery & jQuery UI:** Provides a smooth and visually appealing user experience with animations.

## 🔘 Contributing
Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📸 Screenshots
*(Placeholder for screenshots of the application in action)*

## 🎫 License
Distributed under the MIT License.

## 📱 Contact
- Name: Muthukumar
- Email: mak.thevar@outlook.com
- Project Link: [https://github.com/mak-thevar/SSEPOC](https://github.com/mak-thevar/SSEPOC)

[contributors-shield]: https://img.shields.io/github/contributors/mak-thevar/SSEPOC.svg?style=flat-square
[contributors-url]: https://github.com/mak-thevar/SSEPOC/graphs/contributors
[issues-shield]: https://img.shields.io/github/issues/mak-thevar/SSEPOC.svg?style=flat-square
[issues-url]: https://github.com/mak-thevar/SSEPOC/issues
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=flat-square&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/your-linkedin-profile/