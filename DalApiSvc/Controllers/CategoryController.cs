using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Model;
using DAL;

namespace DalApiSvc.Controllers
{
    public class CategoryController : ApiController
    {
        // GET api/category
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/category/5
        public string Get(int id)
        {
            return "value";
        }

        public List<CategoryDTO> GetAllCategories()
        {
            CategoryAccess catAccess = new CategoryAccess();

            //List<CategoryDTO> categories = new List<CategoryDTO>();

            //for (int index = 0; index < 5; index++)
            //{
            //    CategoryDTO cat = new CategoryDTO();

            //    cat.Id = index;
            //    cat.CategoryName = "Cat" + index.ToString();

            //    categories.Add(cat);
            //}

            //using (var context = new ModelContext())
            //{
            //   // context.Database.CreateIfNotExists();

            ////    new BombardierUtilityDBInitializer().InitializeDatabase(context);
            //}


            //return categories;
            return catAccess.GetAllCategories();
        }

        // POST api/category
        public void Post([FromBody]string value)
        {
        }

        // PUT api/category/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/category/5
        public void Delete(int id)
        {
        }
    }
}
