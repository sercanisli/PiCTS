using PiCTS.Entities.DataTransferObjects.PersonDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.PersonDTOs.ResponseDTOs;
using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Contract
{
    public interface IPersonService
    {
        Task<IEnumerable<PersonResponseDTO>> GetAllPersonsAsync(bool trackChanges);
        Task<PersonResponseDTO> GetOnePersonByIdAsync(int id, bool trackChanges);
        Task<PersonResponseDTO> CreateOnePersonAsync(PersonRegistrationDTO personRegistrationDTO);
        Task UpdateOnePersonAsync(int id, PersonUpdateDTO personUpdateDTO, bool trackChanges);
        Task DeleteOnePersonAsync(int id, bool trackChanges);
    }
}
