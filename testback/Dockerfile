#FROM mcr.microsoft.com/dotnet/aspnet:3.1
#COPY bin/Release/netcoreapp3.1/publish/ App/
#RUN sed -i 's/TLSv1.2/TLSv1.0/g' /etc/ssl/openssl.cnf
#WORKDIR /App
#ENTRYPOINT ["dotnet", "testback.dll"]


FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["testback/testback.csproj", "testback/"]
RUN dotnet restore "testback/testback.csproj"
COPY . .
WORKDIR "/src/testback"
RUN dotnet build "testback.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "testback.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "testback.dll"]