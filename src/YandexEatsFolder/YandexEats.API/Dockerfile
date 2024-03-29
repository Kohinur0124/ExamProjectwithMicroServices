#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80


FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/YandexEatsFolder/YandexEats.API/YandexEats.API.csproj", "src/YandexEatsFolder/YandexEats.API/"]
COPY ["src/YandexEatsFolder/YandexEats.Application/YandexEats.Application.csproj", "src/YandexEatsFolder/YandexEats.Application/"]
COPY ["src/YandexEatsFolder/YandexEats.Domain/YandexEats.Domain.csproj", "src/YandexEatsFolder/YandexEats.Domain/"]
COPY ["src/YandexEatsFolder/YandexEats.Infrastructure/YandexEats.Infrastructure.csproj", "src/YandexEatsFolder/YandexEats.Infrastructure/"]
RUN dotnet restore "./src/YandexEatsFolder/YandexEats.API/./YandexEats.API.csproj"
COPY . .
WORKDIR "/src/src/YandexEatsFolder/YandexEats.API"
RUN dotnet build "./YandexEats.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./YandexEats.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "YandexEats.API.dll"]