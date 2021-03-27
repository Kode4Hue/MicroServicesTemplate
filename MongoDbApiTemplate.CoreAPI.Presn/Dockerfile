#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MongoDbApiTemplate.CoreAPI.Presn/MongoDbApiTemplate.CoreAPI.Presn.csproj", "MongoDbApiTemplate.CoreAPI.Presn/"]
RUN dotnet restore "MongoDbApiTemplate.CoreAPI.Presn/MongoDbApiTemplate.CoreAPI.Presn.csproj"
COPY . .
WORKDIR "/src/MongoDbApiTemplate.CoreAPI.Presn"
RUN dotnet build "MongoDbApiTemplate.CoreAPI.Presn.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MongoDbApiTemplate.CoreAPI.Presn.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MongoDbApiTemplate.CoreAPI.Presn.dll"]