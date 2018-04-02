﻿// <auto-generated />
using MBR.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace MBR.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20180316032127_m4")]
    partial class m4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MBR.Models.BrokerCustomer", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("address");

                    b.Property<string>("customerid");

                    b.Property<string>("employeeid");

                    b.Property<string>("employer");

                    b.Property<bool>("employerVerified");

                    b.Property<string>("insuranceCompany");

                    b.Property<bool>("insuranceVerified");

                    b.Property<string>("name");

                    b.Property<string>("phone");

                    b.HasKey("ID");

                    b.HasIndex("customerid");

                    b.HasIndex("employeeid");

                    b.ToTable("brokerCustomers");
                });

            modelBuilder.Entity("MBR.Models.Employee", b =>
                {
                    b.Property<string>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("employeeId");

                    b.Property<string>("name");

                    b.Property<string>("position");

                    b.Property<long>("salary");

                    b.Property<long>("years");

                    b.HasKey("id");

                    b.ToTable("employerEmployees");
                });

            modelBuilder.Entity("MBR.Models.InsuranceCustomer", b =>
                {
                    b.Property<string>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name");

                    b.Property<long>("value");

                    b.HasKey("id");

                    b.ToTable("insuranceCustomers");
                });

            modelBuilder.Entity("MBR.Models.BrokerCustomer", b =>
                {
                    b.HasOne("MBR.Models.InsuranceCustomer", "customer")
                        .WithMany()
                        .HasForeignKey("customerid");

                    b.HasOne("MBR.Models.Employee", "employee")
                        .WithMany()
                        .HasForeignKey("employeeid");
                });
#pragma warning restore 612, 618
        }
    }
}