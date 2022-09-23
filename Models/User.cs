using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace udemy1.Models
{
    public class User
    {
        public int Id { get; set; }
        public String Usernmae { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public List<Character>? Characters { get; set; }
    }
}