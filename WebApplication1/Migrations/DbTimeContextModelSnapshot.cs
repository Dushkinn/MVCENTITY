﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DbTimeContext))]
    partial class DbTimeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("WebApplication1.Models.Friends", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("User1");

                    b.Property<int>("User2");

                    b.Property<bool>("status");

                    b.HasKey("id");

                    b.ToTable("Friends");
                });

            modelBuilder.Entity("WebApplication1.Models.TimeCapsule", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("TimeCapsuleFileId");

                    b.Property<int>("UserDestination");

                    b.Property<int>("UserSource");

                    b.HasKey("id");

                    b.ToTable("TimeCapsule");
                });

            modelBuilder.Entity("WebApplication1.Models.TimeCapsuleFiles", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("files");

                    b.HasKey("id");

                    b.ToTable("TimeCapsuleFiles");
                });

            modelBuilder.Entity("WebApplication1.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("login");

                    b.Property<string>("password");

                    b.HasKey("id");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
