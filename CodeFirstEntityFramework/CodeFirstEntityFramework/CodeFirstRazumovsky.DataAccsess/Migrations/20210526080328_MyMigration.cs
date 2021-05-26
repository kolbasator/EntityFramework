using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstEntityFramework.Migrations
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Starring_ActorId",
                table: "Starring");

            migrationBuilder.DropIndex(
                name: "IX_Rentals_CopyId",
                table: "Rentals");

            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Starring",
                table: "Starring",
                columns: new[] { "ActorId", "MovieId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rentals",
                table: "Rentals",
                columns: new[] { "CopyId", "ClientId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                columns: new[] { "Firstname", "Lastname" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "Birthday", "Firstname", "Lastname" },
                values: new object[,]
                {
                    { 1, new DateTime(2001, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Johnson" },
                    { 2, new DateTime(2008, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carl", "Johnson" },
                    { 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark", "Johnson" },
                    { 4, new DateTime(1998, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khabib", "Nurmagomedov" },
                    { 5, new DateTime(1976, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paul", "Chicken" },
                    { 6, new DateTime(1987, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pablo", "Eskobar" },
                    { 7, new DateTime(2011, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Louis", "Gabriel" },
                    { 8, new DateTime(1965, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genry", "McChicken" },
                    { 9, new DateTime(1994, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dungeon", "Master" },
                    { 10, new DateTime(2000, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Egor", "Popov" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "Birthday", "Firstname", "Lastname" },
                values: new object[,]
                {
                    { 9, new DateTime(1998, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark", "McGregor" },
                    { 8, new DateTime(1987, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paul", "Sonnen" },
                    { 7, new DateTime(1976, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack", "Lee" },
                    { 6, new DateTime(1976, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leon", "Gabriel" },
                    { 10, new DateTime(1989, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chail", "Sonnen" },
                    { 4, new DateTime(1978, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rock", "Lee" },
                    { 3, new DateTime(1937, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patrick", "Johnson" },
                    { 2, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", "Johnson" },
                    { 1, new DateTime(2001, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Johnson" },
                    { 5, new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rick", "Sanchez" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Firstname", "Lastname", "Birthday", "City" },
                values: new object[,]
                {
                    { "Kirill", "Chebotarev", new DateTime(2017, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moscow" },
                    { "Chail", "Smith", new DateTime(1999, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "London" },
                    { "John", "Johnson", new DateTime(1987, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "London" },
                    { "Peter", "Sanchez", new DateTime(1997, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Orleans" },
                    { "Ben", "Johnson", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "London" },
                    { "Louis", "Lennon", new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Orleans" },
                    { "Carl", "Gabriel", new DateTime(2008, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York" },
                    { "Johnatan", "Galindo", new DateTime(1997, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York" },
                    { "Petr", "Kolosov", new DateTime(2001, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York" },
                    { "Peter", "Armstrong", new DateTime(1956, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Orleans" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "AgeRestriction", "Price", "Title", "Year" },
                values: new object[,]
                {
                    { 9, 12, 10f, "The Incredibles", 1984 },
                    { 1, 12, 10f, "Terminator", 1984 },
                    { 2, 12, 10f, "Ghostbusters", 1984 },
                    { 3, 12, 10f, "Taxi Driver", 1984 },
                    { 4, 12, 10f, "Frantic", 1984 },
                    { 5, 12, 10f, "Ronin", 1984 },
                    { 6, 12, 10f, "Leon: the Professional", 1984 },
                    { 7, 12, 10f, "Platoon", 1984 },
                    { 8, 12, 10f, "Mission Impossible", 1984 },
                    { 10, 12, 10f, "Analyze This", 1984 }
                });

            migrationBuilder.InsertData(
                table: "Copies",
                columns: new[] { "CopyId", "Available", "MovieId" },
                values: new object[,]
                {
                    { 1, false, 1 },
                    { 10, false, 10 },
                    { 9, false, 9 },
                    { 8, false, 8 },
                    { 7, false, 7 },
                    { 5, false, 5 },
                    { 6, false, 6 },
                    { 3, false, 3 },
                    { 2, false, 2 },
                    { 4, false, 4 }
                });

            migrationBuilder.InsertData(
                table: "Starring",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 8, 5 },
                    { 4, 10 },
                    { 6, 6 },
                    { 3, 1 },
                    { 5, 8 },
                    { 10, 8 },
                    { 2, 1 },
                    { 3, 9 },
                    { 1, 1 },
                    { 5, 10 }
                });

            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "ClientId", "CopyId", "DateOfRental", "DateOfReturn" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 5, 26, 14, 3, 28, 17, DateTimeKind.Local).AddTicks(5608), new DateTime(2021, 5, 26, 14, 3, 28, 17, DateTimeKind.Local).AddTicks(5608) },
                    { 2, 2, new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608), new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608) },
                    { 3, 3, new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608), new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608) },
                    { 4, 4, new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608), new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608) },
                    { 5, 5, new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608), new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608) },
                    { 6, 6, new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608), new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608) },
                    { 7, 7, new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608), new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608) },
                    { 8, 8, new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608), new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608) },
                    { 9, 9, new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608), new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608) },
                    { 10, 10, new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608), new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Starring",
                table: "Starring");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rentals",
                table: "Rentals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumns: new[] { "Firstname", "Lastname" },
                keyValues: new object[] { "Ben", "Johnson" });

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumns: new[] { "Firstname", "Lastname" },
                keyValues: new object[] { "Carl", "Gabriel" });

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumns: new[] { "Firstname", "Lastname" },
                keyValues: new object[] { "Chail", "Smith" });

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumns: new[] { "Firstname", "Lastname" },
                keyValues: new object[] { "John", "Johnson" });

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumns: new[] { "Firstname", "Lastname" },
                keyValues: new object[] { "Johnatan", "Galindo" });

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumns: new[] { "Firstname", "Lastname" },
                keyValues: new object[] { "Kirill", "Chebotarev" });

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumns: new[] { "Firstname", "Lastname" },
                keyValues: new object[] { "Louis", "Lennon" });

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumns: new[] { "Firstname", "Lastname" },
                keyValues: new object[] { "Peter", "Armstrong" });

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumns: new[] { "Firstname", "Lastname" },
                keyValues: new object[] { "Peter", "Sanchez" });

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumns: new[] { "Firstname", "Lastname" },
                keyValues: new object[] { "Petr", "Kolosov" });

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "Employees",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "Employees",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateIndex(
                name: "IX_Starring_ActorId",
                table: "Starring",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_CopyId",
                table: "Rentals",
                column: "CopyId");
        }
    }
}
