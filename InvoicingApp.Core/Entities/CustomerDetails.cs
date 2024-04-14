using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoicingApp.Core.Entities;

public class CustomerDetails
{
    public Guid CustomerDetailId { get; set; }

    public Guid InvoiceId { get; set; } 

    [ForeignKey("InvoiceId")]
    public Invoice Invoice { get; set; } = null!;

    [Required]
    [StringLength(30, MinimumLength = 3)]
    public string CustomerName { get; set; } = null!;

    [StringLength(30)]
    public string? CustomerAddress { get; set; }
    
    [Required]
    [DataType(DataType.EmailAddress)]
    public string CustomerEmail { get; set; } = null!;


    [Required]
    [DataType(DataType.PhoneNumber)]
    public string CustomerPhoneNumber { get; set; } = null!;


    [Required]
    [StringLength(30, MinimumLength = 3)]
    public string CustomerCity { get; set; } = null!;

}