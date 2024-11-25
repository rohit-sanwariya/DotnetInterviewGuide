FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["DotnetInterviewGuide/DotnetInterviewGuide.csproj", "DotnetInterviewGuide/"]
RUN dotnet restore "DotnetInterviewGuide/DotnetInterviewGuide.csproj"
COPY . .
WORKDIR "/src/DotnetInterviewGuide"
RUN dotnet build "DotnetInterviewGuide.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "DotnetInterviewGuide.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DotnetInterviewGuide.dll"]
