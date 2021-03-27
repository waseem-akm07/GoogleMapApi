using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using GoogleMap.Models;

namespace GoogleMap.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class googleController : ApiController
    {
        MvcdbEntities1 db = new MvcdbEntities1();

        // GET: api/google
        [HttpGet]
        [Route("api/google/getallloctions")]
        public IEnumerable<MapCoordinate> Get()
        {
           var data = db.MapCoordinates.ToList();
            return data;
        }

        // GET: api/google/5
        [HttpGet]
        [Route("api/google/getlocation/{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/google
        [HttpPost]
        [Route("api/google/postlocation")]
        public void Post(HelperModel model)
        {
            MapCoordinate map = new MapCoordinate();
            map.Latitude = model.Latitude;
            map.Longitude = model.Longitude;
            map.LoactionName = model.LocationName;
            db.MapCoordinates.Add(map);
            db.SaveChanges();
        }

        // PUT: api/google/5
        [HttpPost]
        [Route("api/google/putlocation/{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/google/5
        [HttpPost]
        [Route("api/google/delete/{id}")]
        public void Delete(int id)
        {
        }
    }
}
