#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MicroServicesTemplate.WebUI/Server/MicroServicesTemplate.WebUI.Server.csproj", "MicroServicesTemplate.WebUI/Server/"]
COPY ["MicroServicesTemplate.WebUI/Client/MicroServicesTemplate.WebUI.Client.csproj", "MicroServicesTemplate.WebUI/Client/"]
COPY ["MicroServicesTemplate.WebUI/Shared/MicroServicesTemplate.WebUI.Shared.csproj", "MicroServicesTemplate.WebUI/Shared/"]
RUN dotnet restore "MicroServicesTemplate.WebUI/Server/MicroServicesTemplate.WebUI.Server.csproj"
COPY . .
WORKDIR "/src/MicroServicesTemplate.WebUI/Server"
RUN dotnet build "MicroServicesTemplate.WebUI.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroServicesTemplate.WebUI.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroServicesTemplate.WebUI.Server.dll"]