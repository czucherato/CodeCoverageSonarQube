# Code Coverage SonarQube Sample

## Steps

Use the command line to generate the report tests

1 - Run SonarQube in Docker
```bash
docker run -d — name sonarqube -p 9000:9000 -p 9092:9092 sonarqube
```
2 - Run test
```bash
dotnet test tests/Math.Test/Math.Test.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
```
3 - Stop dotnet build-server
```bash
dotnet build-server shutdown
```
4 - Start sonar scanner
```bash
dotnet sonarscanner begin /k:Math /d:sonar.host.url=http://localhost:9000 /d:sonar.cs.opencover.reportsPaths="tests/Math.Test/coverage.opencover.xml" /d:sonar.coverage.exclusions="**Test*.cs"
```
5 - Project compilation
```bash
dotnet build
```
6 - Stop sonar scaner
```bash
dotnet sonarscanner end
```

## Reference
[net-core-code-quality-with-coverlet-and-sonarqube](https://medium.com/tribalscale/net-core-code-quality-with-coverlet-and-sonarqube-part-2-141617f83d6f)