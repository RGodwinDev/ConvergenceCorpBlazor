Convergence Corp!
This is the website for Convergence Corp.
See https://convergencecorp.net
Written using C# Blazor and ASP.NET.
Created by Ryan Godwin.

Uses dotnet 10.0

Runs on linux using a systemd service in /etc/systemd/system called ccblazor.service

[Unit]
Description=Runs the Blazor version of Convergence Corp.net

[Service]
Type=simple
User=root
WorkingDirectory=/var/www/ccblazor/ConvergenceCorpBlazor/ConvergenceCorpBlazor/bin/Release/net10.0/publish
ExecStart=/snap/dotnet-sdk-100/current/usr/bin/dotnet /var/www/ccblazor/ConvergenceCorpBlazor/ConvergenceCorpBlazor/bin/Release/net10.0/publish/ConvergenceCorpBlazor.dll
Restart=always
RestartSec=10
Environment=ASPNETCORE_ENVIRONMENT=Production
Environment=DOTNET_PRINT_TELEMETRY_MESSAGE=false

[Install]
WantedBy=multi-user.target




installing:
make directory /var/www/ccblazor
cd into ccblazor
sudo git clone https://github.com/RGodwinDev/ConvergenceCorpBlazor.git
sudo snap install dotnet-sdk-100
sudo snap install dotnet-runtime-100
sudo ln -s /snap/dotnet-sdk-100/current/usr/bin/dotnet /usr/local/bin/dotnet
then create the above ccblazor.service

when updating:
from the /var/www/ccblazor/ConvergenceCorpBlazor folder
sudo git pull (input username/personalaccesstoken)
sudo dotnet publish
sudo systemctl restart ccblazor