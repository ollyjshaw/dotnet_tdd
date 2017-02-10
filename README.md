This is a simple project to use as a starting point for TTD in dotnet core.

This project shows that the tools are all there and open.

I use a command similar to this to run it via docker

`docker run -v /path/to/your/files:/root/dotnet -it microsoft/dotnet:latest`

Then

`dotnet restore`

`dotnet test`

or

`dotnet watch test`
