using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess
{
    public record Worker
    {
        [Key]
        public Guid Id {get; init;} = Guid.NewGuid();
        [MaxLength(64)]
        public string Name {get; init;}
        [MaxLength(64)]
        public string Surname {get; init;}
        [ForeignKey("Role")]
        public Guid RoleId {get; init;}
        [ForeignKey("Location")]
        public Guid LocationId {get; init;}

        public Role? Role {get; init;}
        public Location? Location {get; init;}

        public Worker(string name, string surname, Guid locationId)
        {
            if (!NameCheck(name)) throw new ArgumentException("Name invalid");
            if (!SurnameCheck(name)) throw new ArgumentException("Surname invalid");
            Name = name;
            Surname = surname;
            LocationId = locationId;
        }

        protected virtual bool NameCheck(string name)
        {
            return Name.Length <= 32 && Name.Length >= 1;
        }

        protected virtual bool SurnameCheck(string surname)
        {
            return surname.Length <= 32 && surname.Length >= 1;
        }
        
 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618
        public Worker() {}
#pragma warning restore CS8618
    }
}