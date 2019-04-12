﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using RestauranteWeb.API.Data;
using System;

namespace RestauranteWeb.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("RestauranteWeb.API.Model.Prato", b =>
                {
                    b.Property<int>("PratoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DisponibilidadePrato");

                    b.Property<string>("NomePrato");

                    b.Property<int>("RestauranteId");

                    b.Property<float>("ValorPrato");

                    b.HasKey("PratoId");

                    b.ToTable("Prato");
                });
#pragma warning restore 612, 618
        }
    }
}
