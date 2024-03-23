using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchoolAdnAPI.Services.Domain;

[Table("ApplicantAchievementRecord")]
public partial class ApplicantAchievementRecord
{
    [Key]
    [Column("AchievementID")]
    public int AchievementId { get; set; }

    [StringLength(50)]
    public string? Title { get; set; }

    [StringLength(12)]
    public string? Level { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }

    [StringLength(100)]
    public string? AchievementDocument { get; set; }

    public int? AchievementScore { get; set; }

    [Column("isVerified")]
    public bool? IsVerified { get; set; }

    [Column("UGDataID")]
    public int? UgdataId { get; set; }

    [ForeignKey("UgdataId")]
    [InverseProperty("ApplicantAchievementRecords")]
    public virtual ApplicantDatum? Ugdata { get; set; }
}
