# WebApis_NetCore_EntityFrameWorkCore
Sample projects demonstrates how to create web api's using .net core along with entity frame work core


command line for db scaffolding:

Scaffold-DbContext "Server=.\SQLExpress;Database=SchoolDB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models


refreshing or re-initializing the db context use force flag in command:
Scaffold-DbContext "Server=.\SQLExpress;Database=SchoolDB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -force
