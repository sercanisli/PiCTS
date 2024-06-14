using Microsoft.EntityFrameworkCore;
using PiCTS.Entities.Models;
using PiCTS.Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Repositories.EntityFrameworkCore
{
    public class SearchCountsRepository : RepositoryBase<SearchCounts>, ISearchCountsRepository
    {
        public SearchCountsRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneSearchCount(SearchCounts searchCounts) => Create(searchCounts);

        public void DeleteOneSearchCount(SearchCounts searchCounts) => Delete(searchCounts);

        public async Task<IEnumerable<SearchCounts>> GetAllSearchCounts(bool trackChanges) =>
            await FindAll(trackChanges)
                .ToListAsync();

        public async Task<SearchCounts> GetOneSearchCountAsync(int id, bool trackChanges) =>
            await FindByCondition(sc => sc.Id == id, trackChanges)
                .SingleOrDefaultAsync();

        public void UpdateOneSearchCount(SearchCounts searchCounts) => Update(searchCounts);
    }
}
