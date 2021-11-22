using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace UCP1_PAW_039_C.Models
{
    public partial class ClassFunContext : DbContext
    {
        public ClassFunContext()
        {
        }

        public ClassFunContext(DbContextOptions<ClassFunContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<ChangeProfil> ChangeProfils { get; set; }
        public virtual DbSet<Download> Downloads { get; set; }
        public virtual DbSet<EditProfil> EditProfils { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Materi> Materis { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Register> Registers { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Upgrade> Upgrades { get; set; }
        public virtual DbSet<User> Users { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.Idadmin);

                entity.ToTable("Admin");

                entity.Property(e => e.Idadmin)
                    .ValueGeneratedNever()
                    .HasColumnName("IDAdmin");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChangeProfil>(entity =>
            {
                entity.HasKey(e => e.IdChangeProfil);

                entity.ToTable("ChangeProfil");

                entity.Property(e => e.IdChangeProfil).ValueGeneratedNever();

                entity.Property(e => e.Addres)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("First_Name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Last_Name");

                entity.Property(e => e.PhoneNumber).HasColumnName("Phone_Number");
            });

            modelBuilder.Entity<Download>(entity =>
            {
                entity.HasKey(e => e.IdDownload);

                entity.ToTable("Download");

                entity.Property(e => e.IdDownload).ValueGeneratedNever();

                entity.Property(e => e.EducationalStage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Educational_Stage");

                entity.Property(e => e.Materi)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UrlMateri)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Url_Materi");
            });

            modelBuilder.Entity<EditProfil>(entity =>
            {
                entity.HasKey(e => e.IdEditProfil);

                entity.ToTable("EditProfil");

                entity.Property(e => e.IdEditProfil).ValueGeneratedNever();

                entity.Property(e => e.Addres)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber).HasColumnName("Phone_Number");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasKey(e => e.IdEvent);

                entity.ToTable("Event");

                entity.Property(e => e.IdEvent).ValueGeneratedNever();

                entity.Property(e => e.NameEvent)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Name_Event");

                entity.Property(e => e.UrlEvent)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Url_Event");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.IdLogin);

                entity.ToTable("Login");

                entity.Property(e => e.IdLogin).ValueGeneratedNever();

                entity.Property(e => e.LoginStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Login_Status");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Materi>(entity =>
            {
                entity.HasKey(e => e.IdMateri);

                entity.ToTable("Materi");

                entity.Property(e => e.IdMateri).ValueGeneratedNever();

                entity.Property(e => e.Materi1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Materi");

                entity.Property(e => e.Serach)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UrlMateri)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Url_Materi");

                entity.Property(e => e.UrlPicture)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Url_Picture");

                entity.Property(e => e.UrlVideo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Url_Video");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasKey(e => e.IdMenu);

                entity.ToTable("Menu");

                entity.Property(e => e.IdMenu).ValueGeneratedNever();

                entity.Property(e => e.PilihMenu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pilih_Menu");

                entity.Property(e => e.Profil)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.IdPayment);

                entity.ToTable("Payment");

                entity.Property(e => e.IdPayment).ValueGeneratedNever();

                entity.Property(e => e.CodePayment).HasColumnName("Code_Payment");

                entity.Property(e => e.Price)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Register>(entity =>
            {
                entity.HasKey(e => e.IdRegister);

                entity.ToTable("Register");

                entity.Property(e => e.IdRegister).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Idstudent);

                entity.ToTable("Student");

                entity.Property(e => e.Idstudent)
                    .ValueGeneratedNever()
                    .HasColumnName("IDStudent");

                entity.Property(e => e.NameStudent)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Name_Student");

                entity.Property(e => e.NoHp).HasColumnName("No_HP");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Upgrade>(entity =>
            {
                entity.HasKey(e => e.IdUpgrade);

                entity.ToTable("Upgrade");

                entity.Property(e => e.IdUpgrade).ValueGeneratedNever();

                entity.Property(e => e.PremiumMode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Premium_Mode");

                entity.Property(e => e.TrialMode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Trial_Mode");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.ToTable("User");

                entity.Property(e => e.IdUser).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
