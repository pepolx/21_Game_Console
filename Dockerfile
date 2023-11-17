FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["21_Game_Console/21_Game_Console.csproj", "21_Game_Console/"]
RUN dotnet restore "21_Game_Console/21_Game_Console.csproj"
COPY . .
WORKDIR "/src/21_Game_Console"
RUN dotnet build "21_Game_Console.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "21_Game_Console.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "21_Game_Console.dll"]
