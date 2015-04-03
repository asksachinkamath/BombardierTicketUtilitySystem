using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace DAL
{
    public class UserDetailTbl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string UserName { get; set; }

        public string PSA { get; set; }

        public string Email { get; set; }

        public string PassWord { get; set; }

        public DateTime DateCreated { get; set; }

        public string Role { get; set; }
    }

    public class CategoryTbl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public List<ApplicationTbl> Applications { get; set; }
    }

    public class ApplicationTbl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string ApplicationName { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public CategoryTbl Category { get; set; }
    }
}
