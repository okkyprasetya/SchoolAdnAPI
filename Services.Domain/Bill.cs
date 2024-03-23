using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchoolAdnAPI.Services.Domain;

public partial class Bill
{
    [Key]
    [Column("BillsID")]
    public int BillsId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PaymentDueDate { get; set; }

    [StringLength(50)]
    public string? Type { get; set; }

    [Column(TypeName = "money")]
    public decimal? Nominals { get; set; }

    [InverseProperty("Bills")]
    public virtual ICollection<StudentBill> StudentBills { get; set; } = new List<StudentBill>();
}
