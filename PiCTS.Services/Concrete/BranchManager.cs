using AutoMapper;
using PiCTS.Entities.DataTransferObjects;
using PiCTS.Entities.DataTransferObjects.BranchDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.BranchDTOs.ResponseDTOs;
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
    public class BranchManager : IBranchService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public BranchManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<BranchResponseDTO> CreateOneBranchAsync(BranchForRegistrationDTO branchForRegistrationDTO)
        {
            var branch = _mapper.Map<Branch>(branchForRegistrationDTO);

            IsBranchNull(branch);

            branch.CreatedDate = DateTime.Now;
            _repositoryManager.BranchRepository.CreateOneBranch(branch);

            var branchesWithDeleted = await _repositoryManager.BranchRepository.GetAllBranchesWithDeletedAsycn(branchForRegistrationDTO.CompanyId ,false);
            var branchesCount = branchesWithDeleted.Count();

            var branchChildRoot = new BranchChildRoot()
            {
                BranchMainRootId = branchForRegistrationDTO.CompanyId,
                Key = $"{branchForRegistrationDTO.CompanyId - 1}-{branchesCount}",
                Label = branchForRegistrationDTO.BranchName,
                Checked = false,
                PartialChecked = false
            };

            _repositoryManager.BranchChildRootRepository.CreateOneBranchChildRoot(branchChildRoot);

            await _repositoryManager.SaveChanges();
            return _mapper.Map<BranchResponseDTO>(branch);
        }

        public async Task DeleteOneBranchAsync(int id, bool trackChanges)
        {
            var entity = await _repositoryManager.BranchRepository.GetOneBranchByIdAsync(id, trackChanges);
            if(entity == null)
            {
                throw new BranchNotFoundException(id);
            }
            entity.CreatedDate = entity.CreatedDate;
            entity.UpdatedDate = entity.UpdatedDate;
            entity.DeletedDate = DateTime.Now;
            entity.IsDeleted = true;
            _repositoryManager.BranchRepository.UpdateOneBranch(entity);
            await _repositoryManager.SaveChanges();
        }

        public async Task<IEnumerable<BranchResponseDTO>> GetAllBranchesAsync(string userName, bool trackChanges)
        {
            var entities = await _repositoryManager.BranchRepository.GetAllBranchesAsync(trackChanges);
            //var returnedEntities = entities.Select();
            return _mapper.Map<IEnumerable<BranchResponseDTO>>(entities);
        }

        public async Task<IEnumerable<BranchLimitedResponseDTO>> GetAllLimitedBranchesAsync(bool trackChanges)
        {
            var entities = await _repositoryManager.BranchRepository.GetAllLimitedBranchesAsync(trackChanges);
            return _mapper.Map<IEnumerable<BranchLimitedResponseDTO>>(entities);
        }

        public async Task<BranchResponseDTO> GetOneBranchByIdAsync(int id, bool trackChanges)
        {
            var entity = await _repositoryManager.BranchRepository.GetOneBranchByIdAsync(id, trackChanges);
            if(entity == null)
            {
                throw new BranchNotFoundException(id);
            }
            return _mapper.Map<BranchResponseDTO>(entity);
        }

        public async Task UpdateOneBranchAsync(int id, BranchUpdateDTO branchUpdateDTO, bool trackChanges)
        {
            var entity = await _repositoryManager.BranchRepository.GetOneBranchByIdAsync(id, trackChanges);
            if(entity == null)
            {
                throw new BranchNotFoundException(id);
            }

            var branch = _mapper.Map<Branch>(branchUpdateDTO);

            IsBranchNull(branch);

            branch.CreatedDate = entity.CreatedDate;
            branch.UpdatedDate = DateTime.Now;

            _repositoryManager.BranchRepository.UpdateOneBranch(branch);

            await _repositoryManager.SaveChanges();
        }

        private void IsBranchNull(Branch branch)
        {
            if(branch.BranchName == null || branch.Description == null)
            {
                throw new ArgumentNullException(nameof(branch));
            }
        }
    }
}
