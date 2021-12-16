FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["NumberRandomizer/NumberRandomizer.csproj", "NumberRandomizer/"]
RUN dotnet restore "NumberRandomizer/NumberRandomizer.csproj"
COPY . .
WORKDIR "/src/NumberRandomizer"
RUN dotnet build "NumberRandomizer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NumberRandomizer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NumberRandomizer.dll"]
