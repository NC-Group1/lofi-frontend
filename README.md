# 🎧 Calico — LoFi Music & Productivity Platform

![Blazor](https://img.shields.io/badge/Framework-Blazor-512BD4?style=for-the-badge&logo=blazor&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![Razor Components](https://img.shields.io/badge/Frontend-Razor_Components-000000?style=for-the-badge)
![CSS](https://img.shields.io/badge/CSS-1572B6?style=for-the-badge&logo=css3&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white)
![JavaScript](https://img.shields.io/badge/JavaScript-F7DF1E?style=for-the-badge&logo=javascript&logoColor=black)
![YouTube API](https://img.shields.io/badge/YouTube_API-FF0000?style=for-the-badge&logo=youtube&logoColor=white)



Calico is a Blazor-based LoFi music and productivity platform built as part of a full‑stack group project.  
It blends **music discovery**, **playlist management**, **productivity tools**, and **dashboard summaries** into a single responsive UI.

# 🚀 Overview

Calico demonstrates modern .NET frontend development with:

* Reusable Blazor components

* Route‑based page composition

* Clean separation of concerns

* API‑driven communication

* Model‑driven UI binding

* A maintainable, scalable architecture

# 🧰 Tech Stack
| Area | Technologies |
| --- | --- |
| **Frontend** | ASP.NET Core Blazor |
| **Language** | C# |
| **UI Pattern** | Razor Components |
| **Backend Communication** | ``HttpClient`` / REST API |
| **Styling** | CSS |
| **Static Assets** | HTML, JS, images |
| **Media Integration** | YouTube API |
| **Optional Data** | Google Sheets API |
| **Testing** | Frontend + backend test projects |
| **Tools** | Visual Studio, GitHub, Figma, Canva, Diagrams.net |

# 🎯 Project Goals
The main goals of Calico were to:
- Build a responsive and maintainable frontend in Blazor.
- Practice component-based architecture.
- Integrate a frontend with a backend API in a clean and scalable way.
- Create a realistic product experience around music and productivity.
- Demonstrate professional structure, collaboration, and implementation quality.

## ♿ Accessibility

The frontend implements WCAG‑aligned accessibility features, including:

- Full keyboard navigation across interactive components  
- Semantic HTML structure for screen‑reader support  
- ARIA labels for buttons, menus, and media controls  
- Clear focus states and logical tab order  

These improvements ensure the Blazor UI is accessible and inclusive for all users.

# 🎵 Current Features
## Music Discovery
* Search and browse LoFi tracks.
* Display featured recommendations.

## Music Playback
* Embedded YouTube playback.
* Playlist integration.
* Audio streaming support.

## User Management
* User registration.
* Login and authentication.
* Password recovery.
* Account management.
* Profile updates.

## Productivity Tools
* Task timer functionality.
* Project tracking.
* Playlist organisation.

## Dashboard
* Favourite tracks summary.
* Playlist summary.
* Project summary.

# 🛠️ Planned Features

* Favourite tracks summary.
* Filter music by mood.
* Build progress bar component
* Pomodoro Timer


# 🏗️ Architecture
Calico follows a layered architecture designed to keep the frontend modular, testable, and easy to extend.

```text
User Interface
    ↓
Pages
    ↓
Reusable Components
    ↓
HTTP Client Services
    ↓
LoFi Backend API
```

The frontend is organised around reusable UI blocks, while API calls are handled through a scoped `HttpClient` configured in `Program.cs`. This approach keeps presentation, state, and data access separated clearly.

🧪 Testing
The solution includes test coverage for both frontend and backend behaviour.

### Frontend tests
* HTTP client behaviour.
* Blazor component logic.

# 🎨 Design & Planning

The project was shaped using the following design and planning tools:

* **UML / System Diagram:** [Diagrams.net UML](https://app.diagrams.net/?src=about#G1L9b1_PbgyJww05ia5cU2k545eBv4Tz0u#%7B%22pageId%22%3A%22zFB8Zg8bPfh-XyduNRbt%22%7D)
* **Project Ideation Board:** [Figma Board](https://www.figma.com/board/d5K37TfCV6h4RksMd0ROVu/LoFi-App---Project-Ideation?node-id=0-1&p=f&t=vbm8yFPVglo7MCjH-0)
* **UI / Visual Design:** [Canva Design](https://www.canva.com/design/DAHKxr2OHTw/RWMN95CV9L4hIf7RgaVTPQ/edit)

These documents capture the early product thinking, feature planning, and technical system design behind Calico.
