using OXR.Trading.Data.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace OXR.Trading.Data.Repositories.Interfaces
{
    public interface ITradeRepository : IBaseRepository<Trade>
    {
        IQueryable<Trade> SelectAllPaged(int page = 1, int size = 3);
        Trade InsertOnDate(Trade entity);
    }
}
