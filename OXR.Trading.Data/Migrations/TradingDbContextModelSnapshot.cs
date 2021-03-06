﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OXR.Trading.Data.Entities;

namespace OXR.Trading.Data.Migrations
{
    [DbContext(typeof(TradingDbContext))]
    partial class TradingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OXR.Trading.Data.Entities.DailyProfit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DealDay")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ProfitInGBP")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("DailyProfits");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DealDay = new DateTime(2020, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProfitInGBP = 1012.08m
                        },
                        new
                        {
                            Id = 2,
                            DealDay = new DateTime(2020, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProfitInGBP = 32.65m
                        },
                        new
                        {
                            Id = 3,
                            DealDay = new DateTime(2020, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProfitInGBP = 53.10m
                        },
                        new
                        {
                            Id = 4,
                            DealDay = new DateTime(2020, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProfitInGBP = 2359.94m
                        },
                        new
                        {
                            Id = 5,
                            DealDay = new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProfitInGBP = 2458.45m
                        },
                        new
                        {
                            Id = 6,
                            DealDay = new DateTime(2020, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProfitInGBP = 485.13m
                        },
                        new
                        {
                            Id = 7,
                            DealDay = new DateTime(2020, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProfitInGBP = 531.00m
                        },
                        new
                        {
                            Id = 8,
                            DealDay = new DateTime(2020, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProfitInGBP = 9833.80m
                        },
                        new
                        {
                            Id = 9,
                            DealDay = new DateTime(2020, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProfitInGBP = 765.00m
                        },
                        new
                        {
                            Id = 10,
                            DealDay = new DateTime(2020, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProfitInGBP = 3288.65m
                        });
                });

            modelBuilder.Entity("OXR.Trading.Data.Entities.Trade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BrokerRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BuyingCurrency")
                        .HasColumnType("int");

                    b.Property<string>("ClientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DealDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ProfitInBuyingCurrency")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ProfitInGBP")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PurchasedAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SellingCurrency")
                        .HasColumnType("int");

                    b.Property<decimal>("SoldAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Trades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrokerRate = 592.39m,
                            BuyingCurrency = 49,
                            ClientName = "",
                            DealDate = new DateTime(2020, 4, 17, 17, 38, 9, 0, DateTimeKind.Unspecified),
                            ProfitInBuyingCurrency = 28.70m,
                            ProfitInGBP = 28.70m,
                            PurchasedAmount = 1176.58m,
                            SellingCurrency = 3,
                            SoldAmount = 680000m
                        },
                        new
                        {
                            Id = 2,
                            BrokerRate = 0.01m,
                            BuyingCurrency = 73,
                            ClientName = "PlanetCur LTD",
                            DealDate = new DateTime(2020, 4, 17, 17, 38, 9, 0, DateTimeKind.Unspecified),
                            ProfitInBuyingCurrency = 130658.46m,
                            ProfitInGBP = 983.38m,
                            PurchasedAmount = 5356997.02m,
                            SellingCurrency = 46,
                            SoldAmount = 45000m
                        },
                        new
                        {
                            Id = 3,
                            BrokerRate = 20.32m,
                            BuyingCurrency = 0,
                            ClientName = "Senio Holding",
                            DealDate = new DateTime(2020, 4, 18, 17, 38, 9, 0, DateTimeKind.Unspecified),
                            ProfitInBuyingCurrency = 148.22m,
                            ProfitInGBP = 32.65m,
                            PurchasedAmount = 6059.11m,
                            SellingCurrency = 121,
                            SoldAmount = 120000m
                        },
                        new
                        {
                            Id = 4,
                            BrokerRate = 6.50m,
                            BuyingCurrency = 121,
                            ClientName = "RusAL Trade",
                            DealDate = new DateTime(2020, 4, 19, 17, 38, 9, 0, DateTimeKind.Unspecified),
                            ProfitInBuyingCurrency = 4876.90m,
                            ProfitInGBP = 53.10m,
                            PurchasedAmount = 152380.95m,
                            SellingCurrency = 3,
                            SoldAmount = 960000m
                        },
                        new
                        {
                            Id = 5,
                            BrokerRate = 125.00m,
                            BuyingCurrency = 0,
                            ClientName = "Al Sahim",
                            DealDate = new DateTime(2020, 4, 20, 17, 38, 9, 0, DateTimeKind.Unspecified),
                            ProfitInBuyingCurrency = 730.00m,
                            ProfitInGBP = 2283.44m,
                            PurchasedAmount = 29200.00m,
                            SellingCurrency = 3,
                            SoldAmount = 3650000m
                        },
                        new
                        {
                            Id = 6,
                            BrokerRate = 82.67m,
                            BuyingCurrency = 46,
                            ClientName = "Omega Trade",
                            DealDate = new DateTime(2020, 4, 20, 17, 38, 9, 0, DateTimeKind.Unspecified),
                            ProfitInBuyingCurrency = 85.20m,
                            ProfitInGBP = 76.5m,
                            PurchasedAmount = 3174.01m,
                            SellingCurrency = 121,
                            SoldAmount = 256000m
                        },
                        new
                        {
                            Id = 7,
                            BrokerRate = 0.01m,
                            BuyingCurrency = 73,
                            ClientName = "JT Carmax",
                            DealDate = new DateTime(2020, 4, 21, 17, 38, 9, 0, DateTimeKind.Unspecified),
                            ProfitInBuyingCurrency = 326646.15m,
                            ProfitInGBP = 2458.45m,
                            PurchasedAmount = 13392492.55m,
                            SellingCurrency = 46,
                            SoldAmount = 112500m
                        },
                        new
                        {
                            Id = 8,
                            BrokerRate = 196.33m,
                            BuyingCurrency = 46,
                            ClientName = "PanArm Tdx",
                            DealDate = new DateTime(2020, 4, 22, 17, 38, 9, 0, DateTimeKind.Unspecified),
                            ProfitInBuyingCurrency = 196.33m,
                            ProfitInGBP = 158.63m,
                            PurchasedAmount = 34591.19m,
                            SellingCurrency = 8,
                            SoldAmount = 16500000m
                        },
                        new
                        {
                            Id = 9,
                            BrokerRate = 20.32m,
                            BuyingCurrency = 0,
                            ClientName = "Sunville LTD",
                            DealDate = new DateTime(2020, 4, 22, 17, 38, 9, 0, DateTimeKind.Unspecified),
                            ProfitInBuyingCurrency = 1482.20m,
                            ProfitInGBP = 326.50m,
                            PurchasedAmount = 60591.10m,
                            SellingCurrency = 121,
                            SoldAmount = 1200000m
                        },
                        new
                        {
                            Id = 10,
                            BrokerRate = 6.50m,
                            BuyingCurrency = 121,
                            ClientName = "CreoMiga LLC",
                            DealDate = new DateTime(2020, 4, 23, 17, 38, 9, 0, DateTimeKind.Unspecified),
                            ProfitInBuyingCurrency = 48769.00m,
                            ProfitInGBP = 531.00m,
                            PurchasedAmount = 1523809.50m,
                            SellingCurrency = 9,
                            SoldAmount = 9600000m
                        },
                        new
                        {
                            Id = 11,
                            BrokerRate = 0.01m,
                            BuyingCurrency = 73,
                            ClientName = "CargMatrix LTD",
                            DealDate = new DateTime(2020, 4, 24, 17, 38, 9, 0, DateTimeKind.Unspecified),
                            ProfitInBuyingCurrency = 1306584.60m,
                            ProfitInGBP = 9833.80m,
                            PurchasedAmount = 53569970.20m,
                            SellingCurrency = 46,
                            SoldAmount = 450000m
                        },
                        new
                        {
                            Id = 12,
                            BrokerRate = 82.67m,
                            BuyingCurrency = 46,
                            ClientName = "TahiArab Utd",
                            DealDate = new DateTime(2020, 4, 25, 17, 38, 9, 0, DateTimeKind.Unspecified),
                            ProfitInBuyingCurrency = 852.05m,
                            ProfitInGBP = 765.00m,
                            PurchasedAmount = 30965.98m,
                            SellingCurrency = 121,
                            SoldAmount = 2560000.00m
                        },
                        new
                        {
                            Id = 13,
                            BrokerRate = 479.87m,
                            BuyingCurrency = 150,
                            ClientName = "AniZeld Union",
                            DealDate = new DateTime(2020, 4, 29, 17, 38, 9, 0, DateTimeKind.Unspecified),
                            ProfitInBuyingCurrency = 4076.65m,
                            ProfitInGBP = 3288.65m,
                            PurchasedAmount = 167142.80m,
                            SellingCurrency = 3,
                            SoldAmount = 78250000.00m
                        },
                        new
                        {
                            Id = 14,
                            BrokerRate = 115.95m,
                            BuyingCurrency = 46,
                            ClientName = "KavaMax GRX",
                            DealDate = new DateTime(2020, 4, 30, 11, 26, 34, 0, DateTimeKind.Unspecified),
                            ProfitInBuyingCurrency = 11858.84m,
                            ProfitInGBP = 10351.93m,
                            PurchasedAmount = 486212.50m,
                            SellingCurrency = 73,
                            SoldAmount = 55000000.00m
                        },
                        new
                        {
                            Id = 15,
                            BrokerRate = 1.51m,
                            BuyingCurrency = 46,
                            ClientName = "OakNest Village",
                            DealDate = new DateTime(2020, 4, 30, 14, 11, 5, 0, DateTimeKind.Unspecified),
                            ProfitInBuyingCurrency = 5317.58m,
                            ProfitInGBP = 4617.85m,
                            PurchasedAmount = 218020.98m,
                            SellingCurrency = 26,
                            SoldAmount = 320700.00m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
