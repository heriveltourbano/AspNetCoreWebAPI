# FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# copy csproj and restore as distinct layers
# COPY *.sln .
# COPY aspnetapp/*.csproj ./aspnetapp/
COPY *.csproj ./
RUN dotnet restore

# copy everything else and build app
# COPY aspnetapp/. ./aspnetapp/
COPY . ./
# WORKDIR /app/aspnetapp
RUN dotnet publish -c Release -o out

# FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS runtime
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 
WORKDIR /app
# COPY --from=build /app/aspnetapp/out ./
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "SmartSchool.WebAPI.dll"]