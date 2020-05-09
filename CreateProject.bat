Dotnet new sln
md DataAccessLayer
cd DataAccessLayer
Dotnet new classLib
cd..

md UnitTest
cd UnitTest
Dotnet new mstest
cd..

Dotnet sln add "./DataAccessLayer"
Dotnet sln add "./UnitTest"

Dotnet build

Echo Done!
