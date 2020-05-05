using AutoMapper;

namespace OXR.Trading.Common.Mapper
{
    public class MyMapper : IMyMapper
    {
        private readonly IMapper _mapper;
        public MyMapper(IMapper mapper)
            => _mapper = mapper;

        public TDestination Map<TDestination>(object source)
            => _mapper.Map<TDestination>(source);

        public TDestination Map<TSource, TDestination>(TSource source)
            => _mapper.Map<TSource, TDestination>(source);
    }
}
