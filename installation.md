# Installation


## Fresh Install
Installing on a fresh Azure VM:  
```
cd /var/www  
mkdir ccblazor  
cd ccblazor  
sudo git clone https://github.com/RGodwinDev/ConvergenceCorpBlazor.git  
sudo snap install dotnet-sdk-100  
sudo snap install dotnet-runtime-100  
sudo ln -s /snap/dotnet-sdk-100/current/usr/bin/dotnet /usr/local/bin/dotnet  
```

## Updating
```
cd /var/www/ccblazor/ConvergenceCorpBlazor  
sudo git pull  
(enter github user/personalaccesstoken)  
sudo dotnet publish  
sudo systemctl restart ccblazor  
```

## Creating the systemd service
Creating the systemd service:  
```
cd /etc/systemd/system  
sudo touch ccblazor.service  
sudo nano ccblazor.service  
```

### systemd contents
copy everything below:
```
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
```  
ctrl+O (saves)  
enter  
ctrl+X (exit nano)  
sudo systemctl daemon-reload  
sudo systemctl start ccblazor.service  
