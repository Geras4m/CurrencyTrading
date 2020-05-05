using AutoMapper;
using OXR.Trading.Core.Dto;
using OXR.Trading.Data.Entities;
using System;
using OXR.Trading.ApiFramework.Models;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace OXR.TradingApp.Core.Dto.MapperProfiles
{
    public class CoreModelProfile : Profile
    {
        public CoreModelProfile()
        {
            CreateMap<Trade, TradeDto>()
                .ReverseMap();

            CreateMap<DailyProfit, DailyProfitDto>()
                .ReverseMap();

            CreateMap<LatestRatesDto, LatestRates>()
                .ReverseMap();


            CreateMap<IQueryable<DailyProfit>, IQueryable<DailyProfitDto>>()
                .ReverseMap();

            CreateMap<Expression<Func<TradeDto, bool>>, Expression<Func<Trade, bool>>>()
                .ReverseMap();

            CreateMap<Expression<Func<DailyProfitDto, bool>>, Expression<Func<DailyProfit, bool>>>()
                .ReverseMap();
        }
    }
}
