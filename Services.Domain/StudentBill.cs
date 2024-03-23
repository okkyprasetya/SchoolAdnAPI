using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchoolAdnAPI.Services.Domain;

[PrimaryKey("StudentId", "BillsId")]
[Table("StudentBill")]
public partial class StudentBill
{
    [Key]
    [Column("StudentID")]
    public int StudentId { get; set; }

    [Key]
    [Column("BillsID")]
    public int BillsId { get; set; }

    [Column("isPaid")]
    public bool? IsPaid { get; set; }

    [ForeignKey("BillsId")]
    [InverseProperty("StudentBills")]
    public virtual Bill Bills { get; set; } = null!;

    [ForeignKey("StudentId")]
    [InverseProperty("StudentBills")]
    public virtual NewStudentDatum Student { get; set; } = null!;
}
