using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OXR.Trading.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyProfits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfitInGBP = table.Column<decimal>(nullable: false),
                    DealDay = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyProfits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SellingCurrency = table.Column<int>(nullable: false),
                    BuyingCurrency = table.Column<int>(nullable: false),
                    SoldAmount = table.Column<decimal>(nullable: false),
                    PurchasedAmount = table.Column<decimal>(nullable: false),
                    BrokerRate = table.Column<decimal>(nullable: false),
                    ProfitInBuyingCurrency = table.Column<decimal>(nullable: false),
                    ProfitInGBP = table.Column<decimal>(nullable: false),
                    ClientName = table.Column<string>(nullable: true),
                    DealDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trades", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DailyProfits",
                columns: new[] { "Id", "DealDay", "ProfitInGBP" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1012.08m },
                    { 2, new DateTime(2020, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 32.65m },
                    { 3, new DateTime(2020, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 53.10m },
                    { 4, new DateTime(2020, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2359.94m },
                    { 5, new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2458.45m },
                    { 6, new DateTime(2020, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 485.13m },
                    { 7, new DateTime(2020, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 531.00m },
                    { 8, new DateTime(2020, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 9833.80m },
                    { 9, new DateTime(2020, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 765.00m },
                    { 10, new DateTime(2020, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3288.65m }
                });

            migrationBuilder.InsertData(
                table: "Trades",
                columns: new[] { "Id", "BrokerRate", "BuyingCurrency", "ClientName", "DealDate", "ProfitInBuyingCurrency", "ProfitInGBP", "PurchasedAmount", "SellingCurrency", "SoldAmount" },
                values: new object[,]
                {
                    { 13, 479.87m, 150, "AniZeld Union", new DateTime(2020, 4, 29, 17, 38, 9, 0, DateTimeKind.Unspecified), 4076.65m, 3288.65m, 167142.80m, 3, 78250000.00m },
                    { 12, 82.67m, 46, "TahiArab Utd", new DateTime(2020, 4, 25, 17, 38, 9, 0, DateTimeKind.Unspecified), 852.05m, 765.00m, 30965.98m, 121, 2560000.00m },
                    { 11, 0.01m, 73, "CargMatrix LTD", new DateTime(2020, 4, 24, 17, 38, 9, 0, DateTimeKind.Unspecified), 1306584.60m, 9833.80m, 53569970.20m, 46, 450000m },
                    { 10, 6.50m, 121, "CreoMiga LLC", new DateTime(2020, 4, 23, 17, 38, 9, 0, DateTimeKind.Unspecified), 48769.00m, 531.00m, 1523809.50m, 9, 9600000m },
                    { 9, 20.32m, 0, "Sunville LTD", new DateTime(2020, 4, 22, 17, 38, 9, 0, DateTimeKind.Unspecified), 1482.20m, 326.50m, 60591.10m, 121, 1200000m },
                    { 8, 196.33m, 46, "PanArm Tdx", new DateTime(2020, 4, 22, 17, 38, 9, 0, DateTimeKind.Unspecified), 196.33m, 158.63m, 34591.19m, 8, 16500000m },
                    { 3, 20.32m, 0, "Senio Holding", new DateTime(2020, 4, 18, 17, 38, 9, 0, DateTimeKind.Unspecified), 148.22m, 32.65m, 6059.11m, 121, 120000m },
                    { 6, 82.67m, 46, "Omega Trade", new DateTime(2020, 4, 20, 17, 38, 9, 0, DateTimeKind.Unspecified), 85.20m, 76.5m, 3174.01m, 121, 256000m },
                    { 5, 125.00m, 0, "Al Sahim", new DateTime(2020, 4, 20, 17, 38, 9, 0, DateTimeKind.Unspecified), 730.00m, 2283.44m, 29200.00m, 3, 3650000m },
                    { 4, 6.50m, 121, "RusAL Trade", new DateTime(2020, 4, 19, 17, 38, 9, 0, DateTimeKind.Unspecified), 4876.90m, 53.10m, 152380.95m, 3, 960000m },
                    { 14, 115.95m, 46, "KavaMax GRX", new DateTime(2020, 4, 30, 11, 26, 34, 0, DateTimeKind.Unspecified), 11858.84m, 10351.93m, 486212.50m, 73, 55000000.00m },
                    { 2, 0.01m, 73, "PlanetCur LTD", new DateTime(2020, 4, 17, 17, 38, 9, 0, DateTimeKind.Unspecified), 130658.46m, 983.38m, 5356997.02m, 46, 45000m },
                    { 1, 592.39m, 49, "", new DateTime(2020, 4, 17, 17, 38, 9, 0, DateTimeKind.Unspecified), 28.70m, 28.70m, 1176.58m, 3, 680000m },
                    { 7, 0.01m, 73, "JT Carmax", new DateTime(2020, 4, 21, 17, 38, 9, 0, DateTimeKind.Unspecified), 326646.15m, 2458.45m, 13392492.55m, 46, 112500m },
                    { 15, 1.51m, 46, "OakNest Village", new DateTime(2020, 4, 30, 14, 11, 5, 0, DateTimeKind.Unspecified), 5317.58m, 4617.85m, 218020.98m, 26, 320700.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyProfits");

            migrationBuilder.DropTable(
                name: "Trades");
        }
    }
}
