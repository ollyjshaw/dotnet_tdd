This is a simple project to use as a starting point for TDD in dotnet core.

This project shows that the tools are all there and open.

I use a command similar to this to run it via docker

`docker pull microsoft/dotnet:latest; docker run -v `pwd`:/root/dotnet -it microsoft/dotnet:latest`

Then

`dotnet restore`

`dotnet test`

or

`dotnet watch test`
