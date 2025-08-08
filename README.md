<h1>ASPFOTNETCOREAPI</h1>

<h3>CRUD</h3>

<u>Pacckages</u>

dotnet add package Pomelo.EntityFrameworkCore.MySql

dotnet add package Swashbuckle.AspNetCore

dotnet tool install --global dotnet-ef

dotnet ef migrations add InitialCreate

dotnet ef database update
