FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-nanoserver-1809
COPY bin/Debug/netcoreapp3.1/ App/
WORKDIR /App
ENTRYPOINT ["dotnet", "WindowsSender.dll"]