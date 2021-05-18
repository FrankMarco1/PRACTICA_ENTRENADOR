﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pokemonapp.Models;

namespace pokemonapp.Migrations
{
    [DbContext(typeof(PokemonContext))]
    partial class PokemonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PokemonTipo", b =>
                {
                    b.Property<int>("PokemonesId")
                        .HasColumnType("int");

                    b.Property<int>("TiposId")
                        .HasColumnType("int");

                    b.HasKey("PokemonesId", "TiposId");

                    b.HasIndex("TiposId");

                    b.ToTable("PokemonTipo");
                });

            modelBuilder.Entity("pokemonapp.Models.Entrenador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PuebloId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PuebloId");

                    b.ToTable("Entrenadores");
                });

            modelBuilder.Entity("pokemonapp.Models.Pokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pokemones");
                });

            modelBuilder.Entity("pokemonapp.Models.Pueblo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Pueblos");
                });

            modelBuilder.Entity("pokemonapp.Models.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regiones");
                });

            modelBuilder.Entity("pokemonapp.Models.Tipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tipo");
                });

            modelBuilder.Entity("PokemonTipo", b =>
                {
                    b.HasOne("pokemonapp.Models.Pokemon", null)
                        .WithMany()
                        .HasForeignKey("PokemonesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("pokemonapp.Models.Tipo", null)
                        .WithMany()
                        .HasForeignKey("TiposId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("pokemonapp.Models.Entrenador", b =>
                {
                    b.HasOne("pokemonapp.Models.Pueblo", "Pueblo")
                        .WithMany("Entrenadores")
                        .HasForeignKey("PuebloId");

                    b.Navigation("Pueblo");
                });

            modelBuilder.Entity("pokemonapp.Models.Pueblo", b =>
                {
                    b.HasOne("pokemonapp.Models.Region", "Region")
                        .WithMany("Pueblos")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("pokemonapp.Models.Pueblo", b =>
                {
                    b.Navigation("Entrenadores");
                });

            modelBuilder.Entity("pokemonapp.Models.Region", b =>
                {
                    b.Navigation("Pueblos");
                });
#pragma warning restore 612, 618
        }
    }
}
