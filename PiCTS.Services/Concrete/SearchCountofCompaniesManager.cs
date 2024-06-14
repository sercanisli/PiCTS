using AutoMapper;
using PiCTS.Entities.DataTransferObjects.SearchCountofCompaniesDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.SearchCountofCompaniesDTOs.ResponseDTOs;
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
    public class SearchCountofCompaniesManager : ISearchCountofCompaniesService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public SearchCountofCompaniesManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<SearchCountofCompaniesResponseDTO> CreateOneSearchCountofCompanyAsync(SearchCountofCompaniesRegistrationDTO searchCountofCompaniesRegistrationDTO)
        {
            if(searchCountofCompaniesRegistrationDTO == null)
            {
                throw new ArgumentNullException(nameof(searchCountofCompaniesRegistrationDTO));
            }
            var searchCountofCompany = _mapper.Map<SearchCountofCompanies>(searchCountofCompaniesRegistrationDTO);
            _repositoryManager.SearchCountofCompaniesRepository.CreateOneSearchCountofCompany(searchCountofCompany);
            await _repositoryManager.SaveChanges();
            return _mapper.Map<SearchCountofCompaniesResponseDTO>(searchCountofCompany);
        }

        public async Task DeleteOneSearchCountofCompany(int id, bool trackChanges)
        {
            var searchCountofCompany = await _repositoryManager.SearchCountofCompaniesRepository.GetOneSearchCountofCompanyAsync(id, trackChanges);
            if(searchCountofCompany == null)
            {
                throw new SearchCountofCompaniesNotFoundException(id);
            }
            _repositoryManager.SearchCountofCompaniesRepository.DeleteOneSearchCountofCompnay(searchCountofCompany);
            await _repositoryManager.SaveChanges();
        }

        public async Task<IEnumerable<SearchCountofCompaniesResponseDTO>> GetAllSearchCountofCompaniesAsync(bool trackChanges)
        {
            var searchCountofCompanies = await _repositoryManager.SearchCountofCompaniesRepository.GetAllSearchCountofCompaniesAsync(trackChanges);
            return _mapper.Map<IEnumerable<SearchCountofCompaniesResponseDTO>>(searchCountofCompanies);
        }

        public async Task<SearchCountofCompaniesResponseDTO> GetOneSearchCountofcompanyAsync(int id, bool trackChanges)
        {
            var searchCountofCompany = await _repositoryManager.SearchCountofCompaniesRepository.GetOneSearchCountofCompanyAsync(id, trackChanges);
            if(searchCountofCompany == null)
            {
                throw new SearchCountofCompaniesNotFoundException(id);
            }
            return _mapper.Map<SearchCountofCompaniesResponseDTO>(searchCountofCompany);
        }

        public async Task UpdateOneSearchCountofCompany(SearchCountofCompaniesUpdateDTO searchCountofCompaniesUpdateDTO, bool trackChanges)
        {
            bool match = false;
            var searchCountofCompanies = await _repositoryManager.SearchCountofCompaniesRepository.GetAllSearchCountofCompaniesAsync(false);
            if(searchCountofCompanies.Count() > 0)
            {
                foreach (var scoc in searchCountofCompanies)
                {
                    if(scoc.CompanyId == searchCountofCompaniesUpdateDTO.CompanyId)
                    {
                        scoc.Count = scoc.Count + searchCountofCompaniesUpdateDTO.Count;
                        match = true;
                        _repositoryManager.SearchCountofCompaniesRepository.UpdateOneSearchCountofCompany(scoc);
                        await _repositoryManager.SaveChanges();
                        break;
                    }
                }
            }

            if (!match || searchCountofCompanies.Count() == 0)
            {
                var searchCountofCompany = new SearchCountofCompanies()
                {
                    CompanyId = searchCountofCompaniesUpdateDTO.CompanyId,
                    Count = searchCountofCompaniesUpdateDTO.Count
                };

                _repositoryManager.SearchCountofCompaniesRepository.CreateOneSearchCountofCompany(searchCountofCompany);
                await _repositoryManager.SaveChanges();
            }
        }
    }
}
