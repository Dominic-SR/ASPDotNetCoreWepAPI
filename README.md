<h1>ASPFOTNETCOREAPI</h1>

<ul>
    <li>CRUD</li>
</ul>

dotnet add package Pomelo.EntityFrameworkCore.MySql

dotnet tool install --global dotnet-ef
dotnet ef migrations add InitialCreate
dotnet ef database update
