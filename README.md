# RecordShop-Backend

ASP.NET Core backend for the RecordShop application using the MVC pattern.

RecordShop is an online shop for music of any genre. Able to connect to any record database which fits the Album model

## Project Goals

RecordShop should be an easy to use online store where users can browse songs and albums by their artists. Admins should be able to add, remove and modify albums.

## Tech Stack

- C#/.NET 8
- ASP.NET Core
- EF Core

## Prerequisites
- Visual Studio 2022
- .NET 8 SDK

## Getting started

Clone this repository. Open nc-recordshop-backend.slnx from the project root using Visual Studio 2022 or run the application with:
```
dotnet run
```

Add development database information in appsettings.Development.json

```
"ConnectionStrings": {
  "DefaultConnection": "TestingDb"
}
```

Add your own production database information in appsettings.Production.json

```
"ConnectionStrings": {
  "DefaultConnection": "your-connection-string"
}
```

In Package Manager Console, add database migration and update database:
```
Add-Migration InitialCreate
Update-Database
```

To run tests, Open nc-recordshop-backend in it's root directory and do 'Run All Tests'
