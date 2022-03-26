using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using tasks.Models;

namespace tasks.Controllers
{
    public class CoursesController : ApiController
    {
        static public List<Course> courses = new List<Course>()
        {
            new Course(){Id = 1, Name ="C#",Duration = 60,Description="intro to .net and c#"},
            new Course(){Id = 2, Name ="SQL",Duration=50,Description="structure query language"},
            new Course(){Id = 3, Name ="ASP.Net",Duration=30,Description="server side programming"},
            new Course(){Id=4, Name ="MVC",Duration=30,Description="server side programming"}
        };
        public IHttpActionResult get()
        {
            if (courses.Any())
                return Ok(courses);
            else return NotFound();
        }

        public IHttpActionResult deleteCourse(int id)
        {
            Course course = courses.Find(C => C.Id==id);
            if (course == null)
                return NotFound();
            else
            {
                courses.Remove(course);
                return Ok(courses);
            }
            
        }

        public IHttpActionResult put(int id,Course course)
        {
            Course Curr = courses.Find(C => C.Id == id);
            if (Curr == null)
                return NotFound();
            else if (id != course.Id || course == null)
                return BadRequest();
            else
            {
                Curr.Name = course.Name;
                Curr.Description = course.Description;
                Curr.Duration = course.Duration;
                return Ok();
            }

        }

        public IHttpActionResult post(Course course)
        {
            if(course==null)
                return BadRequest();
            
            
            courses.Add(course);
            return Created("created",courses);
        }

        public IHttpActionResult getById(int id)
        {
            Course course = courses.Find(C => C.Id == id);
            if (course == null)
                return NotFound();
            return Ok(course);
        }
        
        [HttpGet]
        [Route("api/Courses/name/{name}")]
        public IHttpActionResult courseByName(string name)
        {
            Course course = courses.Find(C => C.Name == name);
            if (course == null)
                return NotFound();
            else return Ok(course);
        }
    }
}
