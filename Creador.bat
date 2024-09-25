dotnet new sln
mkdir src
mkdir docs
mkdir test
cd src
dotnet new console -n Program --use-program-main
dotnet new classlib -n Library
cd Program
dotnet add Program.csproj reference ../Library/Library.csproj
cd ..
cd ..
cd test
dotnet new nunit -n Library.Tests
cd Library.Tests
dotnet add Library.Tests.csproj reference ../../src/Library/Library.csproj
cd ..
cd ..
dotnet sln add src/Library/Library.csproj
dotnet sln add src/Program/Program.csproj
dotnet sln add test/Library.Tests/Library.Tests.csproj
dotnet new gitignore
code .