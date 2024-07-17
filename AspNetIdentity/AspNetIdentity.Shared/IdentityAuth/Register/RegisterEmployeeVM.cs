using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AspNetIdentity.Shared.IdentityAuth.Register
{
    public class RegisterEmployeeVM : RegisterViewModel
    {
        [JsonIgnore]
        public UserRole UserRole { get; set; } = UserRole.Member;
    }
}
