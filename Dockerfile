# syntax=docker/dockerfile:1

FROM mcr.microsoft.com/dotnet/sdk:7.0 as build-env
WORKDIR /src
COPY src/*.csproj .
RUN dotnet restore
COPY src .
RUN dotnet publish -c Release -o /publish

# �kinci a�ama: Uygulamay� �al��t�r
FROM mcr.microsoft.com/dotnet/aspnet:7.0 as runtime-env
WORKDIR /app
COPY --from=build-env /publish .
EXPOSE 80
ENTRYPOINT ["dotnet", "myWebApp.dll"]
