using AutoMapper;
using PiCTS.Entities.DataTransferObjects.BranchChildRootDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.BranchChildRootDTOs.ResponseDTOs;
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
    public class BranchChildRootManager : IBranchChildRootService
    {
        private readonly IRepositoryManager _repositoyManager;
        private readonly IMapper _mapper;

        public BranchChildRootManager(IRepositoryManager repositoyManager, IMapper mapper)
        {
            _repositoyManager = repositoyManager;
            _mapper = mapper;
        }

        public async Task<BranchChildRootResponseDTO> CreateOneBranchChildRootAsync(BranchChildRootRegistrationDTO branchChildRootRegistrationDTO)
        {
            var branchChildRoot = _mapper.Map<BranchChildRoot>(branchChildRootRegistrationDTO);

            IsBranchChildRootNull(branchChildRoot);

            branchChildRoot.CreatedDate = DateTime.Now;
            _repositoyManager.BranchChildRootRepository.CreateOneBranchChildRoot(branchChildRoot);
            await _repositoyManager.SaveChanges();
            return _mapper.Map<BranchChildRootResponseDTO>(branchChildRoot);
        }

        public async Task DeleteOneBranchChildRootAsync(int id, bool trackChanges)
        {
            var branchChildRoot = await _repositoyManager.BranchChildRootRepository.GetOneBranchChildRootByIdAsync(id, trackChanges);
            if(branchChildRoot == null)
            {
                throw new BranchChildRootNotFoundException(id);
            }

            branchChildRoot.CreatedDate = branchChildRoot.CreatedDate;
            branchChildRoot.UpdatedDate = branchChildRoot.UpdatedDate;
            branchChildRoot.DeletedDate = DateTime.Now;
            branchChildRoot.IsDeleted = true;

            _repositoyManager.BranchChildRootRepository.UpdateOneBranchChildRoot(branchChildRoot);
            await _repositoyManager.SaveChanges();
        }

        public async Task<IEnumerable<BranchChildRootResponseDTO>> GetAllBranchChildRootAsync(bool trackChanges)
        {
            var entities = await _repositoyManager.BranchChildRootRepository.GetAllBranchChildRootAsync(trackChanges);
            return _mapper.Map<IEnumerable<BranchChildRootResponseDTO>>(entities);
        }

        public async Task<BranchChildRootResponseDTO> GetOneBranchChildRootByIdAsync(int id, bool trackChanges)
        {
            var branchChildRoot = await _repositoyManager.BranchChildRootRepository.GetOneBranchChildRootByIdAsync(id, trackChanges);
            if(branchChildRoot == null)
            {
                throw new BranchChildRootNotFoundException(id);
            }
            return _mapper.Map<BranchChildRootResponseDTO>(branchChildRoot);
        }

        public async Task UpdateOneBranchChildRootAsync(int id, BranchChildRootUpdateDTO branchChildRootUpdateDTO, bool trackChanges)
        {
            var entity = await _repositoyManager.BranchChildRootRepository.GetOneBranchChildRootByIdAsync(id, trackChanges);
            if(entity == null)
            {
                throw new BranchChildRootNotFoundException(id);
            }

            var branchChildRoot = _mapper.Map<BranchChildRoot>(branchChildRootUpdateDTO);

            IsBranchChildRootNull(branchChildRoot);

            branchChildRoot.CreatedDate = entity.CreatedDate;
            branchChildRoot.DeletedDate = entity.DeletedDate;
            branchChildRoot.UpdatedDate = DateTime.Now;

            _repositoyManager.BranchChildRootRepository.UpdateOneBranchChildRoot(branchChildRoot);
            await _repositoyManager.SaveChanges();
        }

        private void IsBranchChildRootNull(BranchChildRoot branchChildRoot)
        {
            if (branchChildRoot.Label == null && branchChildRoot.Key == null)
            {
                throw new ArgumentNullException(nameof(branchChildRoot));
            }
        }
    }
}
