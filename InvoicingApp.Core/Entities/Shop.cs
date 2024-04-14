using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoicingApp.Core.Entities;

public class Shop
{
    [Key]
    public Guid ShopId { get; set; }

    [Required]
    public Guid OwnerId { get; set; }

    [Required]
    [ForeignKey("OwnerId")]
    public ApplicationUser Owner { get; set; } = null!;

    [Required]
    [StringLength(40)]
    public string ShopName { get; set; } = null!;

    [Required]
    [StringLength(10, MinimumLength = 10)]
    public string? ShopShortAddress { get; set; }

    [Required]
    [EmailAddress]
    public string ShopEmail { get; set; } = null!;

    [Required]
    [Length(10, 12)]
    public string ShopPhone { get; set; } = null!;

    public string? Address { get; set; }

    public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    [DefaultValue(true)]
    public bool IsActive { get; set; }
}