using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchoolAdnAPI.Services.Domain;

public partial class ApplicantDatum
{
    [Key]
    [Column("UGDataID")]
    public int UgdataId { get; set; }

    [Column("NIS")]
    [StringLength(50)]
    public string? Nis { get; set; }

    public DateOnly? DateBirth { get; set; }

    [Column("isScholarship")]
    public bool? IsScholarship { get; set; }

    [Column("ScholarshipID")]
    public int? ScholarshipId { get; set; }

    [Column("UserID")]
    public int? UserId { get; set; }

    [Column("countVerif")]
    public int? CountVerif { get; set; }

    [Column("isFinal")]
    public bool? IsFinal { get; set; }

    [Column("UADataID")]
    public int? UadataId { get; set; }

    [Column("UPDataID")]
    public int? UpdataId { get; set; }

    [InverseProperty("Ugdata")]
    public virtual ICollection<ApplicantAchievementRecord> ApplicantAchievementRecords { get; set; } = new List<ApplicantAchievementRecord>();

    [ForeignKey("ScholarshipId")]
    [InverseProperty("ApplicantData")]
    public virtual ScholarshipDatum? Scholarship { get; set; }

    [ForeignKey("UadataId")]
    [InverseProperty("ApplicantData")]
    public virtual ApplicantAcademicDatum? Uadata { get; set; }

    [ForeignKey("UpdataId")]
    [InverseProperty("ApplicantData")]
    public virtual ApplicantPersonalDatum? Updata { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("ApplicantData")]
    public virtual UserDatum? User { get; set; }
}
