FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["ProtocolComparationDotNet.GraphQL/ProtocolComparationDotNet.GraphQL.csproj", "ProtocolComparationDotNet.GraphQL/"]
RUN dotnet restore "ProtocolComparationDotNet.GraphQL/ProtocolComparationDotNet.GraphQL.csproj"
COPY . .
WORKDIR "/src/ProtocolComparationDotNet.GraphQL"
RUN dotnet build "ProtocolComparationDotNet.GraphQL.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProtocolComparationDotNet.GraphQL.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProtocolComparationDotNet.GraphQL.dll"]