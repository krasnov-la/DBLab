using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess;

public record Receipt
{
    [Key]
    public Guid Id { get; init; } = Guid.NewGuid();
    [ForeignKey("Auto")]
    [MaxLength(17)]
    public required string VIM { get; init; }
    [ForeignKey("Worker")]
    public required Guid WorkerId { get; init; }
    [ForeignKey("Service")]
    public required Guid ServiceId { get; init; }

    public Auto? Auto { get; init; }
    public Worker? Worker { get; init; }
    public Service? Service { get; init; }
}
