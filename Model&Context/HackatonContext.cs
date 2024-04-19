using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EkzTest
{
    public partial class HackatonContext : DbContext
    {
        public HackatonContext()
        {
        }

        public HackatonContext(DbContextOptions<HackatonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activities> Activities { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Directions> Directions { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Genders> Genders { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<UserActivities> UserActivities { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-T9MJ8MA\\SQLEXPRESS; database=Hackaton; Integrated Security=false; Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activities>(entity =>
            {
                entity.HasIndex(e => e.EventId)
                    .HasName("IX_EventId");

                entity.HasIndex(e => e.ModeratorId)
                    .HasName("IX_ModeratorId");

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("FK_dbo.Activities_dbo.Events_EventId");

                entity.HasOne(d => d.Moderator)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.ModeratorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Activities_dbo.Users_ModeratorId");
            });

            modelBuilder.Entity<Cities>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.Property(e => e.CodeLetter).IsRequired();

                entity.Property(e => e.Title).IsRequired();

                entity.Property(e => e.TitleEnglish).IsRequired();
            });

            modelBuilder.Entity<Directions>(entity =>
            {
                entity.Property(e => e.Title).IsRequired();
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.HasIndex(e => e.CityId)
                    .HasName("IX_CityId");

                entity.HasIndex(e => e.WinnerId)
                    .HasName("IX_WinnerId");

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_dbo.Events_dbo.Cities_CityId");

                entity.HasOne(d => d.Winner)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.WinnerId)
                    .HasConstraintName("FK_dbo.Events_dbo.Users_WinnerId");
            });

            modelBuilder.Entity<Genders>(entity =>
            {
                entity.Property(e => e.Title).IsRequired();
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.Property(e => e.Title).IsRequired();
            });

            modelBuilder.Entity<UserActivities>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ActivityId })
                    .HasName("PK_dbo.UserActivities");

                entity.HasIndex(e => e.ActivityId)
                    .HasName("IX_Activity_Id");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_User_Id");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.Property(e => e.ActivityId).HasColumnName("Activity_Id");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.UserActivities)
                    .HasForeignKey(d => d.ActivityId)
                    .HasConstraintName("FK_dbo.UserActivities_dbo.Activities_Activity_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserActivities)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.UserActivities_dbo.Users_User_Id");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasIndex(e => e.CountryId)
                    .HasName("IX_CountryId");

                entity.HasIndex(e => e.DirectionId)
                    .HasName("IX_DirectionId");

                entity.HasIndex(e => e.GenderId)
                    .HasName("IX_GenderId");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleId");

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.Fullname).IsRequired();

                entity.Property(e => e.ImagePath).IsRequired();

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.PhoneNumber).IsRequired();

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_dbo.Users_dbo.Countries_CountryId");

                entity.HasOne(d => d.Direction)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.DirectionId)
                    .HasConstraintName("FK_dbo.Users_dbo.Directions_DirectionId");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_dbo.Users_dbo.Genders_GenderId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.Users_dbo.Roles_RoleId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
