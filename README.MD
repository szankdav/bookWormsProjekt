## Create database, table, and table datas with the sql files, using SQL SMS
booksDB.sql
booksTable.sql
booksData.sql

## After the database created, create a new dotnet webapi app
dotnet new webapi -n BwpBackend

## Navigate to directory
cd BwpBackend

## Install Entity Framework Core and Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design

## Scaffold the Entity Model from the Database into the Models folder
dotnet ef dbcontext scaffold "Server=YOUR_SERVER_NAME;Database=SampleDB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models

## Create a Web API Controller
mkdir Controllers
cd Controllers
code BooksController.cs
Configure the Controller
More info : https://learn.microsoft.com/en-us/aspnet/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2

## For local develepoment, trust the HTTPS certificate:
dotnet dev-certs https --trust
Click yes

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

<!-- ## Install VUEX
npm install vuex@next --save -->

## IN SEPARATE TERMINALS:
## Run in dev mode
npm run dev

## Run the app in https profile:
dotnet run --launch-profile https
Open the served route in browser

<!-- ## Run the app in http profile:
Comment out app.UseHttpsRedirection(); line in Program.cs
dotnet run -->