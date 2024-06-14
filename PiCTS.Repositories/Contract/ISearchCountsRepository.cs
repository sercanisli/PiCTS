using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Repositories.Contract
{
    public interface ISearchCountsRepository : IRepositoryBase<SearchCounts>
    {
        Task<IEnumerable<SearchCounts>> GetAllSearchCounts(bool trackChanges);
        Task<SearchCounts> GetOneSearchCountAsync(int id, bool trackChanges);
        void CreateOneSearchCount(SearchCounts searchCounts);
        void UpdateOneSearchCount(SearchCounts searchCounts);
        void DeleteOneSearchCount(SearchCounts searchCounts);
    }
}
