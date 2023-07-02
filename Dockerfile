FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /dotnet-api-template
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["dotnet-api-template.csproj", "."]
RUN dotnet restore "./dotnet-api-template.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "dotnet-api-template.csproj" -c Release -o /dotnet-api-template/build

FROM build AS publish
RUN dotnet publish "dotnet-api-template.csproj" -c Release -o /dotnet-api-template/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /dotnet-api-template
COPY --from=publish /dotnet-api-template/publish .
ENTRYPOINT ["dotnet", "dotnet-api-template.dll"]