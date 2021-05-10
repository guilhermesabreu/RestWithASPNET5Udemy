FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["RestWithASPNETUdemy/RestWithASPNETUdemy.csproj", "RestWithASPNETUdemy/"]
RUN dotnet restore "RestWithASPNETUdemy/RestWithASPNETUdemy.csproj"
COPY ./RestWithASPNETUdemy ./RestWithASPNETUdemy
WORKDIR "/src/RestWithASPNETUdemy"
RUN dotnet build "RestWithASPNETUdemy.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RestWithASPNETUdemy.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RestWithASPNETUdemy.dll"]