using AutoMapper;
using PiCTS.Entities.DataTransferObjects.ChildRootDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.ChildRootDTOs.ResponseDTOs;
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
    public class ChildRootManager : IChildRootService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public ChildRootManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<ChildRootResponseDTO> CreateOneChildRootAsync(ChildRootRegistrationDTO childRootRegistrationDTO)
        {
            var childRoot = _mapper.Map<ChildRoot>(childRootRegistrationDTO);

            IsChildRootNull(childRoot);

            childRoot.CreatedDate = DateTime.Now;
            _repositoryManager.ChildRootRepository.CreateOneChildRoot(childRoot);
            await _repositoryManager.SaveChanges();
            return _mapper.Map<ChildRootResponseDTO>(childRoot);
        }

        public async Task DeleteOneChildRootAsync(int id, bool trackChanges)
        {
            var childRoot = await _repositoryManager.ChildRootRepository.GetOneChildRootByIdAsync(id, trackChanges);
            if(childRoot == null)
            {
                throw new ChildRootNotFoundException(id);
            }

            childRoot.CreatedDate = childRoot.CreatedDate;
            childRoot.UpdatedDate = childRoot.UpdatedDate;
            childRoot.DeletedDate = DateTime.Now;
            childRoot.IsDeleted = true;

            _repositoryManager.ChildRootRepository.UpdateOneChildRoot(childRoot);
            await _repositoryManager.SaveChanges();
        }

        public async Task<IEnumerable<ChildRootResponseDTO>> GetAllChildRootsAsync(bool trackChanges)
        {
            var entities = await _repositoryManager.ChildRootRepository.GetAllChildRootsAsync(trackChanges);
            return _mapper.Map<IEnumerable<ChildRootResponseDTO>>(entities);
        }

        public async Task<ChildRootResponseDTO> GetOneChildRootByIdAsync(int id, bool trackChanges)
        {
            var childRoot = await _repositoryManager.ChildRootRepository.GetOneChildRootByIdAsync(id, trackChanges);
            if(childRoot == null)
            {
                throw new ChildRootNotFoundException(id);
            }
            return _mapper.Map<ChildRootResponseDTO>(childRoot);
        }

        public async Task UpdateOneChildRootAsync(int id, ChildRootUpdateDTO childRootUpdateDTO, bool trackChanges)
        {
            var entity = await _repositoryManager.ChildRootRepository.GetOneChildRootByIdAsync(id, trackChanges);
            if(entity == null)
            {
                throw new ChildRootNotFoundException(id);
            }

            var childRoot = _mapper.Map<ChildRoot>(childRootUpdateDTO);

            IsChildRootNull(childRoot);

            childRoot.CreatedDate = entity.CreatedDate;
            childRoot.DeletedDate = entity.DeletedDate;
            childRoot.UpdatedDate = DateTime.Now;

            _repositoryManager.ChildRootRepository.UpdateOneChildRoot(childRoot);
            await _repositoryManager.SaveChanges();
        }

        private void IsChildRootNull(ChildRoot childRoot)
        {
            if(childRoot.Label == null && childRoot.Key == null)
            {
                throw new ArgumentNullException(nameof(childRoot));
            }
        }
    }
}
