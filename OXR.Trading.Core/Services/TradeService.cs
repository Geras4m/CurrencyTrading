using OXR.Trading.Common.Mapper;
using OXR.Trading.Core.Dto;
using OXR.Trading.Core.Services.Interfaces;
using OXR.Trading.Data.Entities;
using OXR.Trading.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OXR.Trading.Core.Services
{
    public class TradeService : BaseService<TradeDto, Trade>, ITradeService
    {
        private readonly ITradeRepository _tradeRepository;
        public TradeService(ITradeRepository tradeRepository, IMyMapper mapper)
            : base(tradeRepository, mapper)
        {
            _tradeRepository = tradeRepository;
        }

        public IList<TradeDto> GetAllPaged(int page = 1, int size = 3)
            => _mapper.Map<IList<TradeDto>>(_tradeRepository.SelectAllPaged(page, size));

        public IList<TradeDto> GetTradesByDate(DateTime date)
            => _mapper.Map<IList<TradeDto>>(_tradeRepository.SelectTradesByDate(date));

        public TradeDto AddOnDate(TradeDto trade)
        {
            var entity = _tradeRepository.InsertOnDate(_mapper.Map<Trade>(trade));
            return _mapper.Map<TradeDto>(entity);
        }
    }
}
