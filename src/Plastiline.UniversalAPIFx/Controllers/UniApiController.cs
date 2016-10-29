using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace Plastiline.UniversalAPIFx.Controllers
{
    [Route("api")]
    public class UniApiController : Controller
    {
        private readonly IConfiguration _config;

        public UniApiController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        public IEnumerable<dynamic> Get(string q)
        {
            using (SqlConnection conn = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                conn.Open();
                IEnumerable<dynamic> objects = conn.Query(q);
                return objects;
            }
        }

        [HttpPost, HttpPatch, HttpPatch, HttpDelete]
        public void Post(string q)
        {
            using (SqlConnection conn = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                conn.Open();
                conn.Execute(q);
            }
        }
    }
}
