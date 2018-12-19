using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ManageRest.Models;

namespace ManageRest.Data.Maps
{
    public class PerfilMap : IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> builder) 
        {
            builder.ToTable("Perfil");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome)
                   .IsRequired()
                   .HasMaxLength(100)
                   .HasColumnType("varchar(100)");
            builder.Property(x => x.Descricao)
                   .IsRequired()
                   .HasMaxLength(500)
                   .HasColumnType("varchar(500)");  
            builder.Property(x => x.DataCadastro)
                   .IsRequired();                                    
        }
    }
}