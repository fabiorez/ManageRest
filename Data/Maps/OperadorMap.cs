using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ManageRest.Models;

namespace ManageRest.Data.Maps
{
    public class OperadorMap : IEntityTypeConfiguration<Operador>
    {
        public void Configure(EntityTypeBuilder<Operador> builder) 
        {
            builder.ToTable("Operador");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome)
                   .IsRequired()
                   .HasMaxLength(100)
                   .HasColumnType("varchar(100)");
            builder.Property(x => x.Email)
                   .IsRequired()
                   .HasMaxLength(100)
                   .HasColumnType("varchar(100)");
            builder.Property(x => x.HashSenha)
                   .IsRequired()
                   .HasMaxLength(100)
                   .HasColumnType("varchar(100)"); 
            builder.Property(x => x.Fixo)
                   .HasMaxLength(20)
                   .HasColumnType("varchar(20)");    
            builder.Property(x => x.Celular)
                   .HasMaxLength(20)
                   .HasColumnType("varchar(20)");  
            builder.Property(x => x.Observacao)
                   .HasMaxLength(1000)
                   .HasColumnType("varchar(1000)");    
            builder.Property(x => x.Cpf)
                   .HasMaxLength(11)
                   .HasColumnType("varchar(11)");   
            builder.Property(x => x.DataCadastro)
                   .IsRequired();  
            builder.HasOne(x => x.Perfil)
                   .WithMany(x => x.Operadores);    
        }
    }
}