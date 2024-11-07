using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.IdentityEntidades
{
    public class SeguridadIdentity : IdentityUser
    {
        [StringLength(200)]
        public String NombreCompleto { get; set; } = default!;
        [StringLength(200)]
        public String? Rol { get; set; }
        public int? IdUsuario { get; set; }
        public int? EmailSecurityCode { get; set; }
    }
}
