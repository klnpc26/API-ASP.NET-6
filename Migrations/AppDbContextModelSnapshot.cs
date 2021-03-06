// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TESTEAPI.Data;

#nullable disable

namespace TESTEAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("TESTEAPI.Models.Customer", b =>
                {
                    b.Property<int>("idCustomer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("dsCPFCNPJ")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("dsEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("dsName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("dtBirthDate")
                        .HasColumnType("TEXT");

                    b.HasKey("idCustomer");

                    b.ToTable("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
