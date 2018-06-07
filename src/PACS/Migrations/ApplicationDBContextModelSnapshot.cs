using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PACS.DB;

namespace PACS.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PACS.Models.GymCard", b =>
                {
                    b.Property<int>("GymCardId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOrder");

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<int>("GymMemberId");

                    b.Property<int>("Kind");

                    b.Property<bool>("Tainer");

                    b.Property<bool>("Visible");

                    b.HasKey("GymCardId");

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
        }
    }
}
