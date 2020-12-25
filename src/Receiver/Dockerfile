FROM mcr.microsoft.com/dotnet/aspnet:3.1
COPY bin/Debug/netcoreapp3.1/ App/
WORKDIR /App
ENTRYPOINT ["dotnet", "Receiver.dll"]