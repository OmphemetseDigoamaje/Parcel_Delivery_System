# Parcel Delivery System Architecture

## 1. Overview
The system is a web-based application built using **ASP.NET Core MVC** and **Entity Framework Core**. Users interact with a front-end form to track parcels. Data is stored in a relational database.

## 2. Components

### 2.1 Model
- **Parcel**
  - `Id` (PK)
  - `TrackingNumber` (Unique)
  - `SenderName`
  - `ReceiverName`
  - `Status`

### 2.2 Controller
- Handles user requests:
  - Tracking form submission
  - Parcel management (CRUD operations)

### 2.3 View
- Displays parcel tracking form
- Shows parcel information or "Parcel not found" alert

### 2.4 Database
- Stores parcels
- Ensures `TrackingNumber` uniqueness

## 3. ERD (Entity-Relationship Diagram)

![ERD.png](architecture.png)

The ERD highlights:
- **Primary Key (PK)**: Id
- **Unique Constraint**: TrackingNumber