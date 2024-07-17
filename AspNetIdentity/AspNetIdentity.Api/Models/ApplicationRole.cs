﻿using Microsoft.AspNetCore.Identity;

namespace AspNetIdentity.Api.Models
{
    public class ApplicationRole : IdentityRole<int>
    {
        public ApplicationRole() : base() { }
        public ApplicationRole(string roleName) : base(roleName) { }
    }
}
