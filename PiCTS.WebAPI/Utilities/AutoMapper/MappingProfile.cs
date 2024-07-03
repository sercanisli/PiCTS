using AutoMapper;
using PiCTS.Entities.DataTransferObjects.AuthenticationDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.BranchChildRootDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.BranchChildRootDTOs.ResponseDTOs;
using PiCTS.Entities.DataTransferObjects.BranchDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.BranchDTOs.ResponseDTOs;
using PiCTS.Entities.DataTransferObjects.BranchMainRootDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.BranchMainRootDTOs.ResponseDTOs;
using PiCTS.Entities.DataTransferObjects.ChildRootDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.ChildRootDTOs.ResponseDTOs;
using PiCTS.Entities.DataTransferObjects.CompanyDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.CompanyDTOs.ResponseDTOs;
using PiCTS.Entities.DataTransferObjects.ConnectionDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.ConnectionDTOs.ResponseDTOs;
using PiCTS.Entities.DataTransferObjects.ConnectionTypeDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.ConnectionTypeDTOs.ResponseDTOs;
using PiCTS.Entities.DataTransferObjects.MainRootDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.MainRootDTOs.ResponseDTOs;
using PiCTS.Entities.DataTransferObjects.PersonDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.PersonDTOs.ResponseDTOs;
using PiCTS.Entities.DataTransferObjects.ProjectDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.ProjectDTOs.ResponseDTOs;
using PiCTS.Entities.DataTransferObjects.RoleDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.RoleDTOs.ResponseDTOs;
using PiCTS.Entities.DataTransferObjects.SearchCountofCompaniesDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.SearchCountofCompaniesDTOs.ResponseDTOs;
using PiCTS.Entities.DataTransferObjects.SearchCountsDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.SearchCountsDTOs.ResponseDTOs;
using PiCTS.Entities.DataTransferObjects.TasksDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.TasksDTOs.ResponseDTOs;
using PiCTS.Entities.DataTransferObjects.TaskUsersDTOs.ResponseDTOs;
using PiCTS.Entities.DataTransferObjects.UserBranchesDTOs.ResponseDTOs;
using PiCTS.Entities.DataTransferObjects.UserDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.UserDTOs.ResponseDTOs;
using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PiCTS.WebAPI.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyRegistrationDTO>().ReverseMap();
            CreateMap<Company, CompanyUpdateDTO>().ReverseMap();
            CreateMap<Company, CompanyResponseDTO>().ReverseMap();
            CreateMap<Company, CompanyLimitedResponseDTO>().ReverseMap();

            CreateMap<Branch, BranchForRegistrationDTO>().ReverseMap();
            CreateMap<Branch, BranchUpdateDTO>().ReverseMap();
            CreateMap<Branch, BranchResponseDTO>().ReverseMap();
            CreateMap<Branch, BranchLimitedResponseDTO>().ReverseMap();

            CreateMap<Connection, ConnectionRegistrationDTO>().ReverseMap();
            CreateMap<Connection, ConnectionUpdateDTO>().ReverseMap();
            CreateMap<Connection, ConnectionResponseDTO>().ReverseMap();
            CreateMap<Connection, ConnectionsByBranchIdResponseDTO>().ReverseMap();

            CreateMap<ConnectionType, ConnectionTypeRegistrationDTO>().ReverseMap();
            CreateMap<ConnectionType, ConnectionTypeUpdateDTO>().ReverseMap();
            CreateMap<ConnectionType, ConnectionTypeResponseDTO>().ReverseMap();
            CreateMap<ConnectionType, ConnectionTypeLimitedResponseDTO>().ReverseMap();

            CreateMap<Person, PersonRegistrationDTO>().ReverseMap();
            CreateMap<Person, PersonUpdateDTO>().ReverseMap();
            CreateMap<Person, PersonResponseDTO>().ReverseMap();
            CreateMap<Person, PersonForConnectionResponseDTO>().ReverseMap();

            CreateMap<User, UserRegistrationDTO>().ReverseMap();
            CreateMap<User, UserUpdateDTO>().ReverseMap();
            CreateMap<User, UserForAuthenticationDTO>().ReverseMap();
            CreateMap<User, UserForRegistrationDTO>().ReverseMap();
            CreateMap<User, UserResponseDTO>().ReverseMap();
            CreateMap<User, UserNameDTO>().ReverseMap();
            CreateMap<User, UserSeettingsResponseDTO>().ReverseMap();
            CreateMap<User, UserStatusUpdateDTO>().ReverseMap();

            CreateMap<RoleRegistrationDTO, Role>().ReverseMap();
            CreateMap<Role, RoleUpdateDTO>().ReverseMap();
            CreateMap<Role, RoleResponseDTO>().ReverseMap();

            CreateMap<MainRoot, MainRootRegistrationDTO>().ReverseMap();
            CreateMap<MainRoot, MainRootUpdateDTO>().ReverseMap();
            CreateMap<MainRoot, MainRootResponseDTO>().ReverseMap();

            CreateMap<BranchMainRoot, BranchMainRootRegistrationDTO>().ReverseMap();
            CreateMap<BranchMainRoot, BranchMainRootUpdateDTO>().ReverseMap();
            CreateMap<BranchMainRoot, BranchMainRootResponseDTO>().ReverseMap();

            CreateMap<ChildRoot, ChildRootRegistrationDTO>().ReverseMap();
            CreateMap<ChildRoot, ChildRootUpdateDTO>().ReverseMap();
            CreateMap<ChildRoot, ChildRootResponseDTO>().ReverseMap();

            CreateMap<BranchChildRoot, BranchChildRootRegistrationDTO>().ReverseMap();
            CreateMap<BranchChildRoot, BranchChildRootUpdateDTO>().ReverseMap();
            CreateMap<BranchChildRoot, BranchChildRootResponseDTO>().ReverseMap();

            CreateMap<UserBranches, UserBranchesResponseDTO>().ReverseMap();

            CreateMap<SearchCounts, SearchCountRegistrationDTO>().ReverseMap();
            CreateMap<SearchCounts, SearchCountUpdateDTO>().ReverseMap();
            CreateMap<SearchCounts, SearchCountResponseDTO>().ReverseMap();

            CreateMap<SearchCountofCompanies, SearchCountofCompaniesRegistrationDTO>().ReverseMap();
            CreateMap<SearchCountofCompanies, SearchCountofCompaniesUpdateDTO>().ReverseMap();
            CreateMap<SearchCountofCompanies, SearchCountofCompaniesResponseDTO>().ReverseMap();

            CreateMap<Project, ProjectRegistrationDTO>().ReverseMap();
            CreateMap<Project, ProjectUpdateDTO>().ReverseMap();
            CreateMap<Project, ProjectResponseDTO>().ReverseMap();

            CreateMap<Tasks, TasksRegistrationDTO>().ReverseMap();
            CreateMap<Tasks, TasksUpdateDTO>().ReverseMap();
            CreateMap<Tasks, TasksResponseDTO>().ReverseMap();

            CreateMap<TaskUsers, TaskUsersResponseDTO>().ReverseMap();
        }
    }
}
