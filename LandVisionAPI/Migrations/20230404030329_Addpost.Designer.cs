﻿// <auto-generated />
using System;
using LandVisionAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LandVisionAPI.Migrations
{
    [DbContext(typeof(LandvisionContext))]
    [Migration("20230404030329_Addpost")]
    partial class Addpost
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LandVisionAPI.Data.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("AccountId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Account", (string)null);
                });

            modelBuilder.Entity("LandVisionAPI.Data.Area", b =>
                {
                    b.Property<int>("AreaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AreaId"));

                    b.Property<string>("AreaName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.HasKey("AreaId");

                    b.HasIndex("RegionId");

                    b.ToTable("Area", (string)null);
                });

            modelBuilder.Entity("LandVisionAPI.Data.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("MediaLink")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("RealEstateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RealEstateId");

                    b.ToTable("Media", (string)null);
                });

            modelBuilder.Entity("LandVisionAPI.Data.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<int>("RealEstateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RealEstateId")
                        .IsUnique();

                    b.ToTable("Position", (string)null);
                });

            modelBuilder.Entity("LandVisionAPI.Data.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAction")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PostDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PostTypeId")
                        .HasColumnType("int");

                    b.Property<int>("RealEstateId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PostTypeId");

                    b.HasIndex("RealEstateId")
                        .IsUnique();

                    b.ToTable("Post", (string)null);
                });

            modelBuilder.Entity("LandVisionAPI.Data.PostType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PostType", (string)null);
                });

            modelBuilder.Entity("LandVisionAPI.Data.RealEstate", b =>
                {
                    b.Property<int>("RealEstateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RealEstateId"));

                    b.Property<int>("BathroomNumber")
                        .HasColumnType("int");

                    b.Property<int>("BedroomNumber")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FloorNumber")
                        .HasColumnType("int");

                    b.Property<bool>("HasCarAlley")
                        .HasColumnType("bit");

                    b.Property<bool>("HasWiderBack")
                        .HasColumnType("bit");

                    b.Property<string>("HouseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HouseType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InteriorCondition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<double>("LandArea")
                        .HasColumnType("float");

                    b.Property<string>("LegalPapers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Length")
                        .HasColumnType("float");

                    b.Property<string>("MainDoorDirection")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("PropertyFeatures")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RealEstateTypeId")
                        .HasColumnType("int");

                    b.Property<string>("ResidentialAreaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubdivisionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("UsableArea")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Ward")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("RealEstateId");

                    b.HasIndex("RealEstateTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("RealEstate", (string)null);
                });

            modelBuilder.Entity("LandVisionAPI.Data.RealEstateType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("RealEstateType", (string)null);
                });

            modelBuilder.Entity("LandVisionAPI.Data.Region", b =>
                {
                    b.Property<int>("RegionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RegionId"));

                    b.Property<string>("RegionName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RegionId");

                    b.ToTable("Region", (string)null);
                });

            modelBuilder.Entity("LandVisionAPI.Data.Role", b =>
                {
                    b.Property<string>("RoleId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("RoleId");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("LandVisionAPI.Data.TypeUser", b =>
                {
                    b.Property<int>("TypeUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeUserId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("TypeUserId");

                    b.ToTable("TypeUser", (string)null);
                });

            modelBuilder.Entity("LandVisionAPI.Data.TypeUserRole", b =>
                {
                    b.Property<string>("RoleId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TypeUserId")
                        .HasColumnType("int");

                    b.HasKey("RoleId", "TypeUserId");

                    b.HasIndex("TypeUserId");

                    b.ToTable("TypeUserRole", (string)null);
                });

            modelBuilder.Entity("LandVisionAPI.Data.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Address")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasDefaultValue("");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("Description")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)")
                        .HasDefaultValue("");

                    b.Property<int>("TypeUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Phone")
                        .IsUnique()
                        .HasFilter("[Phone] IS NOT NULL");

                    b.HasIndex("TypeUserId");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("LandVisionAPI.Data.Ward", b =>
                {
                    b.Property<int>("WardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WardId"));

                    b.Property<int>("AreaId")
                        .HasColumnType("int");

                    b.Property<string>("WardName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("WardId");

                    b.HasIndex("AreaId");

                    b.ToTable("Ward", (string)null);
                });

            modelBuilder.Entity("LandVisionAPI.Data.Account", b =>
                {
                    b.HasOne("LandVisionAPI.Data.User", "User")
                        .WithOne("Account")
                        .HasForeignKey("LandVisionAPI.Data.Account", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("LandVisionAPI.Data.Area", b =>
                {
                    b.HasOne("LandVisionAPI.Data.Region", "Region")
                        .WithMany("Areas")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("LandVisionAPI.Data.Media", b =>
                {
                    b.HasOne("LandVisionAPI.Data.RealEstate", "RealEstate")
                        .WithMany("Medias")
                        .HasForeignKey("RealEstateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RealEstate");
                });

            modelBuilder.Entity("LandVisionAPI.Data.Position", b =>
                {
                    b.HasOne("LandVisionAPI.Data.RealEstate", "RealEstate")
                        .WithOne("Position")
                        .HasForeignKey("LandVisionAPI.Data.Position", "RealEstateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RealEstate");
                });

            modelBuilder.Entity("LandVisionAPI.Data.Post", b =>
                {
                    b.HasOne("LandVisionAPI.Data.PostType", "PostTypeOfPost")
                        .WithMany("PostsOfPostType")
                        .HasForeignKey("PostTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LandVisionAPI.Data.RealEstate", "RealEstate")
                        .WithOne("Post")
                        .HasForeignKey("LandVisionAPI.Data.Post", "RealEstateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PostTypeOfPost");

                    b.Navigation("RealEstate");
                });

            modelBuilder.Entity("LandVisionAPI.Data.RealEstate", b =>
                {
                    b.HasOne("LandVisionAPI.Data.RealEstateType", "RealEstateType")
                        .WithMany("RealEstates")
                        .HasForeignKey("RealEstateTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LandVisionAPI.Data.User", "User")
                        .WithMany("RealEstates")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RealEstateType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LandVisionAPI.Data.TypeUserRole", b =>
                {
                    b.HasOne("LandVisionAPI.Data.Role", "Role")
                        .WithMany("TypeUserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LandVisionAPI.Data.TypeUser", "TypeUser")
                        .WithMany("TypeUserRoles")
                        .HasForeignKey("TypeUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("TypeUser");
                });

            modelBuilder.Entity("LandVisionAPI.Data.User", b =>
                {
                    b.HasOne("LandVisionAPI.Data.TypeUser", "TypeUser")
                        .WithMany("Users")
                        .HasForeignKey("TypeUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypeUser");
                });

            modelBuilder.Entity("LandVisionAPI.Data.Ward", b =>
                {
                    b.HasOne("LandVisionAPI.Data.Area", "Area")
                        .WithMany("Wards")
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");
                });

            modelBuilder.Entity("LandVisionAPI.Data.Area", b =>
                {
                    b.Navigation("Wards");
                });

            modelBuilder.Entity("LandVisionAPI.Data.PostType", b =>
                {
                    b.Navigation("PostsOfPostType");
                });

            modelBuilder.Entity("LandVisionAPI.Data.RealEstate", b =>
                {
                    b.Navigation("Medias");

                    b.Navigation("Position")
                        .IsRequired();

                    b.Navigation("Post")
                        .IsRequired();
                });

            modelBuilder.Entity("LandVisionAPI.Data.RealEstateType", b =>
                {
                    b.Navigation("RealEstates");
                });

            modelBuilder.Entity("LandVisionAPI.Data.Region", b =>
                {
                    b.Navigation("Areas");
                });

            modelBuilder.Entity("LandVisionAPI.Data.Role", b =>
                {
                    b.Navigation("TypeUserRoles");
                });

            modelBuilder.Entity("LandVisionAPI.Data.TypeUser", b =>
                {
                    b.Navigation("TypeUserRoles");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("LandVisionAPI.Data.User", b =>
                {
                    b.Navigation("Account")
                        .IsRequired();

                    b.Navigation("RealEstates");
                });
#pragma warning restore 612, 618
        }
    }
}
