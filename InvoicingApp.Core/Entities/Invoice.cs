using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using InvoicingApp.Core.Entities;

public class Invoice
{
    [Key]
    public Guid InvoiceId { get; set; }

    [Required]
    public Guid ShopId { get; set; }

    public Guid CustomerDetailId { get; set; }

    [ForeignKey("CustomerDetailId")]
    public CustomerDetails CustomerDetails { get; set; } = null!;

    [ForeignKey("ShopId")]
    [Required]
    public Shop Shop { get; set; } = null!;
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

    public List<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();

}