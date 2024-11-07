using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Owner
    {
        public int IdOwner { get; set; }
        [StringLength(200)]
        public string? Nombre { get; set; }
        [StringLength(200)]
        public string? Apellido { get; set; }
        [StringLength(10)]
        public string? Celular { get; set; }
        [StringLength(200)]
        public string? Correo { get; set; }
        public virtual ICollection<Company> Companys { get; set; } = new List<Company>();
        public virtual ICollection<Employee> Employees { get; set; }  = new List<Employee>();
    }
}
