#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MicroServicesTemplate.CoreAPI.Presn/MicroServicesTemplate.CoreAPI.Presn.csproj", "MicroServicesTemplate.CoreAPI.Presn/"]
RUN dotnet restore "MicroServicesTemplate.CoreAPI.Presn/MicroServicesTemplate.CoreAPI.Presn.csproj"
COPY . .
WORKDIR "/src/MicroServicesTemplate.CoreAPI.Presn"
RUN dotnet build "MicroServicesTemplate.CoreAPI.Presn.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroServicesTemplate.CoreAPI.Presn.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroServicesTemplate.CoreAPI.Presn.dll"]