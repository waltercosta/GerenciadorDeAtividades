using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteLucas.Models.EntityModel.Tasks
{
    public static class TaskMap
    {
        public static void Configure (this EntityTypeBuilder<Task> entity)
        {
            entity.ToTable("Tarefas");

            entity.HasKey(p => p.IdTask);

            #region Properties

            entity.Property(p => p.IdTask).ValueGeneratedOnAdd();

            entity.Property(p=>p.Name)
                  .HasColumnName("NomeTarefa")
                  .HasMaxLength(255)
                  .IsRequired();

            entity.Property(p => p.Description)
                  .HasColumnName("Descricao")
                  .HasMaxLength(800);

            entity.Property(p => p.Type)
                  .HasColumnName("Tipo")
                  .IsRequired();

            entity.Property(p => p.DateBegin)
                  .HasColumnName("DataInicio")
                  .IsRequired();

            entity.Property(p => p.DateEnd)
                  .HasColumnName("DataFim");
            #endregion
        }
    }
}
