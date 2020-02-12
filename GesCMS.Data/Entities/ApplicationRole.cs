using System;
using Microsoft.AspNetCore.Identity;

namespace GesCMS.Data.Entities
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public string RoleDescription { get; set; }
    }
}
