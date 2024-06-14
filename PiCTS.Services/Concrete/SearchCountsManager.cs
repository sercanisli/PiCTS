using AutoMapper;
using PiCTS.Entities.DataTransferObjects.SearchCountsDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.SearchCountsDTOs.ResponseDTOs;
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
    public class SearchCountsManager : ISearchCountsService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public SearchCountsManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<SearchCountResponseDTO> CreateOneSearchCountAsync(SearchCountRegistrationDTO searchCountRegistrationDTO)
        {
            if(searchCountRegistrationDTO == null)
            {
                throw new ArgumentNullException(nameof(searchCountRegistrationDTO));
            }
            var searchCounts = _mapper.Map<SearchCounts>(searchCountRegistrationDTO);
            _repositoryManager.SearchCountsRepository.CreateOneSearchCount(searchCounts);
            await _repositoryManager.SaveChanges();
            return _mapper.Map<SearchCountResponseDTO>(searchCounts);
        }

        public async Task DeleteOneSearchCountAsync(int id, bool trackChanges)
        {
            var searchCount = await _repositoryManager.SearchCountsRepository.GetOneSearchCountAsync(id, false);
            if(searchCount == null)
            {
                throw new SearchCountNotFoundException(id);
            }
            _repositoryManager.SearchCountsRepository.DeleteOneSearchCount(searchCount);
           await _repositoryManager.SaveChanges();
        }

        public async Task<IEnumerable<SearchCountResponseDTO>> GetAllSearchCountsAsync(bool trackChanges)
        {
            var searchCounts = await _repositoryManager.SearchCountsRepository.GetAllSearchCounts(trackChanges);
            return _mapper.Map<IEnumerable<SearchCountResponseDTO>>(searchCounts);
        }

        public async Task<SearchCountResponseDTO> GetOneSearchCountAsync(int id, bool trackChanges)
        {
            var searchCount = await _repositoryManager.SearchCountsRepository.GetOneSearchCountAsync(id, trackChanges);
            if(searchCount == null)
            {
                throw new SearchCountNotFoundException(id);
            }
            return _mapper.Map<SearchCountResponseDTO>(searchCount);
        }

        public async Task UpdateOneSearchCountAsync(SearchCountUpdateDTO searchCountUpdateDTO, bool trackChanges)
        {
            bool match = false;
            var searchCounts = await _repositoryManager.SearchCountsRepository.GetAllSearchCounts(false);
            if(searchCounts.Count() > 0)
            {
                foreach (var sc in searchCounts)
                {
                    if (sc.DateofMonth == searchCountUpdateDTO.DateofMonth)
                    {
                        sc.Count = sc.Count + searchCountUpdateDTO.Count;
                        _repositoryManager.SearchCountsRepository.UpdateOneSearchCount(sc);
                        match = true;
                        await _repositoryManager.SaveChanges();
                        break;
                    }
                }
            }

            if (!match || searchCounts.Count() == 0)
            {
                var searchCount = new SearchCounts()
                {
                    Count = searchCountUpdateDTO.Count,
                    DateofMonth = searchCountUpdateDTO.DateofMonth
                };

                _repositoryManager.SearchCountsRepository.CreateOneSearchCount(searchCount);
                await _repositoryManager.SaveChanges();
            }
        }
    }
}
