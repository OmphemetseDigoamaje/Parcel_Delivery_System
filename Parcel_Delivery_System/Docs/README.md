# 📦 Parcel Delivery System

## 📌 Overview

The **Parcel Delivery System** is a web-based application developed using **ASP.NET Core MVC** and **Entity Framework Core**.  

The system allows users to track parcels using a unique tracking number and enables administrators to manage parcel records efficiently.

---

## 🚀 Features

### 👤 User Features
- Track parcel using tracking number
- View parcel details:
  - Tracking Number
  - Sender Name
  - Receiver Name
  - Status
- Displays *"Parcel not found"* if the tracking number does not exist

### 🔐 Admin Features
- Create new parcel
- Edit parcel information
- Delete parcel
- Enforce unique tracking numbers

---

## 🏗️ System Architecture

The system follows the **MVC (Model-View-Controller)** architectural pattern:

- **Model** → Defines database entities and validation rules  
- **View** → Provides user interface for tracking and managing parcels  
- **Controller** → Handles user requests and business logic  
- **Database** → Stores parcel data using Entity Framework Core  

See detailed documentation inside the `docs/` folder:
- `architecture.md`
- `requirements.md`

---

## 🗃️ Database Design

### Parcel Entity

| Field | Type | Description |
|-------|------|------------|
| Id | int | Primary Key |
| TrackingNumber | string | Unique tracking number |
| SenderName | string | Name of sender |
| ReceiverName | string | Name of receiver |
| Status | string | Parcel delivery status |

---

## 🗂️ Project Structure
