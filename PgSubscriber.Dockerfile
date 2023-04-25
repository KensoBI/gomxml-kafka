FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Kenso.Services.Gom.PgSubscriber/Kenso.Services.Gom.PgSubscriber.csproj", "Kenso.Services.Gom.PgSubscriber/"]
COPY ["Kenso.Data.Kafka/Kenso.Data.Kafka.csproj", "Kenso.Data.Kafka/"]
COPY ["Kenso.Loaders.Gom/Kenso.Loaders.Gom.csproj", "Kenso.Loaders.Gom/"]
COPY ["Kenso.Data.Repository/Kenso.Data.Repository.csproj", "Kenso.Data.Repository/"]
COPY ["Kenso.Domain/Kenso.Domain.csproj", "Kenso.Domain/"]
RUN dotnet restore "Kenso.Services.Gom.PgSubscriber/Kenso.Services.Gom.PgSubscriber.csproj"
COPY . .
WORKDIR "/src/Kenso.Services.Gom.PgSubscriber"
RUN dotnet build "Kenso.Services.Gom.PgSubscriber.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Kenso.Services.Gom.PgSubscriber.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Kenso.Services.Gom.PgSubscriber.dll"]