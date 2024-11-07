using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Company
    {
        public int CompanyId { get; set; }

        public string? RazonSocial { get; set; }

        public string? NombreComercial { get; set; }

        public string? NombreContacto { get; set; }

        public string? Celular { get; set; }

        public string? CorrreoElectronico { get; set; }

        public int? IdOwner { get; set; }

        public virtual Owner OwnerNavigation { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
