using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ApplicationDTO
    {
        public int Id { get; set; }

        public string ApplicationName { get; set; }

        public int CategoryId { get; set; }

        public CategoryDTO Category { get; set; }
    }
}
