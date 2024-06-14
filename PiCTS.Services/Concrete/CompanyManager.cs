using AutoMapper;
using PiCTS.Entities.DataTransferObjects.CompanyDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.CompanyDTOs.ResponseDTOs;
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
    public class CompanyManager : ICompanyService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public CompanyManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<CompanyResponseDTO> CreateOneCompanyAsync(CompanyRegistrationDTO companyRegistrationDTO)
        {
            var company = _mapper.Map<Company>(companyRegistrationDTO);

            IsCompanyNull(company);

            await IsNameExist(company.CompanyName);

            company.CreatedDate = DateTime.Now;
            _repositoryManager.CompanyRepository.CreateOneCompany(company);

            var companiesWithDeleted = await _repositoryManager.CompanyRepository.GetAllCompaniesWithDeletedAsync(false);
            var companiesCount = companiesWithDeleted.Count();

            var branchMainRoot = new BranchMainRoot()
            {
                Key = companiesCount.ToString(),
                Label = companyRegistrationDTO.CompanyName,
                Checked = false,
                PartialChecked = false
            };

            _repositoryManager.BranchMainRootRepository.CreateOneBranchMainRoot(branchMainRoot);

            await _repositoryManager.SaveChanges();
            return _mapper.Map<CompanyResponseDTO>(company);
        }

        public async Task DeleteOneCompanyAsync(int id, bool trackChanges)
        {
            var entity = await _repositoryManager.CompanyRepository.GetOneCompanyByIdAsync(id, trackChanges);
            if(entity == null)
            {
                throw new CompanyNotFoundException(id);
            }
            entity.CreatedDate = entity.CreatedDate;
            entity.UpdatedDate = entity.UpdatedDate;
            entity.DeletedDate = DateTime.Now;
            entity.IsDeleted = true;
            _repositoryManager.CompanyRepository.UpdateOneCompany(entity);
            await _repositoryManager.SaveChanges();
        }

        public async Task<IEnumerable<CompanyResponseDTO>> GetAllCompaniesAsync(bool trackChanges)
        {
            var entities = await _repositoryManager.CompanyRepository.GetAllCompaniesAsync(trackChanges);
            return _mapper.Map<IEnumerable<CompanyResponseDTO>>(entities);
        }

        public async Task<IEnumerable<CompanyLimitedResponseDTO>> GetAllLimitedCompaniesAsync(bool trackChanges)
        {
            var entities = await _repositoryManager.CompanyRepository.GetAllCompaniesAsync(trackChanges);
            return _mapper.Map<IEnumerable<CompanyLimitedResponseDTO>>(entities);
        }

        public async Task<CompanyResponseDTO> GetOneCompanyByIdAsync(int id, bool trackChanges)
        {
            var entity = await _repositoryManager.CompanyRepository.GetOneCompanyByIdAsync(id, trackChanges);
            if(entity == null)
            {
                throw new CompanyNotFoundException(id);
            }
            return _mapper.Map<CompanyResponseDTO>(entity);
        }

        public async Task UpdateOneCompanyAsync(int id, CompanyUpdateDTO companyUpdateDTO, bool trackChanges)
        {
            var entity = await _repositoryManager.CompanyRepository.GetOneCompanyByIdAsync(id, trackChanges);
            if (entity == null)
            {
                throw new CompanyNotFoundException(id);
            }

            var company = _mapper.Map<Company>(companyUpdateDTO);

            IsCompanyNull(company);

            //await IsNameExist(company.Name);

            company.CreatedDate = entity.CreatedDate;
            company.UpdatedDate = DateTime.Now;

            _repositoryManager.CompanyRepository.UpdateOneCompany(company);

            await _repositoryManager.SaveChanges();
        }

        private async Task IsNameExist(string companyName)
        {
            var entities = await GetAllCompaniesAsync(false);

            foreach (var entity in entities)
            {
                if (entity.CompanyName == companyName)
                {
                    throw new Exception("Company must be uniq");
                }
            }
        }

        private void IsCompanyNull(Company company)
        {
            if (company.CompanyName == null)
            {
                throw new ArgumentNullException(nameof(company));
            }
        }
    }
}
