FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/shared/Magellan.Identity.Web/Magellan.Identity.Web.csproj", "src/shared/Magellan.Identity.Web/"]
RUN dotnet restore "src/shared/Magellan.Identity.Web/Magellan.Identity.Web.csproj"
COPY . .
WORKDIR "/src/src/shared/Magellan.Identity.Web"
RUN dotnet build "Magellan.Identity.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Magellan.Identity.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Magellan.Identity.Web.dll"]
