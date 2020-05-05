using System;
using System.Collections.Generic;
using System.Text;

namespace OXR.Trading.ApiFramework.Services.Interfaces
{
    public interface IOXRatesService<TModel>
        where TModel : class
    {
        TModel Get();
    }
}
