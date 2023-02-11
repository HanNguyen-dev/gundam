# About
This .NET WebApi project is build with .NET 7

# Run this code locally
1. `dotnet restore`
2. `dotnet run --project Gundam.Api`
3. The endpoint is `http://localhost:5200/gundam`

# Connect to MySQL or MariaDB

1. Install and setup your database

2. Run the sql script to create database and table [database.sql](./database.sql)

3. Install Entity Framework command line tool globally
    1.  `dotnet tool install --global dotnet-ef`
4. Data first approach
    1.  Inside Gundam.DataAccess directory, run the following command
    2. `dotnet ef dbcontext scaffold -s ../Gundam.Api/Gundam.Api.csproj --context GundamContext -o Entities "server=localhost;userid=user;pwd=password;port=3306;database=gundam;sslmode=none;" Pomelo.EntityFrameworkCore.MySql`
        1. Note: Pass in the connection string with the appropriate properties and credentials such as user id, password, etc.

More info:

https://learn.microsoft.com/en-us/ef/core/managing-schemas/scaffolding/?tabs=dotnet-core-cli
