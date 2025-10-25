FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Копируем csproj сохраняя структуру каталогов
COPY ["AuthService/AuthService.Api/AuthService.Api.csproj", "AuthService/AuthService.Api/"]
COPY ["AuthService/AuthService.Application/AuthService.Application.csproj", "AuthService/AuthService.Application/"]
COPY ["AuthService/AuthService.Domain/AuthService.Domain.csproj", "AuthService/AuthService.Domain/"]
COPY ["AuthService/AuthService.Infrastructure/AuthService.Infrastructure.csproj", "AuthService/AuthService.Infrastructure/"]
COPY ["AuthService/AuthService.Persistence/AuthService.Persistence.csproj", "AuthService/AuthService.Persistence/"]
COPY ["Shared/Shared.csproj", "Shared/"]

# Восстановление с учётом сохранённой структуры
RUN dotnet restore "AuthService/AuthService.Api/AuthService.Api.csproj"

# Копируем всё и собираем/публикуем
COPY . .
WORKDIR "/src/AuthService/AuthService.Api"
RUN dotnet build "./AuthService.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./AuthService.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AuthService.Api.dll"]