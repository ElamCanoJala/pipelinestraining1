# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS runtime
WORKDIR /app

#Copy publish from build context
COPY publish/ .

ENTRYPOINT ["dotnet", "myApp.dll"]