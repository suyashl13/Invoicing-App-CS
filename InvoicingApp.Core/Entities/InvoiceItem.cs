using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoicingApp.Core.Entities;

public class InvoiceItem {
    public Guid InvoiceItemId { get; set; }
    
    [Required]
    public string ItemName { get; set; } = null!;

    [Required]
    public int quantity { get; set; }

    [Required]
    public double price { get; set; }

    [Required]
    public Guid InvoiceId { get; set; }

    [Required]
    [ForeignKey("InvoiceId")]
    public Invoice Invoice { get; set; } = null!;

}