# FIT-RS2

Practical task - .NET Core Web Api, Flutter and Windows Form

## Docker SQL Installation

docker pull mcr.microsoft.com/mssql/server:2017-latest
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=QWErty123!" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2017-latest

## Entity Framework Scaffolding

Scaffold-DbContext 'Data Source=localhost, 1433; Initial Catalog=160020; User=sa; Password=QWErty123!' Microsoft.EntityFrameworkCore.SqlServer -OutputDir Database


## Docker build

docker build -t projectwe-api .

## Docker run

docker run -p 5192:5192 --name projectwe-api-container projectwe-api

http://localhost:5192/api/

## Docker compose

docker compose up --build