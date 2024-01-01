using System.ComponentModel.DataAnnotations;

namespace DataAccess;

public record Location
{
    [Key]
    public Guid Id { get; init; } = Guid.NewGuid();
    public required short RegionCode { get; init; }
    [MaxLength(64)]
    public required string CityName { get; init; }
}
