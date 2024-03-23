using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchoolAdnAPI.Services.Domain;

public partial class NewStudentDatum
{
    [Key]
    [Column("StudentID")]
    public int StudentId { get; set; }

    [Column("RegistrationID")]
    public int RegistrationId { get; set; }

    [ForeignKey("RegistrationId")]
    [InverseProperty("NewStudentData")]
    public virtual RegistrationDatum Registration { get; set; } = null!;

    [InverseProperty("Student")]
    public virtual ICollection<StudentBill> StudentBills { get; set; } = new List<StudentBill>();
}
