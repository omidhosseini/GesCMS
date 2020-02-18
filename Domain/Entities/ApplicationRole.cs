using Microsoft.AspNetCore.Identity;
using System;

namespace Domain.Entities
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public string RoleDescription { get; set; }
    }
}
