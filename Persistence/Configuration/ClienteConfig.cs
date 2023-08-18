﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configuration
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            
            builder.ToTable(nameof(Cliente));
            
            builder.HasKey(c => c.Id);
            
            builder.Property(p => p.Nombre)
                .HasMaxLength(80)
                .IsRequired();
            
            builder.Property(p => p.Apellido)
                .HasMaxLength(80)
                .IsRequired();
            
            builder.Property(p => p.FechaNacimiento)
              .IsRequired();
            
            builder.Property(p => p.Telefono)
              .HasMaxLength(10)
              .IsRequired();
            
            builder.Property(p => p.Email)
              .HasMaxLength(100)
              .IsRequired();
            
            builder.Property(p => p.Direccion)
              .HasMaxLength(120) 
              .IsRequired();
            
            builder.Property(p => p.Edad);

            builder.Property(p => p.CreateBy)
              .HasMaxLength(120);

            builder.Property(p => p.LastModifiedBy)
              .HasMaxLength(120);

        }
    }
}
