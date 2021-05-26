# EntityFramework
## CodeFirst
![Schema](https://github.com/kolbasator/EntityFrameworkRazumovsky/blob/master/CodeFirstEntityFramework/CodeFirstEntityFramework/schema.jpg)
1. First of all I created a .NET Core project in Visual Studio.
2. Then I added the application context and its implementation. Also I created the model interfaces and their implementation.
3. I created separate configuration files for each table. In them I defined foreign and primary keys.In tables that do not have an identifier (like the "Employees" table) 
I made composite primary keys. I made foreign keys using "One-to-many" and "Many-to-one" relationships.Also in the seed method I initialized the table with initial data.
4. I also added migrations to my project.I did this with the "dotnet ef migrations add [MigrationName]" and "dotnet ef database update" commands.

