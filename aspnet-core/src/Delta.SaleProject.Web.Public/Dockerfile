#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Delta.SaleProject.Web.Public/Delta.SaleProject.Web.Public.csproj", "src/Delta.SaleProject.Web.Public/"]
COPY ["src/Delta.SaleProject.Web.Core/Delta.SaleProject.Web.Core.csproj", "src/Delta.SaleProject.Web.Core/"]
COPY ["src/Delta.SaleProject.Application/Delta.SaleProject.Application.csproj", "src/Delta.SaleProject.Application/"]
COPY ["src/Delta.SaleProject.Application.Shared/Delta.SaleProject.Application.Shared.csproj", "src/Delta.SaleProject.Application.Shared/"]
COPY ["src/Delta.SaleProject.Core.Shared/Delta.SaleProject.Core.Shared.csproj", "src/Delta.SaleProject.Core.Shared/"]
COPY ["src/Delta.SaleProject.Core/Delta.SaleProject.Core.csproj", "src/Delta.SaleProject.Core/"]
COPY ["src/Delta.SaleProject.EntityFrameworkCore/Delta.SaleProject.EntityFrameworkCore.csproj", "src/Delta.SaleProject.EntityFrameworkCore/"]
COPY ["src/Delta.SaleProject.GraphQL/Delta.SaleProject.GraphQL.csproj", "src/Delta.SaleProject.GraphQL/"]
RUN dotnet restore "src/Delta.SaleProject.Web.Public/Delta.SaleProject.Web.Public.csproj"
COPY . .
WORKDIR "/src/src/Delta.SaleProject.Web.Public"
RUN dotnet build "Delta.SaleProject.Web.Public.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Delta.SaleProject.Web.Public.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Delta.SaleProject.Web.Public.dll"]
