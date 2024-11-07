using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Celular { get; set; }
        public string? Correo { get; set; }
        public decimal Sueldo { get; set; }
        public int Edad { get; set; }
        public int OwnerId { get; set; }
        public int CompanyId { get; set; }
        public virtual Owner OwnerNavigation { get; set; }
        public virtual Company CompanyNavigation { get; set; }    
    }
}
