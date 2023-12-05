using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class User : BaseEntity
    {
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public string? Email { get; set; }
        public DateTime? LastLogin { get; set; }
        public string? HashRefreshToken { get; set; }
        public int Status { get; set; }
        public string? StatusMessage { get; set; }
        public string? Code { get; set; }
    }
}
