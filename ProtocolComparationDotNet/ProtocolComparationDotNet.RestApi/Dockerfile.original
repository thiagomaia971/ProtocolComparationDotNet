FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["ProtocolComparationDotNet.RestApi/ProtocolComparationDotNet.RestApi.csproj", "ProtocolComparationDotNet.RestApi/"]
RUN dotnet restore "ProtocolComparationDotNet.RestApi/ProtocolComparationDotNet.RestApi.csproj"
COPY . .
WORKDIR "/src/ProtocolComparationDotNet.RestApi"
RUN dotnet build "ProtocolComparationDotNet.RestApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProtocolComparationDotNet.RestApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProtocolComparationDotNet.RestApi.dll"]