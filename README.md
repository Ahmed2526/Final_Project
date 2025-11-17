<div align="center">

# 🏥 MedLink API

### A comprehensive medical appointment management system built with ASP.NET Core

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet)](https://dotnet.microsoft.com/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)](https://www.microsoft.com/sql-server)
[![JWT](https://img.shields.io/badge/JWT-000000?style=for-the-badge&logo=JSON%20web%20tokens&logoColor=white)](https://jwt.io/)
[![SendGrid](https://img.shields.io/badge/SendGrid-3368C7?style=for-the-badge&logo=twilio&logoColor=white)](https://sendgrid.com/)

[Features](#-key-features) • [Architecture](#%EF%B8%8F-architecture) • [Tech Stack](#%EF%B8%8F-tech-stack)

**🎓 Graduation Project**

</div>

---

## 📋 Overview

MedLink API is a **production-ready** medical appointment management system that connects patients with healthcare providers. Developed as a graduation project, it demonstrates enterprise-level architecture and best practices in building secure, scalable healthcare applications.

### 🎯 What It Does

- **Patient Portal**: Patients can register, search for doctors, and book appointments
- **Doctor Management**: Doctors can manage their schedules, view appointments, and update availability
- **Smart Scheduling**: Intelligent appointment slot management with conflict prevention
- **Email Notifications**: Automated confirmations and reminders via SendGrid
- **Secure Authentication**: JWT-based authentication with role-based access control

---

## ✨ Key Features

### 👨‍⚕️ For Healthcare Providers (Doctors)

- **Profile Management**: Complete doctor profiles with specializations and credentials
- **Schedule Management**: Set working hours, breaks, and time-off periods
- **Appointment Overview**: View upcoming, past, and cancelled appointments
- **Patient History**: Access patient information and appointment history
- **Availability Control**: Mark specific time slots as available or unavailable

### 👤 For Patients

- **Doctor Discovery**: Search doctors by specialty, location, or name
- **Appointment Booking**: Book appointments with available time slots
- **Appointment Management**: View, reschedule, or cancel appointments
- **Medical Records**: Maintain personal health information
- **Notifications**: Email confirmations and appointment reminders

### 🔐 Security & Authentication

- **JWT Authentication** with secure token generation
- **Role-Based Authorization** (Patient, Doctor, Admin)
- **Password Hashing** using BCrypt
- **Email Verification** for new accounts
- **Secure Password Reset** flows

### 📧 Communication

- **SendGrid Integration** for reliable email delivery
- **Appointment Confirmations** sent automatically
- **Reminder Emails** before scheduled appointments
- **Cancellation Notifications** to both parties
- **Professional HTML Templates** for all communications

### 🛡️ Reliability & Error Handling

- **Centralized Exception Handling** with proper HTTP status codes
- **Input Validation** with DataAnnotations
- **Transaction Management** for data consistency
- **Graceful Error Recovery** with user-friendly messages

---

## 🏗️ Architecture

### Two-Tier Architecture
```
┌─────────────────────────────────────────────────────────────┐
│                   Presentation Layer (API)                   │
│  ┌──────────────┐  ┌──────────────┐  ┌──────────────┐      │
│  │ Controllers  │  │  Middleware  │  │     DTOs     │      │
│  │  (Routing)   │  │  (Exception) │  │ (Validation) │      │
│  └──────────────┘  └──────────────┘  └──────────────┘      │
│  ┌──────────────┐  ┌──────────────┐  ┌──────────────┐      │
│  │   Services   │  │  AutoMapper  │  │     Auth     │      │
│  │ (Business)   │  │   (Mapping)  │  │    (JWT)     │      │
│  └──────────────┘  └──────────────┘  └──────────────┘      │
└────────────────────────┬────────────────────────────────────┘
                         │
┌────────────────────────▼────────────────────────────────────┐
│                   Data Access Layer (DAL)                    │
│  ┌──────────────┐  ┌──────────────┐  ┌──────────────┐      │
│  │ DbContext    │  │    LINQ      │  │   Entities   │      │
│  │  (EF Core)   │  │  (Queries)   │  │   (Models)   │      │
│  └──────────────┘  └──────────────┘  └──────────────┘      │
│  ┌──────────────┐  ┌──────────────┐  ┌──────────────┐      │
│  │  Migrations  │  │  Seeding     │  │  Relations   │      │
│  └──────────────┘  └──────────────┘  └──────────────┘      │
└─────────────────────────────────────────────────────────────┘
                         │
                         ▼
                  ┌──────────────┐
                  │  SQL Server  │
                  │   Database   │
                  └──────────────┘
```

## 🛠️ Tech Stack

### Core Technologies

| Technology | Purpose | Version |
|------------|---------|---------|
| **ASP.NET Core** | Web API Framework | 8.0 |
| **Entity Framework Core** | ORM & Data Access | 8.0 |
| **SQL Server** | Relational Database | 2022 |
| **LINQ** | Query Language | Built-in |
