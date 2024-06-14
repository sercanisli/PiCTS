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
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(RepositoryContext context) : base(context)
        {
        }


        public void CreateOnePerson(Person person) => Create(person);

        public void DeleteOnePerson(Person person) => Delete(person);

        public async Task<IEnumerable<Person>> GetAllPersonsAsync(bool trackChanges) =>
            await FindAll(trackChanges)
                .Include(p => p.Branch)
                .Where(p => p.IsDeleted != true)
                .ToListAsync();

        public async Task<Person> GetOnePersonByIdAsync(int id, bool trackChanges) =>
            await FindByCondition(p => p.Id == id && p.IsDeleted != true, trackChanges)
                .Include(p => p.Branch)
                .SingleOrDefaultAsync();

        public void UpdateOnePerson(Person person) => Update(person);
    }
}
