﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteVagaJr.Infrastructure;

#nullable disable

namespace TesteVagaJr.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221012043931_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TesteVagaJr.Domain.Entities.Empresa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("VARCHAR(2)");

                    b.HasKey("Id");

                    b.ToTable("Empresas", (string)null);
                });

            modelBuilder.Entity("TesteVagaJr.Domain.Entities.Fornecedor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataHoraCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EmpresaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RG")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<int>("TipoDocumento")
                        .HasColumnType("int");

                    b.Property<int>("TipoFornecedor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Fornecedores", (string)null);
                });

            modelBuilder.Entity("TesteVagaJr.Domain.Entities.Telefone", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DDD")
                        .IsRequired()
                        .HasColumnType("VARCHAR(2)");

                    b.Property<Guid?>("FornecedorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("VARCHAR(9)");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Telefone", (string)null);
                });

            modelBuilder.Entity("TesteVagaJr.Domain.Entities.Fornecedor", b =>
                {
                    b.HasOne("TesteVagaJr.Domain.Entities.Empresa", "Empresa")
                        .WithMany("Fornecedores")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("TesteVagaJr.Domain.Entities.Telefone", b =>
                {
                    b.HasOne("TesteVagaJr.Domain.Entities.Fornecedor", null)
                        .WithMany("Telefones")
                        .HasForeignKey("FornecedorId");
                });

            modelBuilder.Entity("TesteVagaJr.Domain.Entities.Empresa", b =>
                {
                    b.Navigation("Fornecedores");
                });

            modelBuilder.Entity("TesteVagaJr.Domain.Entities.Fornecedor", b =>
                {
                    b.Navigation("Telefones");
                });
#pragma warning restore 612, 618
        }
    }
}