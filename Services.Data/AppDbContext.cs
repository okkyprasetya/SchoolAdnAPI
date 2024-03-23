using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SchoolAdnAPI.Services.Domain;

namespace SchoolAdnAPI.Services.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ApplicantAcademicDatum> ApplicantAcademicData { get; set; }

    public virtual DbSet<ApplicantAchievementRecord> ApplicantAchievementRecords { get; set; }

    public virtual DbSet<ApplicantDatum> ApplicantData { get; set; }

    public virtual DbSet<ApplicantPersonalDatum> ApplicantPersonalData { get; set; }

    public virtual DbSet<Bill> Bills { get; set; }

    public virtual DbSet<NewStudentDatum> NewStudentData { get; set; }

    public virtual DbSet<RegistrationDatum> RegistrationData { get; set; }

    public virtual DbSet<RoleDatum> RoleData { get; set; }

    public virtual DbSet<ScholarshipDatum> ScholarshipData { get; set; }

    public virtual DbSet<StudentBill> StudentBills { get; set; }

    public virtual DbSet<UserDatum> UserData { get; set; }

    public virtual DbSet<VerificatorDatum> VerificatorData { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApplicantAcademicDatum>(entity =>
        {
            entity.HasKey(e => e.UadataId).HasName("table1_pkey");
        });

        modelBuilder.Entity<ApplicantAchievementRecord>(entity =>
        {
            entity.HasKey(e => e.AchievementId).HasName("table1_pkey9");

            entity.HasOne(d => d.Ugdata).WithMany(p => p.ApplicantAchievementRecords).HasConstraintName("FK_ApplicantAchievementRecord_ApplicantData");
        });

        modelBuilder.Entity<ApplicantDatum>(entity =>
        {
            entity.HasKey(e => e.UgdataId).HasName("table1_pkey2");

            entity.Property(e => e.CountVerif).HasDefaultValue(0);
            entity.Property(e => e.IsFinal).HasDefaultValue(false);

            entity.HasOne(d => d.Scholarship).WithMany(p => p.ApplicantData).HasConstraintName("FK_ApplicantData_ScholarshipData");

            entity.HasOne(d => d.Uadata).WithMany(p => p.ApplicantData).HasConstraintName("FK_ApplicantData_ApplicantAcademicData");

            entity.HasOne(d => d.Updata).WithMany(p => p.ApplicantData).HasConstraintName("FK_ApplicantData_ApplicantPersonalData");

            entity.HasOne(d => d.User).WithMany(p => p.ApplicantData).HasConstraintName("ApplicantData_UserData_UserID_fkey");
        });

        modelBuilder.Entity<ApplicantPersonalDatum>(entity =>
        {
            entity.HasKey(e => e.UpdataId).HasName("table1_pkey1");
        });

        modelBuilder.Entity<Bill>(entity =>
        {
            entity.HasKey(e => e.BillsId).HasName("table1_pkey11");

            entity.Property(e => e.Type).IsFixedLength();
        });

        modelBuilder.Entity<NewStudentDatum>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("table1_pkey12");

            entity.HasOne(d => d.Registration).WithMany(p => p.NewStudentData)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("NewStudentData_RegistrationData_RegistrationID_fkey");
        });

        modelBuilder.Entity<RegistrationDatum>(entity =>
        {
            entity.HasKey(e => e.RegistrationId).HasName("table1_pkey6");

            entity.HasOne(d => d.User).WithMany(p => p.RegistrationData)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RegistrationData_UserData_UserID_fkey");

            entity.HasOne(d => d.Verificator).WithMany(p => p.RegistrationData).HasConstraintName("RegistrationData_VerificatorData_VerificatorID_fkey");
        });

        modelBuilder.Entity<RoleDatum>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("table1_pkey3");

            entity.Property(e => e.RoleId).ValueGeneratedNever();
        });

        modelBuilder.Entity<ScholarshipDatum>(entity =>
        {
            entity.HasKey(e => e.ScholarshipId).HasName("table1_pkey7");
        });

        modelBuilder.Entity<StudentBill>(entity =>
        {
            entity.HasKey(e => new { e.StudentId, e.BillsId }).HasName("pk_StudentBill");

            entity.HasOne(d => d.Bills).WithMany(p => p.StudentBills)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Bill");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentBills)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Student");
        });

        modelBuilder.Entity<UserDatum>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("table1_pkey4");

            entity.Property(e => e.ProfilePhoto).IsFixedLength();

            entity.HasOne(d => d.Role).WithMany(p => p.UserData)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("UserData_RoleData_RoleID_fkey");
        });

        modelBuilder.Entity<VerificatorDatum>(entity =>
        {
            entity.HasKey(e => e.VerificatorId).HasName("table1_pkey5");

            entity.HasOne(d => d.User).WithMany(p => p.VerificatorData)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("VerificatorData_UserData_UserID_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
