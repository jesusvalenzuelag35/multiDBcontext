using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Contextos
{
    public class TalleresDBContext :DbContext
    {

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=tallerdecelulares.mssql.somee.com;User ID=danielvalenzuela_SQLLogin_1;Password=3kce4gtf6c;Initial Catalog=tallerdecelulares;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //configuracion para Owner
            modelBuilder.Entity<Owner>(entity =>
            {
                entity.HasKey(o => o.IdOwner).HasName("PK_id_owner").HasAnnotation("SqlServer:Identity","1,1");
                entity.ToTable("owner");
                entity.Property(o => o.IdOwner).HasColumnName("id_owner");
                
            });
            //configuracion para Company
            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(c => c.CompanyId).HasName("PK_Company_Id").HasAnnotation("SqlServer:Identity","1,1");
                entity.ToTable("company");

                //Llave foranea con Owner 
                entity.HasOne(c => c.OwnerNavigation).WithMany(c => c.Companys).HasForeignKey(c => c.IdOwner).HasConstraintName("FK_Owner_Id");

            });
            //configuracion para Employee
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId).HasName("PK_Employee_Id").HasAnnotation("SqlServer:Identity", "1,1");
                entity.ToTable("employee");

                entity.Property(e => e.Sueldo).HasColumnType("Decimal(6,2)");

                entity.HasOne(e => e.OwnerNavigation).WithMany(entity => entity.Employees).HasForeignKey(e => e.OwnerId).HasConstraintName("FK_Employee_ID");
                entity.HasOne(e => e.CompanyNavigation).WithMany(e => e.Employees).HasForeignKey(e => e.CompanyId).HasConstraintName("FK_Company_ID");

            });
        }
    }
}
