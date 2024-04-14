namespace InvoicingApp.Core.Entities;
using  Microsoft.AspNetCore.Identity;

public class ApplicationUser: IdentityUser<Guid>
{
    public ICollection<Shop> Shops { get; set; } = null!;
}