using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.RoleDTOs.ResponseDTOs
{
    public record RoleResponseDTO
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string NormalizedName { get; init; }
        public string ConcurrencyStamp { get; init; }
        public string ParentKey { get; init; }
    }
}
