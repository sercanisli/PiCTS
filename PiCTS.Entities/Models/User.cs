using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Models
{
    public class User : IdentityUser
    {
        public String? FirstName  { get; set; }
        public String? LastName  { get; set; }
        public bool IsDeleted { get; set; }


        public String? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime DeletedDate { get; set; }


        public User()
        {
            IsDeleted = false;
        }
    }
}
