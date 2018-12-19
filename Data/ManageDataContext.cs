using Microsoft.EntityFrameworkCore;
using ManageRest.Data.Maps;
using ManageRest.Models;

namespace ManageRest.Data
{
    public class ManageDataContext : DbContext
    {
        public DbSet<Operador> Operadores {get;set;}
        public DbSet<Perfil> Perfis {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {            
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=manage;Trusted_Connection=True;");
        }
         protected override void OnModelCreating(ModelBuilder builder) 
         {
             builder.ApplyConfiguration(new OperadorMap());
             builder.ApplyConfiguration(new PerfilMap());
         }
    }
}