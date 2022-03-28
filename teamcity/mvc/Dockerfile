# build environment
FROM microsoft/aspnetcore-build:2 AS build-env
WORKDIR /mvc

# restore packages first to speed up builds that only change code
COPY mvc.csproj .
RUN dotnet restore 

# publish app to folder /publish
COPY . .
RUN dotnet publish -o /publish

# lean, production environment
FROM microsoft/aspnetcore:2
COPY --from=build-env /publish /publish
WORKDIR /publish
ENTRYPOINT ["dotnet", "mvc.dll"]

