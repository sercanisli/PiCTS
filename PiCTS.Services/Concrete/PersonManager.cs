using AutoMapper;
using PiCTS.Entities.DataTransferObjects;
using PiCTS.Entities.DataTransferObjects.PersonDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.PersonDTOs.ResponseDTOs;
using PiCTS.Entities.Exceptions;
using PiCTS.Entities.Models;
using PiCTS.Repositories.Contract;
using PiCTS.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Concrete
{
    public class PersonManager : IPersonService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public PersonManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<PersonResponseDTO> CreateOnePersonAsync(PersonRegistrationDTO personRegistrationDTO)
        {
            var person = _mapper.Map<Person>(personRegistrationDTO);

            IsPersonNull(person);

            person.CreatedDate = DateTime.Now;
            _repositoryManager.PersonRepository.CreateOnePerson(person);
            await _repositoryManager.SaveChanges();
            return _mapper.Map<PersonResponseDTO>(person);
        }

        public async Task DeleteOnePersonAsync(int id, bool trackChanges)
        {
            var entity = await _repositoryManager.PersonRepository.GetOnePersonByIdAsync(id, trackChanges);
            if(entity == null)
            {
                throw new PersonNotFoundException(id);
            }
            entity.CreatedDate = entity.CreatedDate;
            entity.UpdatedDate = entity.UpdatedDate;
            entity.DeletedDate = DateTime.Now;
            entity.IsDeleted = true;
            _repositoryManager.PersonRepository.UpdateOnePerson(entity);
            await _repositoryManager.SaveChanges();
        }

        public async Task<IEnumerable<PersonResponseDTO>> GetAllPersonsAsync(bool trackChanges)
        {
            var entities = await _repositoryManager.PersonRepository.GetAllPersonsAsync(trackChanges);
            return _mapper.Map<IEnumerable<PersonResponseDTO>>(entities);
        }

        public async Task<PersonResponseDTO> GetOnePersonByIdAsync(int id, bool trackChanges)
        {
            var entity = await _repositoryManager.PersonRepository.GetOnePersonByIdAsync(id, trackChanges);
            if(entity == null)
            {
                throw new PersonNotFoundException(id);
            }
            return _mapper.Map<PersonResponseDTO>(entity);
        }

        public async Task UpdateOnePersonAsync(int id, PersonUpdateDTO personUpdateDTO, bool trackChanges)
        {
            var entity = await _repositoryManager.PersonRepository.GetOnePersonByIdAsync(id, trackChanges);
            if(entity == null)
            {
                throw new PersonNotFoundException(id);
            }

            var person = _mapper.Map<Person>(personUpdateDTO);

            IsPersonNull(person);

            person.CreatedDate = entity.CreatedDate;
            person.UpdatedDate = DateTime.Now;

            _repositoryManager.PersonRepository.UpdateOnePerson(person);

            await _repositoryManager.SaveChanges();
        }

        private void IsPersonNull(Person person)
        {
            if(person.FullName == null)
            {
                throw new ArgumentNullException(nameof(person));
            }
        }
    }
}
