using System.ComponentModel.DataAnnotations;

namespace DataAccess
{
    public record Location
    {
        [Key]
        public Guid Id {get; init;} = Guid.NewGuid();
        public short RegionCode {get; init;}
        [MaxLength(64)]
        public string CityName {get; init;}

        public Location(short region, string city)
        {
            if (!CityCheck(city)) throw new ArgumentException("City invalid");
            RegionCode = region;
            CityName = city;
        }

        protected virtual bool CityCheck(string name)
        {
            return name.Length >= 1 && name.Length <= 32;
        }

 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618
        public Location() {}
#pragma warning restore CS8618
    }
}