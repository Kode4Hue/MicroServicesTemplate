#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["nuget.config", "."]
COPY ["MicroServicesTemplate.Web/Server/MicroServicesTemplate.Web.Server.csproj", "MicroServicesTemplate.Web/Server/"]
COPY ["MicroServicesTemplate.Web/Client/MicroServicesTemplate.Web.Client.csproj", "MicroServicesTemplate.Web/Client/"]
COPY ["MicroServicesTemplate.Web/Shared/MicroServicesTemplate.Web.Shared.csproj", "MicroServicesTemplate.Web/Shared/"]
RUN dotnet restore "MicroServicesTemplate.Web/Server/MicroServicesTemplate.Web.Server.csproj"
COPY . .
WORKDIR "/src/MicroServicesTemplate.Web/Server"
RUN dotnet build "MicroServicesTemplate.Web.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroServicesTemplate.Web.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroServicesTemplate.Web.Server.dll"]