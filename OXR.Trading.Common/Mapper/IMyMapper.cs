using System;
using System.Collections.Generic;
using System.Text;

namespace OXR.Trading.Common.Mapper
{
    public interface IMyMapper
    {
        TDestination Map<TDestination>(object source);
        TDestination Map<TSource, TDestination>(TSource source);
    }
}
