﻿using OXR.Trading.Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OXR.Trading.Core.Services.Interfaces
{
    public interface IProfitService : IBaseService<DailyProfitDto>
    {
        IList<DailyProfitDto> GetByDate(DateTime startDate, DateTime endDate);
    }
}
