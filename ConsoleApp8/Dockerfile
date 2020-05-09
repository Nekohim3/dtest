FROM mcr.microsoft.com/dotnet/core/runtime:3.1
COPY bin/Release/netcoreapp3.1/publish-win641/ ConsoleApp8/
WORKDIR /ConsoleApp8
ENTRYPOINT ["dotnet", "ConsoleApp8.dll"]