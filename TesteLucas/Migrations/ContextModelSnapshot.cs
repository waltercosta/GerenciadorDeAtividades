﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteLucas.Infrastructure.Context;

namespace TesteLucas.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TesteLucas.Models.EntityModel.Tasks.Task", b =>
                {
                    b.Property<int>("IdTask")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateBegin")
                        .IsRequired()
                        .HasColumnName("DataInicio");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnName("DataFim");

                    b.Property<string>("Description")
                        .HasColumnName("Descricao")
                        .HasMaxLength(800);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("NomeTarefa")
                        .HasMaxLength(255);

                    b.Property<int>("Type")
                        .HasColumnName("Tipo");

                    b.Property<int?>("UserId");

                    b.HasKey("IdTask");

                    b.HasIndex("UserId");

                    b.ToTable("Tarefas");
                });

            modelBuilder.Entity("TesteLucas.Models.EntityModel.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("Nome")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("TesteLucas.Models.EntityModel.Tasks.Task", b =>
                {
                    b.HasOne("TesteLucas.Models.EntityModel.Users.User", "User")
                        .WithMany("TaskList")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}