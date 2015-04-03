using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;

namespace DAL
{
    public class CategoryAccess
    {
        public List<CategoryDTO> GetAllCategories()
        {
            var users = new List<CategoryDTO>();

            using (var dbCon = new ModelContext())
            {
                dbCon.Categories.ToList().ForEach(
                    cat =>
                    {
                        var catObj = new CategoryDTO();
                        MappingHelper.mapCategoryTblToDto(catObj, cat);
                        users.Add(catObj);
                    });
            }

            return users;
        }
    }
}
