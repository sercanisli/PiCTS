using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Repositories.Contract
{
    public interface IPersonRepository : IRepositoryBase<Person>
    {
        Task<IEnumerable<Person>> GetAllPersonsAsync(bool trackChanges);
        Task<Person> GetOnePersonByIdAsync(int id, bool trackChanges);
        void CreateOnePerson(Person person);
        void UpdateOnePerson(Person person);
        void DeleteOnePerson(Person person);
    }
}
