using OXR.Trading.Common.Mapper;
using OXR.Trading.Core.Dto;
using OXR.Trading.Core.Services.Interfaces;
using OXR.Trading.Data.Entities;
using OXR.Trading.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OXR.Trading.Core.Services
{
    public class ProfitService : BaseService<DailyProfitDto, DailyProfit>, IProfitService
    {
        private readonly IProfitRepository _profitRepository;
        public ProfitService(IProfitRepository profitRepository, IMyMapper mapper)
            : base(profitRepository, mapper)
        {
            _profitRepository = profitRepository;
        }

        public IList<DailyProfitDto> GetByDate(DateTime startDate, DateTime endDate)
            => _mapper.Map<IList<DailyProfitDto>>(_profitRepository.SelectByDate(startDate, endDate));
    }
}
