using System.ComponentModel.DataAnnotations;

namespace DataAccess
{
    public record Service
    {
        [Key]
        public Guid Id {get; init;} = Guid.NewGuid();
        [MaxLength(64)]
        public string Name {get; init;}
        public float Price {get; init;}

        public Service(string name, float price)
        {
            if (!NameCheck(name)) throw new ArgumentException("Name invalid");
            Name = name;
            Price = float.Truncate(price * 100) / 100;
        }

        protected virtual bool NameCheck(string name)
        {
            return name.Length <= 64 && name.Length >= 1;
        }
        
// Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 
        public Service() {}
#pragma warning restore CS8618
    }
}