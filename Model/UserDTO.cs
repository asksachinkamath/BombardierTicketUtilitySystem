using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string PSA { get; set; }

        public string Email { get; set; }

        public string PassWord { get; set; }

        public DateTime DateCreated { get; set; }

        public string Role { get; set; }
    }
}
