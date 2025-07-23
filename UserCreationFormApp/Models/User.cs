using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCreationFormApp.Models
{
    public class User
    {
        public int ID { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public string? Phone {  get; set; }
        public string? Address { get; set; }
        public required string CreatedAt {  get; set; }
    }
}
