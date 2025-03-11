﻿// <auto-generated />
using System;
using Esthiber_Valentin_P2_AP1.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Esthiber_Valentin_P2_AP1.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Esthiber_Valentin_P2_AP1.Models.Ciudades", b =>
                {
                    b.Property<int>("CiudadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CiudadId"));

                    b.Property<double>("Monto")
                        .HasColumnType("float");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CiudadId");

                    b.ToTable("Ciudades");

                    b.HasData(
                        new
                        {
                            CiudadId = 1,
                            Monto = 0.0,
                            Nombre = "Puerto Plata"
                        },
                        new
                        {
                            CiudadId = 2,
                            Monto = 0.0,
                            Nombre = "San Francisco de Macoris"
                        },
                        new
                        {
                            CiudadId = 3,
                            Monto = 0.0,
                            Nombre = "Cotui"
                        });
                });

            modelBuilder.Entity("Esthiber_Valentin_P2_AP1.Models.DetailsEncuestasCiudades", b =>
                {
                    b.Property<int>("DetailsEncuestasCiudadesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetailsEncuestasCiudadesId"));

                    b.Property<int>("CiudadId")
                        .HasColumnType("int");

                    b.Property<int>("CuidadId")
                        .HasColumnType("int");

                    b.Property<int>("EncuestaId")
                        .HasColumnType("int");

                    b.Property<double>("Monto")
                        .HasColumnType("float");

                    b.HasKey("DetailsEncuestasCiudadesId");

                    b.HasIndex("CiudadId");

                    b.HasIndex("EncuestaId");

                    b.ToTable("DetailsEncuestas");
                });

            modelBuilder.Entity("Esthiber_Valentin_P2_AP1.Models.Encuestas", b =>
                {
                    b.Property<int>("EncuestaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EncuestaId"));

                    b.Property<string>("Asignatura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("EncuestaId");

                    b.ToTable("Encuestas");
                });

            modelBuilder.Entity("Esthiber_Valentin_P2_AP1.Models.DetailsEncuestasCiudades", b =>
                {
                    b.HasOne("Esthiber_Valentin_P2_AP1.Models.Ciudades", "Ciudad")
                        .WithMany()
                        .HasForeignKey("CiudadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Esthiber_Valentin_P2_AP1.Models.Encuestas", "Encuesta")
                        .WithMany("DetailsEncuestas")
                        .HasForeignKey("EncuestaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudad");

                    b.Navigation("Encuesta");
                });

            modelBuilder.Entity("Esthiber_Valentin_P2_AP1.Models.Encuestas", b =>
                {
                    b.Navigation("DetailsEncuestas");
                });
#pragma warning restore 612, 618
        }
    }
}
