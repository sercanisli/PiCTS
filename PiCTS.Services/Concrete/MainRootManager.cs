using AutoMapper;
using PiCTS.Entities.DataTransferObjects.MainRootDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.MainRootDTOs.ResponseDTOs;
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
    public class MainRootManager : IMainRootService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public MainRootManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<MainRootResponseDTO> CreateOneMainRootAsync(MainRootRegistrationDTO mainRootRegistrationDTO)
        {
            var mainRoot = _mapper.Map<MainRoot>(mainRootRegistrationDTO);

            IsMainRootNull(mainRoot);

            mainRoot.CreatedDate = DateTime.Now;
            _repositoryManager.MainRootRepository.CreateOneMainRoot(mainRoot);
            await _repositoryManager.SaveChanges();
            return _mapper.Map<MainRootResponseDTO>(mainRoot);
        }

        public async Task DeleteOneMainRootAsync(int id, bool trackChanges)
        {
            var mainRoot = await _repositoryManager.MainRootRepository.GetOneMainRootByIdAsync(id, trackChanges);
            if(mainRoot == null)
            {
                throw new MainRootNotFoundException(id);
            }

            mainRoot.CreatedDate = mainRoot.CreatedDate;
            mainRoot.UpdatedDate = mainRoot.UpdatedDate;
            mainRoot.DeletedDate = DateTime.Now;
            mainRoot.IsDeleted = true;

            _repositoryManager.MainRootRepository.UpdateOneMainRoot(mainRoot);
            await _repositoryManager.SaveChanges();
        }

        public async Task<IEnumerable<MainRootResponseDTO>> GetAllMainRootsAsync(bool trackChanges)
        {
            var entities = await _repositoryManager.MainRootRepository.GetAllMainRootsAsync(trackChanges);
            return _mapper.Map<IEnumerable<MainRootResponseDTO>>(entities);
        }

        public async Task<MainRootResponseDTO> GetOneMainRootByIdAsync(int id, bool trackChanges)
        {
            var mainRoot = await _repositoryManager.MainRootRepository.GetOneMainRootByIdAsync(id, trackChanges);
            if(mainRoot == null)
            {
                throw new MainRootNotFoundException(id);
            }
            return _mapper.Map<MainRootResponseDTO>(mainRoot);
        }

        public async Task UpdateOneMainRootAsync(int id, MainRootUpdateDTO mainRootUpdate, bool trackChanges)
        {
            var entity = await _repositoryManager.MainRootRepository.GetOneMainRootByIdAsync(id, trackChanges);
            if(entity == null)
            {
                throw new MainRootNotFoundException(id);
            }

            var mainRoot = _mapper.Map<MainRoot>(mainRootUpdate);

            IsMainRootNull(mainRoot);

            mainRoot.CreatedDate = entity.CreatedDate;
            mainRoot.DeletedDate = entity.DeletedDate;
            mainRoot.UpdatedDate = DateTime.Now;

            _repositoryManager.MainRootRepository.UpdateOneMainRoot(mainRoot);
            await _repositoryManager.SaveChanges();
        }

        private void IsMainRootNull(MainRoot mainRoot)
        {
            if(mainRoot.Label == null || mainRoot.Key == null)
            {
                throw new ArgumentNullException(nameof(mainRoot));
            }
        }
    }
}
