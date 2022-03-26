using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apiD1.Models;
namespace apiD1.Controllers
{
    public class employeesController : ApiController
    {
        static List<employee> emps = new List<employee>()
       {
           new employee(){id=1,name="ali ahmed",age=32,address="cairo"},
           new employee(){id=2,name="mohamed mostafa",age=33,address="alex"},
           new employee(){id=3,name="mona ahmed",age=25,address="alex"},
           new employee(){id=4,name="sara ali",age=32,address="cairo"},
       };

        //get all
       
        public List<employee> getall()
        {
            return emps;
        }

        //get by id

        //webapi
        //public HttpResponseMessage getbyid(int id)
        //{
        //    employee em= emps.Find(n => n.id == id);
        //    if (em == null)
        //        return Request.CreateResponse(HttpStatusCode.NotFound);
        //    else
        //        return Request.CreateResponse(HttpStatusCode.OK, em);
        //}
        //webapi 2
        public IHttpActionResult getbyid(int id)
        {
            employee em = emps.Find(n => n.id == id);
            if (em == null)
                return NotFound();
            else
                return Ok(em);
        }

        //get by address
        // [Route("api/employees/{address:alpha}")]
        [Route("api/emps/{address}")]
        public IHttpActionResult getbyaddress(string address)
        {
            List<employee> empp= emps.FindAll(n => n.address == address);
            if(empp ==null)
                return NotFound();
            else
                return Ok(empp);
        }


        //add
        [HttpPost]
        public IHttpActionResult addemployee(employee em)
        {
            if (em == null) return BadRequest();

            emps.Add(em);
            return Created("ay7aga", emps);
        }


        //edit

        public List<employee> put([FromUri]int id ,[FromBody] employee em)
        {
            employee e = emps.Find(n => n.id == id);
            e.id = em.id;
            e.name=em.name;
            e.age=em.age;
            e.address=em.address;

            return emps;
        }



        //delete
        public List<employee>delete(int id)
        {
            employee e = emps.Find(n => n.id == id);
            emps.Remove(e);
            return emps;
        }


    }
}
