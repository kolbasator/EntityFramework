using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstEntityFramework.Migrations
{
    public partial class MRazumovsky : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValues: new object[] { 2, 2 });

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

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Employees");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfReturn",
                table: "Rentals",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfRental",
                table: "Rentals",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Employees",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Salary",
                table: "Employees",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "Clients",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(1947, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arnold", "Schwarzenegger" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(1946, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anthony", "Daniels" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(1942, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harrison", "Ford" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(1956, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carrie", "Fisher" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 5,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(1914, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alec", "Guiness" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 6,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(1913, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter", "Cushing" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 7,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(1944, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", "Prowse" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 8,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(1935, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter", "Mayhew" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 9,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(1956, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael", "Biehn" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 10,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(1956, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Linda", "Hamilton" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "Birthday", "Firstname", "Lastname" },
                values: new object[,]
                {
                    { 28, new DateTime(1962, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tom", "Cruise" },
                    { 27, new DateTime(1981, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natalie", "Portman" },
                    { 26, new DateTime(1958, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gary", "Oldman" },
                    { 25, new DateTime(1963, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lisa", "Kudrow" },
                    { 11, new DateTime(1950, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bill", "Murray" },
                    { 23, new DateTime(1948, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jean", "Reno" },
                    { 22, new DateTime(1966, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emmanuelle", "Seigner" },
                    { 21, new DateTime(1942, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harrison", "Ford" },
                    { 12, new DateTime(1952, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dan", "Aykroyd" },
                    { 20, new DateTime(1965, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charlie", "Sheen" },
                    { 13, new DateTime(1949, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sigourney", "Weaver" },
                    { 14, new DateTime(1943, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert", "De Niro" },
                    { 15, new DateTime(1962, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jodie", "Foster" },
                    { 16, new DateTime(1939, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harvey", "Keitel" },
                    { 17, new DateTime(1950, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cybill", "Shepherd" },
                    { 18, new DateTime(1949, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tom", "Berenger" },
                    { 19, new DateTime(1955, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Willem", "Dafoe" },
                    { 24, new DateTime(1948, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Billy", "Crystal" }
                });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 1,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(1954, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hank", "Hill" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 2,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(2011, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brian", "Griffin" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 3,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(1989, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gary", "Goodspeed" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 4,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(1977, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob", "Belcher" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 5,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(2012, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lisa", "Simpson" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 6,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(1965, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rick", "Sanchez" });

            migrationBuilder.UpdateData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 1,
                column: "Available",
                value: true);

            migrationBuilder.UpdateData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 2,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 3,
                columns: new[] { "Available", "MovieId" },
                values: new object[] { true, 2 });

            migrationBuilder.UpdateData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 4,
                columns: new[] { "Available", "MovieId" },
                values: new object[] { true, 3 });

            migrationBuilder.UpdateData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 5,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 6,
                columns: new[] { "Available", "MovieId" },
                values: new object[] { true, 3 });

            migrationBuilder.UpdateData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 7,
                columns: new[] { "Available", "MovieId" },
                values: new object[] { true, 4 });

            migrationBuilder.UpdateData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 8,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 9,
                columns: new[] { "Available", "MovieId" },
                values: new object[] { true, 6 });

            migrationBuilder.UpdateData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 10,
                column: "MovieId",
                value: 6);

            migrationBuilder.InsertData(
                table: "Copies",
                columns: new[] { "CopyId", "Available", "MovieId" },
                values: new object[,]
                {
                    { 14, false, 8 },
                    { 19, true, 10 },
                    { 18, true, 10 },
                    { 17, false, 10 },
                    { 16, true, 10 },
                    { 15, true, 9 },
                    { 20, true, 10 },
                    { 13, true, 7 },
                    { 12, true, 7 },
                    { 11, true, 6 }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumns: new[] { "Firstname", "Lastname" },
                keyValues: new object[] { "Ben", "Johnson" },
                columns: new[] { "City", "EmployeeId", "Salary" },
                values: new object[] { "New York", 2, 250f });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Firstname", "Lastname", "City", "EmployeeId", "Salary" },
                values: new object[,]
                {
                    { "Peter", "Gabriel", "London", 5, 150f },
                    { "Louis", "Armstrong", "New Orleans", 3, 75f },
                    { "John", "Smith", "New York", 1, 150f },
                    { "John", "Lennon", "London", 4, 300f }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "Title", "Year" },
                values: new object[] { "Star Wars Episode IV: A New Hope", 1979 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                column: "Price",
                value: 5.5f);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "AgeRestriction", "Price", "Title" },
                values: new object[] { 15, 8.5f, "Terminator" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "AgeRestriction", "Price", "Title", "Year" },
                values: new object[] { 17, 5f, "Taxi Driver", 1976 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "AgeRestriction", "Price", "Title", "Year" },
                values: new object[] { 18, 5f, "Platoon", 1986 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "AgeRestriction", "Price", "Title", "Year" },
                values: new object[] { 15, 8.5f, "Frantic", 1988 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7,
                columns: new[] { "AgeRestriction", "Price", "Title", "Year" },
                values: new object[] { 13, 9.5f, "Ronin", 1998 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8,
                columns: new[] { "AgeRestriction", "Price", "Title", "Year" },
                values: new object[] { 16, 10.5f, "Analyze This", 1999 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9,
                columns: new[] { "AgeRestriction", "Price", "Title", "Year" },
                values: new object[] { 16, 8.5f, "Leon: the Professional", 1994 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10,
                columns: new[] { "AgeRestriction", "Price", "Title", "Year" },
                values: new object[] { 13, 8.5f, "Mission Impossible", 1996 });

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "DateOfRental", "DateOfReturn" },
                values: new object[] { new DateTime(2005, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "DateOfRental", "DateOfReturn" },
                values: new object[] { new DateTime(2005, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "ClientId", "CopyId", "DateOfRental", "DateOfReturn" },
                values: new object[,]
                {
                    { 6, 7, new DateTime(2005, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, new DateTime(2005, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 7, new DateTime(2005, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 7, new DateTime(2005, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 5, new DateTime(2005, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 3, new DateTime(2005, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 6, new DateTime(2005, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Starring",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 9, 3 },
                    { 1, 3 },
                    { 8, 1 },
                    { 6, 1 },
                    { 5, 1 },
                    { 4, 1 },
                    { 10, 3 },
                    { 7, 1 }
                });

            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "ClientId", "CopyId", "DateOfRental", "DateOfReturn" },
                values: new object[,]
                {
                    { 3, 20, new DateTime(2005, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 13, new DateTime(2005, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 12, new DateTime(2005, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 11, new DateTime(2005, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 19, new DateTime(2005, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Starring",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 28, 10 },
                    { 27, 9 },
                    { 25, 8 },
                    { 24, 8 },
                    { 23, 10 },
                    { 23, 9 },
                    { 23, 7 },
                    { 22, 6 },
                    { 21, 6 },
                    { 19, 5 },
                    { 18, 5 },
                    { 17, 4 },
                    { 16, 4 },
                    { 15, 4 },
                    { 14, 8 },
                    { 14, 7 },
                    { 14, 4 },
                    { 13, 2 },
                    { 12, 2 },
                    { 20, 5 },
                    { 11, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumns: new[] { "Firstname", "Lastname" },
                keyValues: new object[] { "John", "Lennon" });

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumns: new[] { "Firstname", "Lastname" },
                keyValues: new object[] { "John", "Smith" });

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumns: new[] { "Firstname", "Lastname" },
                keyValues: new object[] { "Louis", "Armstrong" });

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumns: new[] { "Firstname", "Lastname" },
                keyValues: new object[] { "Peter", "Gabriel" });

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 4, 13 });

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 6, 19 });

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 3, 20 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 14, 8 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 17, 4 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 18, 5 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 19, 5 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 20, 5 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 21, 6 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 22, 6 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 23, 7 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 23, 9 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 23, 10 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 24, 8 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 25, 8 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 27, 9 });

            migrationBuilder.DeleteData(
                table: "Starring",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 28, 10 });

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Employees");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfReturn",
                table: "Rentals",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfRental",
                table: "Rentals",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "Employees",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "Clients",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(2001, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Johnson" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(2008, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carl", "Johnson" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark", "Johnson" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(1998, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khabib", "Nurmagomedov" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 5,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(1976, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paul", "Chicken" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 6,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(1987, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pablo", "Eskobar" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 7,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(2011, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Louis", "Gabriel" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 8,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(1965, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genry", "McChicken" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 9,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(1994, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dungeon", "Master" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 10,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(2000, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Egor", "Popov" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 1,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(2001, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Johnson" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 2,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", "Johnson" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 3,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(1937, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patrick", "Johnson" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 4,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(1978, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rock", "Lee" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 5,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rick", "Sanchez" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 6,
                columns: new[] { "Birthday", "Firstname", "Lastname" },
                values: new object[] { new DateTime(1976, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leon", "Gabriel" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "Birthday", "Firstname", "Lastname" },
                values: new object[,]
                {
                    { 7, new DateTime(1976, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack", "Lee" },
                    { 9, new DateTime(1998, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark", "McGregor" },
                    { 8, new DateTime(1987, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paul", "Sonnen" },
                    { 10, new DateTime(1989, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chail", "Sonnen" }
                });

            migrationBuilder.UpdateData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 1,
                column: "Available",
                value: false);

            migrationBuilder.UpdateData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 2,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 3,
                columns: new[] { "Available", "MovieId" },
                values: new object[] { false, 3 });

            migrationBuilder.UpdateData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 4,
                columns: new[] { "Available", "MovieId" },
                values: new object[] { false, 4 });

            migrationBuilder.UpdateData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 5,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 6,
                columns: new[] { "Available", "MovieId" },
                values: new object[] { false, 6 });

            migrationBuilder.UpdateData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 7,
                columns: new[] { "Available", "MovieId" },
                values: new object[] { false, 7 });

            migrationBuilder.UpdateData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 8,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 9,
                columns: new[] { "Available", "MovieId" },
                values: new object[] { false, 9 });

            migrationBuilder.UpdateData(
                table: "Copies",
                keyColumn: "CopyId",
                keyValue: 10,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumns: new[] { "Firstname", "Lastname" },
                keyValues: new object[] { "Ben", "Johnson" },
                columns: new[] { "Birthday", "City" },
                values: new object[] { new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "London" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Firstname", "Lastname", "Birthday", "City" },
                values: new object[,]
                {
                    { "Kirill", "Chebotarev", new DateTime(2017, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moscow" },
                    { "Petr", "Kolosov", new DateTime(2001, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York" },
                    { "Johnatan", "Galindo", new DateTime(1997, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York" },
                    { "Carl", "Gabriel", new DateTime(2008, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York" },
                    { "Peter", "Sanchez", new DateTime(1997, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Orleans" },
                    { "Peter", "Armstrong", new DateTime(1956, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Orleans" },
                    { "John", "Johnson", new DateTime(1987, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "London" },
                    { "Chail", "Smith", new DateTime(1999, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "London" },
                    { "Louis", "Lennon", new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Orleans" }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "Title", "Year" },
                values: new object[] { "Terminator", 1984 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                column: "Price",
                value: 10f);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "AgeRestriction", "Price", "Title" },
                values: new object[] { 12, 10f, "Taxi Driver" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "AgeRestriction", "Price", "Title", "Year" },
                values: new object[] { 12, 10f, "Frantic", 1984 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "AgeRestriction", "Price", "Title", "Year" },
                values: new object[] { 12, 10f, "Ronin", 1984 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "AgeRestriction", "Price", "Title", "Year" },
                values: new object[] { 12, 10f, "Leon: the Professional", 1984 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7,
                columns: new[] { "AgeRestriction", "Price", "Title", "Year" },
                values: new object[] { 12, 10f, "Platoon", 1984 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8,
                columns: new[] { "AgeRestriction", "Price", "Title", "Year" },
                values: new object[] { 12, 10f, "Mission Impossible", 1984 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9,
                columns: new[] { "AgeRestriction", "Price", "Title", "Year" },
                values: new object[] { 12, 10f, "The Incredibles", 1984 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10,
                columns: new[] { "AgeRestriction", "Price", "Title", "Year" },
                values: new object[] { 12, 10f, "Analyze This", 1984 });

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "DateOfRental", "DateOfReturn" },
                values: new object[] { new DateTime(2021, 5, 26, 14, 3, 28, 17, DateTimeKind.Local).AddTicks(5608), new DateTime(2021, 5, 26, 14, 3, 28, 17, DateTimeKind.Local).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumns: new[] { "ClientId", "CopyId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "DateOfRental", "DateOfReturn" },
                values: new object[] { new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608), new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608) });

            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "ClientId", "CopyId", "DateOfRental", "DateOfReturn" },
                values: new object[,]
                {
                    { 2, 2, new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608), new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608) },
                    { 4, 4, new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608), new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608) },
                    { 5, 5, new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608), new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608) },
                    { 6, 6, new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608), new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608) }
                });

            migrationBuilder.InsertData(
                table: "Starring",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 10, 8 },
                    { 8, 5 },
                    { 6, 6 },
                    { 5, 10 },
                    { 4, 10 },
                    { 3, 9 },
                    { 5, 8 },
                    { 2, 1 },
                    { 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "ClientId", "CopyId", "DateOfRental", "DateOfReturn" },
                values: new object[,]
                {
                    { 7, 7, new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608), new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608) },
                    { 8, 8, new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608), new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608) },
                    { 9, 9, new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608), new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608) },
                    { 10, 10, new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608), new DateTime(2021, 5, 26, 14, 3, 28, 18, DateTimeKind.Local).AddTicks(5608) }
                });
        }
    }
}
