using System.ComponentModel.DataAnnotations;

namespace DataAccess
{
    public record Role
    {
        [Key]
        public Guid Id {get; init;} = Guid.NewGuid();
        [MaxLength(64)]
        public string Name {get; init;}
        public float Salary {get; init;}
        public bool IsMech {get; init;}

        public Role(string name, float salary)
        {
            if (!NameCheck(name)) throw new ArgumentException("Name invalid");
            Name = name;
            Salary = salary;
        }

        protected virtual bool NameCheck(string name)
        {
            return Name.Length <= 32 && Name.Length >= 1;
        }

// Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618
        public Role() {}
#pragma warning restore CS8618
    }
}