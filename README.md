# MyTripWeb

## Development Environment  Setup Instructions:

### Docker deploy DataBase
#### SQL server:
```
docker pull mcr.microsoft.com/mssql/server
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=PaSSword12!" -p 1433:1433 -d mcr.microsoft.com/mssql/server
```

#### MySQL:
```
docker pull mysql:lastest
docker run -itd --name mysql-test -p 3306:3306 -e MYSQL_ROOT_PASSWORD=123456 mysql
```

#### Other commands:
```
docker images
docker ps
```

### Migration Database
#### Window cmd:
```
dotnet ef migrations add MySQLinit
dotnet ef database update
```

#### Package Manager Console:
```
add-migration initialMigration
update-database
```

### Notes and Solves
#### port 3306 conflict
```
netstat -aon|findstr "3306" # look up pid
taskkill /f -pid [pid_num]
```

#### windown use dotnet cli
```
dotnet tool install --global dotnet-ef
```

