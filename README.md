# Music Venue Management API

A lightweight C# ASP.NET Core Web API built to manage venue equipment inventory and band applications. 

This project was built during my early deep dive into backend architecture, focusing on the core separation between internal domain models and external client payloads.

---

## 🛠️ Key Architectural Concepts Learned

* **DTO Pattern (Data Transfer Objects):** Separating internal domain entities from public data schemas.
* **Data Protection & Privacy:** Hiding sensitive properties (like `PurchasePrice` and `ContactEmail`) from public response DTOs (`EquipmentResponseDto`, `BandResponseDto`).
* **Input Guardrails & Validation:** Using Data Annotations (e.g., `[Required]`, `[MinLength]`, `[EmailAddress]`) on incoming payloads (`BandCreateDto`, `EquipmentCreateDto`).
* **Static In-Memory Data Services:** Simulating persistent state in `EquipmentService` and `BandService` without direct database coupling.
* **Type Safety with Enums:** Enforcing strictly typed states (`EquipmentCondition`, `Genre`).

---

## 🚀 Features & Endpoints

### 1. Equipment Manager Module
* **Enums:** `BrandNew`, `Used`, `Broken`
* **GET `/api/equipment`:** Returns public equipment details (hides purchase price).
* **POST `/api/equipment`:** Creates new equipment entries with auto-generated IDs and price validation ($>0$).

### 2. Band Booking Agent Module
* **Enums:** `Rock`, `Grunge`, `Metal`
* **GET `/api/bands`:** Lists all bands for the public view (hides private contact emails).
* **POST `/api/bands`:** Accepts band applications, enforces email/name validation, and sets `IsApproved = false` by default for manager review.

---

## 💻 Tech Stack
* **Language:** C#
* **Framework:** .NET / ASP.NET Core Web API
* **Data Storage:** In-Memory Static Lists
