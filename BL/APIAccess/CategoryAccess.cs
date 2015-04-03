using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BL
{
    public class CategoryAccess
    {
        public List<CategoryDTO> GetCategories()
        {
            List<CategoryDTO> categories = new List<CategoryDTO>();

            for (int index = 0; index < 5; index++)
            {
                CategoryDTO catDto = new CategoryDTO();

                catDto.Id = index;
                catDto.CategoryName = "Cat" + index.ToString();

                categories.Add(catDto);
            }

            return categories;
        }
    }
}
