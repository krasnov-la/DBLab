using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess;

public record Worker
{
    [Key]
    public Guid Id { get; init; } = Guid.NewGuid();
    [MaxLength(64)]
    public required string Name { get; init; }
    [MaxLength(64)]
    public required string Surname { get; init; }
    [ForeignKey("Role")]
    public required Guid RoleId { get; init; }
    [ForeignKey("Location")]
    public required Guid LocationId { get; init; }

    public Role? Role { get; init; }
    public Location? Location { get; init; }
}
