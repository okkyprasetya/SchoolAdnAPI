using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchoolAdnAPI.Services.Domain;

public partial class ApplicantAcademicDatum
{
    [Key]
    [Column("UADataID")]
    public int UadataId { get; set; }

    public int? RaportSummaries { get; set; }

    [StringLength(120)]
    public string? RaportDocument { get; set; }

    [Column("isVerified")]
    public bool? IsVerified { get; set; }

    [InverseProperty("Uadata")]
    public virtual ICollection<ApplicantDatum> ApplicantData { get; set; } = new List<ApplicantDatum>();
}
