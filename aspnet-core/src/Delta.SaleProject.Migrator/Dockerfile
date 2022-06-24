#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Delta.SaleProject.Migrator/Delta.SaleProject.Migrator.csproj", "src/Delta.SaleProject.Migrator/"]
COPY ["src/Delta.SaleProject.EntityFrameworkCore/Delta.SaleProject.EntityFrameworkCore.csproj", "src/Delta.SaleProject.EntityFrameworkCore/"]
COPY ["src/Delta.SaleProject.Core/Delta.SaleProject.Core.csproj", "src/Delta.SaleProject.Core/"]
COPY ["src/Delta.SaleProject.Core.Shared/Delta.SaleProject.Core.Shared.csproj", "src/Delta.SaleProject.Core.Shared/"]
RUN dotnet restore "src/Delta.SaleProject.Migrator/Delta.SaleProject.Migrator.csproj"
COPY . .
WORKDIR "/src/src/Delta.SaleProject.Migrator"
RUN dotnet build "Delta.SaleProject.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Delta.SaleProject.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Delta.SaleProject.Migrator.dll"]
