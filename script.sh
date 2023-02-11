#!/bin/sh

# create .NET solution and projects
dotnet new sln --name GundamDotNet
dotnet new webapi --name Gundam.Api
dotnet new classlib --name Gundam.Core
dotnet new classlib --name Gundam.DataAccess
dotnet new xunit --name Gundam.Test

# add references/dependencies
dotnet add Gundam.Api/Gundam.Api.csproj reference Gundam.Core/Gundam.Core.csproj
dotnet add Gundam.DataAccess/Gundam.DataAccess.csproj reference Gundam.Core/Gundam.Core.csproj
dotnet add Gundam.Api/Gundam.Api.csproj reference Gundam.DataAccess/Gundam.DataAccess.csproj

# add packages/dependencies for DataAccess
dotnet add Gundam.Api/Gundam.Api.csproj package Microsoft.EntityFrameworkCore.Design

dotnet add Gundam.DataAccess/Gundam.DataAccess.csproj package Microsoft.EntityFrameworkCore
dotnet add Gundam.DataAccess/Gundam.DataAccess.csproj package Microsoft.EntityFrameworkCore.Design
dotnet add Gundam.DataAccess/Gundam.DataAccess.csproj package Microsoft.EntityFrameworkCore.Tools
dotnet add Gundam.DataAccess/Gundam.DataAccess.csproj package Microsoft.EntityFrameworkCore.Tools.DotNet
dotnet add Gundam.DataAccess/Gundam.DataAccess.csproj package Pomelo.EntityFrameworkCore.MySql
dotnet add Gundam.DataAccess/Gundam.DataAccess.csproj package Pomelo.EntityFrameworkCore.MySql.Design


# add packages/dependencies for Test
dotnet add Gundam.Test/Gundam.Test.csproj package coverlet
dotnet add Gundam.Test/Gundam.Test.csproj package coverlet.msbuild
dotnet add Gundam.Test/Gundam.Test.csproj package moq

# update solution
dotnet sln add **/*.csproj

# to run project from the root directory
# dotnet restore
# dotnet run --project Gundam.Api

