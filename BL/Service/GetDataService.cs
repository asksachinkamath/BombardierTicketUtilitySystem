using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BL
{
    public class GetDataService : IGetDataService
    {
        public List<CategoryDTO> GetCategories()
        {
            CategoryAccess catAcc = new CategoryAccess();

            return catAcc.GetCategories();
        }
    }
}
