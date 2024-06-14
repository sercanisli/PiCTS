using PiCTS.Entities.DataTransferObjects.SearchCountsDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.SearchCountsDTOs.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Contract
{
    public interface ISearchCountsService
    {
        Task<IEnumerable<SearchCountResponseDTO>> GetAllSearchCountsAsync(bool trackChanges);
        Task<SearchCountResponseDTO> GetOneSearchCountAsync(int id, bool trackChanges);
        Task<SearchCountResponseDTO> CreateOneSearchCountAsync(SearchCountRegistrationDTO searchCountRegistrationDTO);
        Task UpdateOneSearchCountAsync(SearchCountUpdateDTO searchCountUpdateDTO, bool trackChanges);
        Task DeleteOneSearchCountAsync(int id, bool trackChanges);
    }
}
