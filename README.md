# HangfireDemo

A simple ASP.NET Core Web API project developed to learn and demonstrate background job processing using **Hangfire** and **SQL Server**.

## Technologies Used

- C#
- ASP.NET Core Web API
- .NET 10
- Hangfire
- SQL Server
- Microsoft.Data.SqlClient

## Project Overview

This project demonstrates how to execute background tasks without blocking the main application flow. Hangfire is integrated with SQL Server to manage and store background jobs.

The project includes three different types of background jobs:

### 1. Fire-and-Forget Job

Executes a background task immediately after it is triggered by an API request.

- Prints `Merhaba Hangfire!` to the Console.

### 2. Delayed Job

Schedules a background task to execute after a specified delay.

- Executes 5 seconds after being triggered.
- Prints `5 saniye sonra çalışan görev.` to the Console.

### 3. Recurring Job

Executes a background task repeatedly according to a defined schedule.

- Runs every minute.
- Prints `Recurring Job çalıştı.` to the Console.

## Hangfire Dashboard

Hangfire Dashboard provides a visual interface for monitoring background jobs.

It allows users to monitor job statuses, view job history, and track recurring tasks.

Dashboard URL:

```text
https://localhost:7203/hangfire/
```

## Database Configuration

The project uses SQL Server to store Hangfire job information.

Update the connection string in `appsettings.json` according to your SQL Server instance:

```json
"ConnectionStrings": {
  "HangfireConnection": "Server=localhost\\SQLEXPRESS02;Database=HangfireDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

## Getting Started

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Configure the SQL Server connection string.
4. Restore the required NuGet packages.
5. Run the ASP.NET Core Web API project.
6. Access the Hangfire Dashboard through `/hangfire/`.
7. Trigger the API endpoints to execute background jobs.

## Learning Outcomes

Through this project, I practiced:

- Understanding the Background Job concept.
- Integrating Hangfire into an ASP.NET Core Web API.
- Configuring Hangfire with SQL Server.
- Implementing Fire-and-Forget, Delayed, and Recurring Jobs.
- Monitoring background tasks using Hangfire Dashboard.
