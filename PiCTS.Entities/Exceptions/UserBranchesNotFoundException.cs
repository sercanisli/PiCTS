using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Exceptions
{
    public sealed class UserBranchesNotFoundException : NotFoundException
    {
        public UserBranchesNotFoundException(string id) : base($"User Branches with User ID : {id} could not found")
        {
        }
    }
}
