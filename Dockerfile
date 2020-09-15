FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src

COPY ["AutoSkola.WebAPI/AutoSkola.WebAPI.csproj", "AutoSkola.WebAPI/"]
COPY ["AutoSkola.Model/AutoSkola.Model.csproj", "AutoSkola.Model/"]

RUN dotnet restore "AutoSkola.WebAPI/AutoSkola.WebAPI.csproj"
COPY . .

WORKDIR "/src/AutoSkola.WebAPI"
RUN dotnet build "AutoSkola.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AutoSkola.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AutoSkola.WebAPI.dll"]