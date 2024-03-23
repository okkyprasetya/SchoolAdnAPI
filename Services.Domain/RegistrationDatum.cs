using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchoolAdnAPI.Services.Domain;

public partial class RegistrationDatum
{
    [Key]
    [Column("RegistrationID")]
    public int RegistrationId { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [Column("VerificatorID")]
    public int? VerificatorId { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    public int? TotalScore { get; set; }

    [InverseProperty("Registration")]
    public virtual ICollection<NewStudentDatum> NewStudentData { get; set; } = new List<NewStudentDatum>();

    [ForeignKey("UserId")]
    [InverseProperty("RegistrationData")]
    public virtual UserDatum User { get; set; } = null!;

    [ForeignKey("VerificatorId")]
    [InverseProperty("RegistrationData")]
    public virtual VerificatorDatum? Verificator { get; set; }
}
