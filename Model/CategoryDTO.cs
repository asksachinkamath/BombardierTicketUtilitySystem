using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public List<ApplicationDTO> Applications { get; set; }
    }
}
