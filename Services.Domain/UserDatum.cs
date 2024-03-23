using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchoolAdnAPI.Services.Domain;

public partial class UserDatum
{
    [Key]
    [Column("UserID")]
    public int UserId { get; set; }

    [StringLength(50)]
    public string UserEmail { get; set; } = null!;

    [StringLength(255)]
    public string Password { get; set; } = null!;

    [StringLength(50)]
    public string FirstName { get; set; } = null!;

    [StringLength(50)]
    public string MiddleName { get; set; } = null!;

    [StringLength(50)]
    public string LastName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdatedAt { get; set; }

    [Column("RoleID")]
    public int RoleId { get; set; }

    [Column("profilePhoto")]
    [MaxLength(50)]
    public byte[]? ProfilePhoto { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<ApplicantDatum> ApplicantData { get; set; } = new List<ApplicantDatum>();

    [InverseProperty("User")]
    public virtual ICollection<RegistrationDatum> RegistrationData { get; set; } = new List<RegistrationDatum>();

    [ForeignKey("RoleId")]
    [InverseProperty("UserData")]
    public virtual RoleDatum Role { get; set; } = null!;

    [InverseProperty("User")]
    public virtual ICollection<VerificatorDatum> VerificatorData { get; set; } = new List<VerificatorDatum>();
}
