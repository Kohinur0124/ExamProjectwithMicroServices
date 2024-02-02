#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["test/TestProject1/TestProject1.csproj", "test/TestProject1/"]
COPY ["src/Auth/AuthApiExam/AuthApiExam.csproj", "src/Auth/AuthApiExam/"]
RUN dotnet restore "./test/TestProject1/./TestProject1.csproj"
COPY . .
WORKDIR "/src/test/TestProject1"
RUN dotnet build "./TestProject1.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./TestProject1.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestProject1.dll"]