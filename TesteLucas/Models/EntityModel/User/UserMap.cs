using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteLucas.Models.EntityModel.Users
{
    public static class UserMap
    {
        public static void Configure (this EntityTypeBuilder<User> entity)
        {
            entity.ToTable("Usuarios");

            entity.HasKey(p => p.Id);

            #region Properties
            entity.Property(p => p.Id).ValueGeneratedOnAdd();

            entity.Property(p => p.Name)
                  .HasColumnName("Nome")
                  .HasMaxLength(255);
            #endregion

            entity.HasMany(p => p.TaskList)
                  .WithOne(p => p.User);
        }
    }
}
