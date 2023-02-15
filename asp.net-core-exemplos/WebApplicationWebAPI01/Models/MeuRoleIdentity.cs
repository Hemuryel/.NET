using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationWebAPI01.Models
{
    public class MeuRoleIdentity : IdentityRole
    {
        public string Descricao { get; set; }
    }
}
