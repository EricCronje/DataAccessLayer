Dotnet new sln
md DataAccessLayer
cd DataAccessLayer
Dotnet new classLib
cd..
Dotnet sln add "./DataAccessLayer"

Dotnet build

Echo Done!
