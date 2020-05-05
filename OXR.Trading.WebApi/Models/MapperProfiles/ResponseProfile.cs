using AutoMapper;
using OXR.Trading.Common.Enum;
using OXR.Trading.Core.Dto;
using OXR.Trading.Common.Extensions;
using OXR.Trading.WebApi.Models.RequestModels;
using System;
using System.Linq.Expressions;

namespace OXR.Trading.WebApi.Models.MapperProfiles
{
    public class ResponseProfile : Profile
    {
        public ResponseProfile()
        {
            //Dto to Response mappings
            CreateMap<TradeDto, TradeResponse>()
                .ForMember(dest => dest.SellingCurrency, props => props.MapFrom(src =>
                            src.SellingCurrency.ToString()))
                .ForMember(dest => dest.BuyingCurrency, props => props.MapFrom(src =>
                            src.BuyingCurrency.ToString()));

            CreateMap<DailyProfitDto, DailyProfitResponse>().ReverseMap();

            //Response to Dto mappings
            CreateMap<TradeResponse, TradeDto>()
                .ForMember(dest => dest.SellingCurrency, props => props.MapFrom(src =>
                            src.SellingCurrency.ToEnum<Currency>(true)))
                .ForMember(dest => dest.BuyingCurrency, props => props.MapFrom(src =>
                            src.BuyingCurrency.ToEnum<Currency>(true)));

            CreateMap<Expression<Func<TradeDto, bool>>, Expression<Func<TradeResponse, bool>>>()
                .ReverseMap();

            //Request model mappings
            CreateMap<TradeDto, TradeModel>()
                .ForMember(dest => dest.SellingCurrency, props => props.MapFrom(src =>
                            src.SellingCurrency.ToString()))
                .ForMember(dest => dest.BuyingCurrency, props => props.MapFrom(src =>
                            src.BuyingCurrency.ToString()));

            CreateMap<TradeModel, TradeDto>()
                .ForMember(dest => dest.SellingCurrency, props => props.MapFrom(src =>
                            src.SellingCurrency.ToEnum<Currency>(true)))
                .ForMember(dest => dest.BuyingCurrency, props => props.MapFrom(src =>
                            src.BuyingCurrency.ToEnum<Currency>(true)));
        }
    }
}
