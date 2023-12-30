using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DataAccess
{
    public record Auto
    {
        [Key]
        [MaxLength(17)]
        public string VIM {get; init;}
        [ForeignKey("Owner")]
        public Guid OwnerId {get; init;}

        public Client? Owner {get; init;}

        public Auto(string vim, Guid owner)
        {
            if (!VIMCheck(vim)) throw new ArgumentException("Vim invalid");
            VIM = vim;
            OwnerId = owner;
        }

        private readonly string VIMCharset = "0123456789ABCDEFGHJKLMNPRSTUVWXYZ";
        
        protected virtual bool VIMCheck(string vim)
        {
            return vim.Length == 17 && vim.All(@char => VIMCharset.Contains(@char));
        }

// Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618
        public Auto() {}
#pragma warning restore CS8618
    }
}