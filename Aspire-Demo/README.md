# Aspire Demo

1. ApiService: ASP.NET Core Minimal API project
2. AppHost: Orchestrator project 
3. ServiceDefaults:  Aspire shared project
4. Web: front-end UI

![alt text](./Doc/aspire-demo.png)

![alt text](./Doc/aspire-demo2.png)

## Tech Stack
 - [x] Aspire 
 - [x] Redis
 - [x] Health
 - [x] OpenTelemetry
 - [x] Blazor

```dotnetcli
$ dotnet workload install aspire

$ dotnet new aspire-starter --use-redis-cache --output Aspire-Demo 

# cd Aspire-Demo
$ dotnet run --project Aspire-Demo.AppHost

# dashboard
http://localhost:15028/

# webfrontend
http://localhost:5050/

# apiservice
http://localhost:5443/weatherforecast

# health
http://localhost:5050/health

```