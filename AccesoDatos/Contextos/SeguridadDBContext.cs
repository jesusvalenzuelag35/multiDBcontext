using AccesoDatos.IdentityEntidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Contextos
{
    public class SeguridadDBContext : IdentityDbContext<SeguridadIdentity>
    {

        public SeguridadDBContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=tallerdecelulares.mssql.somee.com;User ID=danielvalenzuela_SQLLogin_1;Password=3kce4gtf6c;Initial Catalog=tallerdecelulares;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }





    }
}
