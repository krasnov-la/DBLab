using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DataAccess;

public record Auto
{
    [Key]
    [MaxLength(17)]
    public required string VIM { get; init; }
    [ForeignKey("Owner")]
    public required Guid OwnerId { get; init; }
    public Client? Owner { get; init; }
    public static readonly string VIMCharset = "0123456789ABCDEFGHJKLMNPRSTUVWXYZ";
}
