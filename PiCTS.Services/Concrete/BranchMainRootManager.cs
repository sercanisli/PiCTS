using AutoMapper;
using PiCTS.Entities.DataTransferObjects.BranchMainRootDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.BranchMainRootDTOs.ResponseDTOs;
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
    public class BranchMainRootManager : IBranchMainRootService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public BranchMainRootManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<BranchMainRootResponseDTO> CreateOneBranchMainRootAsync(BranchMainRootRegistrationDTO branchMainRootRegistrationDTO)
        {
            var branchMainRoot = _mapper.Map<BranchMainRoot>(branchMainRootRegistrationDTO);

            IsBranchMainRootNull(branchMainRoot);

            branchMainRoot.CreatedDate = DateTime.Now;
            _repositoryManager.BranchMainRootRepository.CreateOneBranchMainRoot(branchMainRoot);
            await _repositoryManager.SaveChanges();
            return _mapper.Map<BranchMainRootResponseDTO>(branchMainRoot);
        }

        public async Task DeleteOneBranchMainRootAsync(int id, bool trackChanges)
        {
            var branchMainRoot = await _repositoryManager.BranchMainRootRepository.GetOneBranchMainRootByIdAsync(id, trackChanges);
            if(branchMainRoot == null)
            {
                throw new BranchMainRootNotFoundException(id);
            }

            branchMainRoot.CreatedDate = branchMainRoot.CreatedDate;
            branchMainRoot.UpdatedDate = branchMainRoot.UpdatedDate;
            branchMainRoot.DeletedDate = DateTime.Now;
            branchMainRoot.IsDeleted = true;

            _repositoryManager.BranchMainRootRepository.UpdateOneBranchMainRoot(branchMainRoot);
            await _repositoryManager.SaveChanges();
        }

        public async Task<IEnumerable<BranchMainRootResponseDTO>> GetAllBranchMainRootAsync(bool trackChanges)
        {
            var entities = await _repositoryManager.BranchMainRootRepository.GetAllMainRootsAsync(trackChanges);
            return _mapper.Map<IEnumerable<BranchMainRootResponseDTO>>(entities);
        }

        public async Task<BranchMainRootResponseDTO> GetOneBranchMainRootByIdAsync(int id, bool trackChanges)
        {
            var branchMainRoot = await _repositoryManager.BranchMainRootRepository.GetOneBranchMainRootByIdAsync(id, trackChanges);
            if(branchMainRoot == null)
            {
                throw new BranchMainRootNotFoundException(id);
            }
            return _mapper.Map<BranchMainRootResponseDTO>(branchMainRoot);
        }

        public async Task UpdateOneBranchMainRootAsync(int id, BranchMainRootUpdateDTO branchMainRootUpdateDTO, bool trackChanges)
        {
            var entity = await _repositoryManager.BranchMainRootRepository.GetOneBranchMainRootByIdAsync(id, trackChanges);
            if(entity == null)
            {
                throw new BranchMainRootNotFoundException(id);
            }

            var branchMainRoot = _mapper.Map<BranchMainRoot>(branchMainRootUpdateDTO);

            IsBranchMainRootNull(branchMainRoot);

            branchMainRoot.CreatedDate = entity.CreatedDate;
            branchMainRoot.DeletedDate = entity.DeletedDate;
            branchMainRoot.UpdatedDate = DateTime.Now;

            _repositoryManager.BranchMainRootRepository.UpdateOneBranchMainRoot(branchMainRoot);
            await _repositoryManager.SaveChanges();
        }

        private void IsBranchMainRootNull(BranchMainRoot branchMainRoot)
        {
            if (branchMainRoot.Label == null || branchMainRoot.Key == null)
            {
                throw new ArgumentNullException(nameof(branchMainRoot));
            }
        }
    }
}
