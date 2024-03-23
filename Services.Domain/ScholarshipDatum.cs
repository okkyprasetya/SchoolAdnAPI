using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchoolAdnAPI.Services.Domain;

public partial class ScholarshipDatum
{
    [Key]
    [Column("ScholarshipID")]
    public int ScholarshipId { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    [StringLength(50)]
    public string Provider { get; set; } = null!;

    [StringLength(50)]
    public string? Benefit { get; set; }

    [InverseProperty("Scholarship")]
    public virtual ICollection<ApplicantDatum> ApplicantData { get; set; } = new List<ApplicantDatum>();
}
