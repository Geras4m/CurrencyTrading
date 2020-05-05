using Microsoft.EntityFrameworkCore;
using System;

namespace OXR.Trading.Data.Entities
{
    public class TradingDbContext : DbContext
    {
        public TradingDbContext(DbContextOptions<TradingDbContext> options)
            : base(options)
        {
        }

        public DbSet<Trade> Trades { get; set; }
        public DbSet<DailyProfit> DailyProfits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trade>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Trade>()
               .Property<DateTime>("DealDate");

            #region Seeding Trade data
            modelBuilder.Entity<Trade>()
                .HasData(
                            new Trade()
                            {
                                Id= 1,
                                SellingCurrency = 3,
                                BuyingCurrency = 49,
                                SoldAmount = 680000M,
                                PurchasedAmount = 1176.58M,
                                BrokerRate = 592.39M,
                                ProfitInBuyingCurrency = 28.70M,
                                ProfitInGBP = 28.70M,
                                ClientName = "",
                                DealDate = new DateTime(2020, 04, 17, 17, 38, 09)
                            },
                            new Trade()
                            {
                                Id = 2,
                                SellingCurrency = 46,
                                BuyingCurrency = 73,
                                SoldAmount = 45000M,
                                PurchasedAmount = 5356997.02M,
                                BrokerRate = 0.01M,
                                ProfitInBuyingCurrency = 130658.46M,
                                ProfitInGBP = 983.38M,
                                ClientName = "PlanetCur LTD",
                                DealDate = new DateTime(2020, 04, 17, 17, 38, 09)
                            },
                            new Trade()
                            {
                                Id = 3,
                                SellingCurrency = 121,
                                BuyingCurrency = 0,
                                SoldAmount = 120000M,
                                PurchasedAmount = 6059.11M,
                                BrokerRate = 20.32M,
                                ProfitInBuyingCurrency = 148.22M,
                                ProfitInGBP = 32.65M,
                                ClientName = "Senio Holding",
                                DealDate = new DateTime(2020, 04, 18, 17, 38, 09)
                            },
                            new Trade()
                            {
                                Id = 4,
                                SellingCurrency = 3,
                                BuyingCurrency = 121,
                                SoldAmount = 960000M,
                                PurchasedAmount = 152380.95M,
                                BrokerRate = 6.50M,
                                ProfitInBuyingCurrency = 4876.90M,
                                ProfitInGBP = 53.10M,
                                ClientName = "RusAL Trade",
                                DealDate = new DateTime(2020, 04, 19, 17, 38, 09)
                            },
                            new Trade()
                            {
                                Id = 5,
                                SellingCurrency = 3,
                                BuyingCurrency = 0,
                                SoldAmount = 3650000M,
                                PurchasedAmount = 29200.00M,
                                BrokerRate = 125.00M,
                                ProfitInBuyingCurrency = 730.00M,
                                ProfitInGBP = 2283.44M,
                                ClientName = "Al Sahim",
                                DealDate = new DateTime(2020, 04, 20, 17, 38, 09)
                            },
                            new Trade()
                            {
                                Id = 6,
                                SellingCurrency = 121,
                                BuyingCurrency = 46,
                                SoldAmount = 256000M,
                                PurchasedAmount = 3174.01M,
                                BrokerRate = 82.67M,
                                ProfitInBuyingCurrency = 85.20M,
                                ProfitInGBP = 76.5M,
                                ClientName = "Omega Trade",
                                DealDate = new DateTime(2020, 04, 20, 17, 38, 09)
                            },
                            new Trade()
                            {
                                Id = 7,
                                SellingCurrency = 46,
                                BuyingCurrency = 73,
                                SoldAmount = 112500M,
                                PurchasedAmount = 13392492.55M,
                                BrokerRate = 0.01M,
                                ProfitInBuyingCurrency = 326646.15M,
                                ProfitInGBP = 2458.45M,
                                ClientName = "JT Carmax",
                                DealDate = new DateTime(2020, 04, 21, 17, 38, 09)
                            },
                            new Trade()
                            {
                                Id = 8,
                                SellingCurrency = 8,
                                BuyingCurrency = 46,
                                SoldAmount = 16500000M,
                                PurchasedAmount = 34591.19M,
                                BrokerRate = 196.33M,
                                ProfitInBuyingCurrency = 196.33M,
                                ProfitInGBP = 158.63M,
                                ClientName = "PanArm Tdx",
                                DealDate = new DateTime(2020, 04, 22, 17, 38, 09)
                            },
                            new Trade()
                            {
                                Id = 9,
                                SellingCurrency = 121,
                                BuyingCurrency = 0,
                                SoldAmount = 1200000M,
                                PurchasedAmount = 60591.10M,
                                BrokerRate = 20.32M,
                                ProfitInBuyingCurrency = 1482.20M,
                                ProfitInGBP = 326.50M,
                                ClientName = "Sunville LTD",
                                DealDate = new DateTime(2020, 04, 22, 17, 38, 09)
                            },
                            new Trade()
                            {
                                Id = 10,
                                SellingCurrency = 9,
                                BuyingCurrency = 121,
                                SoldAmount = 9600000M,
                                PurchasedAmount = 1523809.50M,
                                BrokerRate = 6.50M,
                                ProfitInBuyingCurrency = 48769.00M,
                                ProfitInGBP = 531.00M,
                                ClientName = "CreoMiga LLC",
                                DealDate = new DateTime(2020, 04, 23, 17, 38, 09)
                            },
                            new Trade()
                            {
                                Id = 11,
                                SellingCurrency = 46,
                                BuyingCurrency = 73,
                                SoldAmount = 450000,
                                PurchasedAmount = 53569970.20M,
                                BrokerRate = 0.01M,
                                ProfitInBuyingCurrency = 1306584.60M,
                                ProfitInGBP = 9833.80M,
                                ClientName = "CargMatrix LTD",
                                DealDate = new DateTime(2020, 04, 24, 17, 38, 09)
                            },
                            new Trade()
                            {
                                Id = 12,
                                SellingCurrency = 121,
                                BuyingCurrency = 46,
                                SoldAmount = 2560000.00M,
                                PurchasedAmount = 30965.98M,
                                BrokerRate = 82.67M,
                                ProfitInBuyingCurrency = 852.05M,
                                ProfitInGBP = 765.00M,
                                ClientName = "TahiArab Utd",
                                DealDate = new DateTime(2020, 04, 25, 17, 38, 09)
                            },
                            new Trade()
                            {
                                Id = 13,
                                SellingCurrency = 3,
                                BuyingCurrency = 150,
                                SoldAmount = 78250000.00M,
                                PurchasedAmount = 167142.80M,
                                BrokerRate = 479.87M,
                                ProfitInBuyingCurrency = 4076.65M,
                                ProfitInGBP = 3288.65M,
                                ClientName = "AniZeld Union",
                                DealDate = new DateTime(2020, 04, 29, 17, 38, 09)
                            },
                            new Trade()
                            {
                                Id = 14,
                                SellingCurrency = 73,
                                BuyingCurrency = 46,
                                SoldAmount = 55000000.00M,
                                PurchasedAmount = 486212.50M,
                                BrokerRate = 115.95M,
                                ProfitInBuyingCurrency = 11858.84M,
                                ProfitInGBP = 10351.93M,
                                ClientName = "KavaMax GRX",
                                DealDate = new DateTime(2020, 04, 30, 11, 26, 34)
                            },
                            new Trade()
                            {
                                Id = 15,
                                SellingCurrency = 26,
                                BuyingCurrency = 46,
                                SoldAmount = 320700.00M,
                                PurchasedAmount = 218020.98M,
                                BrokerRate = 1.51M,
                                ProfitInBuyingCurrency = 5317.58M,
                                ProfitInGBP = 4617.85M,
                                ClientName = "OakNest Village",
                                DealDate = new DateTime(2020, 04, 30, 14, 11, 05)
                            }
                );
            #endregion

            modelBuilder.Entity<DailyProfit>()
                .HasKey(e => e.Id);

            //Seeding Daily Profit data, new entries will be calculated and iserted onece a day by cron job.
            modelBuilder.Entity<DailyProfit>()
                .HasData(
                            new DailyProfit() { Id = 1, ProfitInGBP = 1012.08M, DealDay = new DateTime(2020, 04, 17) },
                            new DailyProfit() { Id = 2, ProfitInGBP = 32.65M, DealDay = new DateTime(2020, 04, 18) },
                            new DailyProfit() { Id = 3, ProfitInGBP = 53.10M, DealDay = new DateTime(2020, 04, 19) },
                            new DailyProfit() { Id = 4, ProfitInGBP = 2359.94M, DealDay = new DateTime(2020, 04, 20) },
                            new DailyProfit() { Id = 5, ProfitInGBP = 2458.45M, DealDay = new DateTime(2020, 04, 21) },
                            new DailyProfit() { Id = 6, ProfitInGBP = 485.13M, DealDay = new DateTime(2020, 04, 22) },
                            new DailyProfit() { Id = 7, ProfitInGBP = 531.00M, DealDay = new DateTime(2020, 04, 23) },
                            new DailyProfit() { Id = 8, ProfitInGBP = 9833.80M, DealDay = new DateTime(2020, 04, 24) },
                            new DailyProfit() { Id = 9, ProfitInGBP = 765.00M, DealDay = new DateTime(2020, 04, 25) },
                            new DailyProfit() { Id = 10, ProfitInGBP = 3288.65M, DealDay = new DateTime(2020, 04, 29) }
                );
        }
    }
}
