using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchoolAdnAPI.Services.Domain;

public partial class ApplicantPersonalDatum
{
    [Key]
    [Column("UPDataID")]
    public int UpdataId { get; set; }

    [StringLength(50)]
    public string? FatherName { get; set; }

    [StringLength(50)]
    public string? FatherAddress { get; set; }

    [StringLength(50)]
    public string? FatherJob { get; set; }

    public int? FatherSalary { get; set; }

    [StringLength(50)]
    public string? MotherName { get; set; }

    [StringLength(50)]
    public string? MotherAddress { get; set; }

    [StringLength(50)]
    public string? MotherJob { get; set; }

    public int? MotherSalary { get; set; }

    public int? SiblingsNumber { get; set; }

    [StringLength(20)]
    public string? Hobi { get; set; }

    [Column("KKDocument")]
    [StringLength(20)]
    public string? Kkdocument { get; set; }

    [StringLength(20)]
    public string? BirthDocument { get; set; }

    [Column("isVerified")]
    public bool? IsVerified { get; set; }

    [InverseProperty("Updata")]
    public virtual ICollection<ApplicantDatum> ApplicantData { get; set; } = new List<ApplicantDatum>();
}
