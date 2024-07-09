## Create a new dotnet webapi app
dotnet new webapi -n BwpBackend

## Navigate to directory
cd BwpBackend

## Install Entity Framework Core SQLite and Design
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design

## Add Connection string in AppSetting.JSON File
// appsettings.json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=SQLLiteDatabase.db"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*"
}

## Create and apply migrations
dotnet ef migrations add InitialCreate
dotnet ef database update

## Create a Web API Controller and CRUD operations
mkdir Controllers
cd Controllers
code BooksController.cs
Configure the Controller
More info : https://learn.microsoft.com/en-us/aspnet/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2

## For local develepoment, trust the HTTPS certificate:
dotnet dev-certs https --trust
Click yes

## Insert datas to Books with sqlite3 shell:
https://sqlite.org/cli.html

## Sources:
https://www.c-sharpcorner.com/article/working-with-sql-lite-database-in-asp-net-core-web-api/
https://learn.microsoft.com/en-us/aspnet/core/security/enforcing-ssl?view=aspnetcore-8.0&tabs=visual-studio%2Clinux-ubuntu

## Install vue in project folder
npm init vue@latest with "BwpFrontend" project name

## First install dependecies
cd BwpFrontend
npm install

## Install bootstrap
npm install bootstrap

## Import Bootstrap: Open your main.js file and import Bootstrap:
import 'bootstrap/dist/css/bootstrap.css'

## Install VUE Axios to handel API connection
npm install --save axios vue-axios

## Sources:
https://vuejs.org/
https://www.patterns.dev/vue/