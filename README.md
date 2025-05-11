Convergence Corp!
This is the website for Convergence Corp.
See https://convergencecorp.net!
Written using C# Blazor and ASP.NET.
Created by Ryan Godwin.

Uses dotnet 8.0
dotnet 9.0 isnt useable on linux yet.

Runs on linux using a systemd service in /etc/systemd/system called ccblazor.service

[Unit]
Description=Runs the Blazor version of Convergence Corp.net

[Service]
Type=simple
User=root
WorkingDirectory=/var/www/ccblazor/ConvergenceCorpBlazor/bin/Release/net8.0/publish
ExecStart=/snap/bin/dotnet /var/www/ccblazor/ConvergenceCorpBlazor/bin/Release/net8.0/publish/ConvergenceCorpBlazor.dll
Restart=always
RestartSec=10
Environment=ASPNETCORE_ENVIRONMENT=Production
Environment=DOTNET_PRINT_TELEMETRY_MESSAGE=false

[Install]
WantedBy=multi-user.target

when updating:
from the /var/www/ccblazor/ConvergenceCorpBlazor folder
sudo git pull (input username/personalaccesstoken)
sudo dotnet publish
sudo systemctl restart ccblazor