﻿// <auto-generated />
using System;
using GreenApp.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GreenApp.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20181107022724_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview3-35497");

            modelBuilder.Entity("GreenApp.API.Models.Bussiness", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanyId");

                    b.Property<string>("Name");

                    b.Property<string>("Phonenumber");

                    b.HasKey("id");

                    b.HasIndex("CompanyId");

                    b.ToTable("bussinesses");
                });

            modelBuilder.Entity("GreenApp.API.Models.RegisterCompany", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Email");

                    b.Property<byte[]>("Logo");

                    b.Property<string>("Name");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.HasKey("id");

                    b.ToTable("registerCompanies");
                });

            modelBuilder.Entity("GreenApp.API.Models.Bussiness", b =>
                {
                    b.HasOne("GreenApp.API.Models.RegisterCompany", "Company")
                        .WithMany("Bussinesses")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
