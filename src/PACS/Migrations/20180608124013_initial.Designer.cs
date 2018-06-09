using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PACS.DB;

namespace PACS.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20180608124013_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PACS.Models.GymCard", b =>
                {
                    b.Property<int>("GymCardId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOrder");

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<int>("GymMemberId");

                    b.Property<string>("Kind");

                    b.Property<bool>("Trainer");

                    b.Property<bool>("Visible");

                    b.HasKey("GymCardId");

                    b.HasIndex("GymMemberId");

                    b.ToTable("GymCards");
                });

            modelBuilder.Entity("PACS.Models.GymMember", b =>
                {
                    b.Property<int>("GymMemberId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDate");

                    b.Property<DateTime>("DateRegistration");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<string>("RelImage");

                    b.Property<bool>("Staff");

                    b.HasKey("GymMemberId");

                    b.ToTable("GymMembers");
                });

            modelBuilder.Entity("PACS.Models.GymCard", b =>
                {
                    b.HasOne("PACS.Models.GymMember", "GymMember")
                        .WithMany()
                        .HasForeignKey("GymMemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
