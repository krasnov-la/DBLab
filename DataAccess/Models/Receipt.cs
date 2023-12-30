using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess
{
    public record Receipt
    {
        [Key]
        public Guid Id {get; init;} = Guid.NewGuid();
        [ForeignKey("Auto")]
        [MaxLength(17)]
        public string VIM {get; init;}
        [ForeignKey("Worker")]
        public Guid WorkerId {get; init;}
        [ForeignKey("Service")]
        public Guid ServiceId {get; init;}

        public Auto? Auto {get; init;}
        public Worker? Worker {get; init;}
        public Service? Service {get; init;}

        public Receipt(string vim, Guid workerId, Guid serviceId)
        {
            if (!VIMCheck(vim)) throw new ArgumentException("Vim Invalid");
            VIM = vim;
            WorkerId = workerId;
            ServiceId = serviceId;
        }

        protected string VIMCharset = "0123456789ABCDEFGHJKLMNPRSTUVWXYZ";

        protected virtual bool VIMCheck(string vim)
        {
            return vim.Length == 17 && vim.All(@char => VIMCharset.Contains(@char));
        }

// Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618
        public Receipt() {}
#pragma warning restore CS8618
    }
}