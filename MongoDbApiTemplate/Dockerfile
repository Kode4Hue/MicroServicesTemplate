#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MongoDbApiTemplate/MongoDbApiTemplate.csproj", "MongoDbApiTemplate/"]
RUN dotnet restore "MongoDbApiTemplate/MongoDbApiTemplate.csproj"
COPY . .
WORKDIR "/src/MongoDbApiTemplate"
RUN dotnet build "MongoDbApiTemplate.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MongoDbApiTemplate.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MongoDbApiTemplate.dll"]