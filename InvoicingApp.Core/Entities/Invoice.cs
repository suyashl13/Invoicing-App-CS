using System.ComponentModel.DataAnnotations.Schema;
using InvoicingApp.Core.Entities;

public class Invoice
{
    public Guid InvoiceId { get; set; }
    public Guid ShopId { get; set; }

    [ForeignKey("ShopId")]
    public Shop Shop { get; set; } = null!;
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

    public List<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();

}