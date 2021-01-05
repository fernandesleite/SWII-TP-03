﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TP02SWII;

namespace TP02SWII.Migrations
{
    [DbContext(typeof(PortoContext))]
    partial class PortoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TP02SWII.Models.BL", b =>
                {
                    b.Property<int>("BLId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Consignee");

                    b.Property<int>("Number");

                    b.Property<string>("Ship");

                    b.HasKey("BLId");

                    b.ToTable("BLs");
                });

            modelBuilder.Entity("TP02SWII.Models.Container", b =>
                {
                    b.Property<int>("ContainerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BLId");

                    b.Property<int>("Number");

                    b.Property<string>("Size");

                    b.Property<string>("Type");

                    b.HasKey("ContainerId");

                    b.HasIndex("BLId");

                    b.ToTable("Containers");
                });

            modelBuilder.Entity("TP02SWII.Models.Container", b =>
                {
                    b.HasOne("TP02SWII.Models.BL", "BL")
                        .WithMany("Containers")
                        .HasForeignKey("BLId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
