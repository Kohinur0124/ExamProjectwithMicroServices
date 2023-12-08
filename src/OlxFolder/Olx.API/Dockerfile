#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80


FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/OlxFolder/Olx.API/Olx.API.csproj", "src/OlxFolder/Olx.API/"]
COPY ["src/OlxFolder/Olx.Application/Olx.Application.csproj", "src/OlxFolder/Olx.Application/"]
COPY ["src/YandexEatsFolder/YandexEats.Domain/YandexEats.Domain.csproj", "src/YandexEatsFolder/YandexEats.Domain/"]
COPY ["src/OlxFolder/Olx.Domain/Olx.Domain.csproj", "src/OlxFolder/Olx.Domain/"]
COPY ["src/OlxFolder/Olx.Infrastructure/Olx.Infrastructure.csproj", "src/OlxFolder/Olx.Infrastructure/"]
RUN dotnet restore "./src/OlxFolder/Olx.API/./Olx.API.csproj"
COPY . .
WORKDIR "/src/src/OlxFolder/Olx.API"
RUN dotnet build "./Olx.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Olx.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Olx.API.dll"]