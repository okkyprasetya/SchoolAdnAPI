using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchoolAdnAPI.Services.Domain;

public partial class VerificatorDatum
{
    [Key]
    [Column("VerificatorID")]
    public int VerificatorId { get; set; }

    [StringLength(10)]
    public string? Position { get; set; }

    [Column("SKNumber")]
    [StringLength(10)]
    public string? Sknumber { get; set; }

    [Column("RoleID")]
    public int RoleId { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [InverseProperty("Verificator")]
    public virtual ICollection<RegistrationDatum> RegistrationData { get; set; } = new List<RegistrationDatum>();

    [ForeignKey("UserId")]
    [InverseProperty("VerificatorData")]
    public virtual UserDatum User { get; set; } = null!;
}
