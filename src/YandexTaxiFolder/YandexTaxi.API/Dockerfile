#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/YandexTaxiFolder/YandexTaxi.API/YandexTaxi.API.csproj", "src/YandexTaxiFolder/YandexTaxi.API/"]
COPY ["src/YandexTaxiFolder/YandexTaxi.Application/YandexTaxi.Application.csproj", "src/YandexTaxiFolder/YandexTaxi.Application/"]
COPY ["src/YandexTaxiFolder/YandexTaxi.Domain/YandexTaxi.Domain.csproj", "src/YandexTaxiFolder/YandexTaxi.Domain/"]
COPY ["src/YandexTaxiFolder/YandexTaxi.Infrastructure/YandexTaxi.Infrastructure.csproj", "src/YandexTaxiFolder/YandexTaxi.Infrastructure/"]
RUN dotnet restore "./src/YandexTaxiFolder/YandexTaxi.API/./YandexTaxi.API.csproj"
COPY . .
WORKDIR "/src/src/YandexTaxiFolder/YandexTaxi.API"
RUN dotnet build "./YandexTaxi.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./YandexTaxi.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "YandexTaxi.API.dll"]