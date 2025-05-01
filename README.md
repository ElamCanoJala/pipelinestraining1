# pipelinestraining1

# -------------------------------------------------------------------

# App Solution File structure

# -------------------------------------------------------------------

<!--

root
  myApp
  myApp.Tests
  TrainProject.sln

-->

# -------------------------------------------------------------------

# Commands to create the app "myApp" inside "TrainProject" Solution:

# -------------------------------------------------------------------

<!--

# Create a new folder and navigate into it
mkdir myApp
cd myApp

# Create a solution
dotnet new sln -n TrainProject

# Create a console app
dotnet new console -n myApp

# Add the console app to the solution
dotnet sln add myApp/myApp.csproj

# Add Figgle package to the "myApp" app
dotnet add myApp package Figgle

 -->

# -------------------------------------------------------------------

# Commands to add unit tests for "myApp" app inside "TrainProject" Solution:

# -------------------------------------------------------------------

<!--

# From the root of your solution, create "myApp" test project
dotnet new mstest -n myApp.Tests

# Add the "myApp" project reference to "myApp.Test" project
dotnet add myApp.Tests/myApp.Tests.csproj reference myApp/myApp.csproj

 -->

# -------------------------------------------------------------------

# Commands to Install and Use Required tools and packages:

# -------------------------------------------------------------------

<!--

# Code inspection
- cd myApp
- mkdir reports
- dotnet tool install JetBrains.ReSharper.GlobalTools --tool-path $DOTNET_TOOLS_PATH
- ."$DOTNET_TOOLS_PATH\jb.exe" inspectcode ../TrainProject.sln -o=reports/report

# Code inspection validation
- cd "../scripts"
- ./validate_report.ps1

# Unit tests and code coverage
- cd ../myApp.Tests
- mkdir reports
- dotnet add package coverlet.msbuild --package-directory $NUGET_PATH
- dotnet test -p:CollectCoverage=true -p:CoverletOutputFormat=cobertura -p:CoverletOutput=reports/coverage

# Code Coverage validation
- cd "../scripts"
- ./validate_coverage.ps1

# Unit tests report generation
- cd ../myApp.Tests
- dotnet tool install dotnet-reportgenerator-globaltool --tool-path $DOTNET_TOOLS_PATH
- ."$DOTNET_TOOLS_PATH\reportgenerator.exe" -reports:reports\coverage.cobertura.xml -targetdir:reports\coveragereport -reporttypes:Html

 -->
<!-- name: CI

on:
  push:
    branches: ["elamCano_p1_dev"]
  pull_request:
    branches: ["elamCano_p1_dev"]
  workflow_dispatch:

jobs:
  build-test-publish:
    runs-on: windows-latest

    steps:
      - name: Checkout code
        uses: actions/checkout@v4

      - name: Setup .NET
        uses: actions/setup-dotnet@v4
        with:
          dotnet-version: "8.0.x"

      - name: Restore dependencies
        run: dotnet restore

        # Build
      - name: Build the app
        run: dotnet build --no-restore --configuration Release

        # Test
      - name: Run tests with coverage
        run: dotnet test ./myApp.Tests/myApp.Tests.csproj --collect:"XPlat Code Coverage" --no-build --configuration Release -p:CollectCoverage=true -p:CoverletOutput=TestResults/coverage -p:CoverletOutputFormat=cobertura

      - name: Find coverage report path
        id: find_coverage
        run: |
          $path = Get-ChildItem -Path ./myApp.Tests/TestResults -Recurse -Filter "coverage.cobertura.xml" | Select-Object -First 1
           echo "##[set-output name=coverage_path]$($path.FullName)"
        shell: pwsh

      - name: Install ReportGenerator
        run: dotnet tool install dotnet-reportgenerator-globaltool --tool-path tools

      - name: Generate coverage report
        run: ./tools/reportgenerator.exe -reports:./myApp.Tests/reports/coverage.cobertura.xml -targetdir:./myApp.Tests/reports/coveragereport -reporttypes:Html

        # Publish
      - name: Publish app
        run: dotnet publish ./myApp/myApp.csproj --configuration Release --output ./publish
 -->
