using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ChangeMgmt.Data.Models.ChangeMgmt
{
    public partial class ChangeMgmtContext : DbContext
    {
        public ChangeMgmtContext()
        {
        }

        public ChangeMgmtContext(DbContextOptions<ChangeMgmtContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserActivity> UserActivity { get; set; }
        public virtual DbSet<UserActivityCompletion> UserActivityCompletion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=ChangeMgmt;User Id=sa;Password=D0ck3r5QL53rv3r;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User", "usr");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Email).HasMaxLength(60);

                entity.Property(e => e.FirstName).HasMaxLength(30);

                entity.Property(e => e.LastName).HasMaxLength(40);

                entity.Property(e => e.Password).HasMaxLength(32);
            });

            modelBuilder.Entity<UserActivity>(entity =>
            {
                entity.HasKey(e => e.ActivityId)
                    .HasName("PK__UserActi__45F4A7F157905896");

                entity.ToTable("UserActivity", "usr");

                entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(30);
            });

            modelBuilder.Entity<UserActivityCompletion>(entity =>
            {
                entity.ToTable("UserActivityCompletion", "usr");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

                entity.Property(e => e.CompletionDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.UserActivityCompletion)
                    .HasForeignKey(d => d.ActivityId)
                    .HasConstraintName("UserActivityCompletion_Activity_FK");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserActivityCompletion)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("UserActivityCompletion_User_FK");
            });
        }
    }
}
