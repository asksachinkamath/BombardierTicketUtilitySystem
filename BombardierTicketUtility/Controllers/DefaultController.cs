using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using BombardierTicketUtility.DTO;
using BombardierTicketUtility.ViewModel;
using Newtonsoft.Json;

namespace BombardierTicketUtility.Controllers
{
    public class DefaultController : Controller
    {
        //
        // GET: /Default/

        public ActionResult Index()
        {

            var model = new CategoryViewModel();
        

            
        
            model.CategoryList = new SelectList(getallcategory(), "Id", "CategoryName");


            return View(model);
        }

        private List<CategoryDTO> getallcategory()
        {
            HttpClient client = new HttpClient();
            // I have hosted my WebAPI on the port "5015". Please Publish the WebAPI from the solution and assign this port number.
            // This will not be required once we host it to the development and other servers.
            // The present address is "http://localhost:5015/"

            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["BaseAddress"]);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Make an Asynchronous call to the WebAPI Deployed. 
            HttpResponseMessage response = client.GetAsync("api/category/GetAllCategories").Result;

            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                //serialize to an object using Newtonsoft.Json nuget package
                var Categorylist = (JsonConvert.DeserializeObject<List<CategoryDTO>>(result));

                return Categorylist;

            }
            else
            {

                return new List<CategoryDTO>();
            }
        }







    }
}
