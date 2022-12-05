using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agency.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BUYER",
                columns: table => new
                {
                    Loginbuyer = table.Column<string>(name: "Login_buyer", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Fiobuyer = table.Column<string>(name: "Fio_buyer", type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PassportNumbuyer = table.Column<string>(name: "Passport_Num_buyer", type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    NomTelbuyer = table.Column<string>(name: "NomTel_buyer", type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
                    Passwordbuyer = table.Column<string>(name: "Password_buyer", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BUYER__481D8311A85EF61D", x => x.Loginbuyer);
                });

            migrationBuilder.CreateTable(
                name: "OWNER",
                columns: table => new
                {
                    LoginOwner = table.Column<string>(name: "Login_Owner", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    FioOwner = table.Column<string>(name: "Fio_Owner", type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PassportNumOwner = table.Column<string>(name: "Passport_Num_Owner", type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    NomTelOwner = table.Column<string>(name: "NomTel_Owner", type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
                    PasswordOwner = table.Column<string>(name: "Password_Owner", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OWNER__A868A6CF66D4D7FD", x => x.LoginOwner);
                });

            migrationBuilder.CreateTable(
                name: "SPECIALIST",
                columns: table => new
                {
                    LoginSpec = table.Column<string>(name: "Login_Spec", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    FioSpec = table.Column<string>(name: "Fio_Spec", type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NomTelSpec = table.Column<string>(name: "NomTel_Spec", type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Countdeals = table.Column<int>(name: "Count_deals", type: "int", nullable: true, defaultValueSql: "((0))"),
                    SalarySpec = table.Column<int>(name: "Salary_Spec", type: "int", nullable: true, computedColumnSql: "([Count_deals]*(5000)+(20000))", stored: true),
                    PasswordSpec = table.Column<string>(name: "Password_Spec", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SPECIALI__48F116870FA86323", x => x.LoginSpec);
                });

            migrationBuilder.CreateTable(
                name: "REQUEST",
                columns: table => new
                {
                    IDreq = table.Column<int>(name: "ID_req", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datareq = table.Column<DateTime>(name: "Data_req", type: "date", nullable: false),
                    Livespacereq = table.Column<double>(name: "Live_space_req", type: "float", nullable: false),
                    Generalspacereq = table.Column<double>(name: "General_space_req", type: "float", nullable: false),
                    Countroomsreq = table.Column<int>(name: "Count_rooms_req", type: "int", nullable: false),
                    Floorreq = table.Column<int>(name: "Floor_req", type: "int", nullable: false),
                    Typepostrreq = table.Column<string>(name: "Type_postr_req", type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Yearpostrreq = table.Column<int>(name: "Year_postr_req", type: "int", nullable: false),
                    Metroreq = table.Column<string>(name: "Metro_req", type: "nvarchar(8)", maxLength: 8, nullable: true, defaultValueSql: "('не рядом')"),
                    Furniturereq = table.Column<string>(name: "Furniture_req", type: "nvarchar(4)", maxLength: 4, nullable: true, defaultValueSql: "('нет')"),
                    MaxPricereq = table.Column<decimal>(name: "MaxPrice_req", type: "money", nullable: false),
                    Loginbuyer = table.Column<string>(name: "Login_buyer", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__REQUEST__182A6452793A75DC", x => x.IDreq);
                    table.ForeignKey(
                        name: "FK_REQUEST_BUYER",
                        column: x => x.Loginbuyer,
                        principalTable: "BUYER",
                        principalColumn: "Login_buyer");
                });

            migrationBuilder.CreateTable(
                name: "APARTMENT",
                columns: table => new
                {
                    Kadastrnom = table.Column<string>(name: "Kadastr_nom", type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Livespace = table.Column<double>(name: "Live_space", type: "float", nullable: false),
                    Generalspace = table.Column<double>(name: "General_space", type: "float", nullable: false),
                    Countrooms = table.Column<int>(name: "Count_rooms", type: "int", nullable: false),
                    NumFloor = table.Column<int>(type: "int", nullable: false),
                    Typebuild = table.Column<string>(name: "Type_build", type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Yearbuild = table.Column<int>(name: "Year_build", type: "int", nullable: false),
                    Metro = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true, defaultValueSql: "('не рядом')"),
                    Furniture = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true, defaultValueSql: "('нет')"),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    LoginOwner = table.Column<string>(name: "Login_Owner", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APARTMEN__D958E5500F677B68", x => x.Kadastrnom);
                    table.ForeignKey(
                        name: "FK_APARTMENT_OWNER",
                        column: x => x.LoginOwner,
                        principalTable: "OWNER",
                        principalColumn: "Login_Owner");
                });

            migrationBuilder.CreateTable(
                name: "DEAL",
                columns: table => new
                {
                    Koddeal = table.Column<int>(name: "Kod_deal", type: "int", nullable: false),
                    Datadeal = table.Column<DateTime>(name: "Data_deal", type: "date", nullable: false),
                    LoginSpec = table.Column<string>(name: "Login_Spec", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Kadastrnom = table.Column<string>(name: "Kadastr_nom", type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    Loginbuyer = table.Column<string>(name: "Login_buyer", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DEAL__895C7B22816BC87E", x => x.Koddeal);
                    table.ForeignKey(
                        name: "FK_APARTMENT_BUYER",
                        column: x => x.Loginbuyer,
                        principalTable: "BUYER",
                        principalColumn: "Login_buyer");
                    table.ForeignKey(
                        name: "FK_APARTMENT_DEAL",
                        column: x => x.Kadastrnom,
                        principalTable: "APARTMENT",
                        principalColumn: "Kadastr_nom");
                    table.ForeignKey(
                        name: "FK_DEAL_SPECIALIST",
                        column: x => x.LoginSpec,
                        principalTable: "SPECIALIST",
                        principalColumn: "Login_Spec");
                });

            migrationBuilder.CreateIndex(
                name: "IX_APARTMENT_Login_Owner",
                table: "APARTMENT",
                column: "Login_Owner");

            migrationBuilder.CreateIndex(
                name: "UQ__APARTMEN__08F62FE54ABDE498",
                table: "APARTMENT",
                column: "Adress",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__BUYER__9FBDDF007FFA9AC3",
                table: "BUYER",
                column: "Passport_Num_buyer",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__BUYER__E5D8C86D9B22DB7F",
                table: "BUYER",
                column: "NomTel_buyer",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DEAL_Kadastr_nom",
                table: "DEAL",
                column: "Kadastr_nom");

            migrationBuilder.CreateIndex(
                name: "IX_DEAL_Login_buyer",
                table: "DEAL",
                column: "Login_buyer");

            migrationBuilder.CreateIndex(
                name: "IX_DEAL_Login_Spec",
                table: "DEAL",
                column: "Login_Spec");

            migrationBuilder.CreateIndex(
                name: "UQ__OWNER__9E7EEF9536A88033",
                table: "OWNER",
                column: "Passport_Num_Owner",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__OWNER__BD061FB3CC2053C9",
                table: "OWNER",
                column: "NomTel_Owner",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_REQUEST_Login_buyer",
                table: "REQUEST",
                column: "Login_buyer");

            migrationBuilder.CreateIndex(
                name: "UQ__SPECIALI__70DC04A8AA3238A2",
                table: "SPECIALIST",
                column: "NomTel_Spec",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DEAL");

            migrationBuilder.DropTable(
                name: "REQUEST");

            migrationBuilder.DropTable(
                name: "APARTMENT");

            migrationBuilder.DropTable(
                name: "SPECIALIST");

            migrationBuilder.DropTable(
                name: "BUYER");

            migrationBuilder.DropTable(
                name: "OWNER");
        }
    }
}
