using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Movies.Models;

namespace Movies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private MovieContext _context;
        public MovieController(MovieContext context)
        {
            this._context = context;
        }

        //GET:api/User
        [HttpGet(Name = "Get All")]
        public ActionResult<IEnumerable<MovieItem>> GetMovieItem()
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            //return new string[]
            return _context.GetAllMovie();
        }

        //Get:api/user/{id}
        [HttpGet("{id}", Name = "Get where")]
        public ActionResult<IEnumerable<MovieItem>> GetMovieItem(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.GetMovie(id);
        }

        //Post api 
        [HttpPost]
        public ActionResult<IEnumerable<MovieItem>> PostMovieItem(string name, string genre, string duration, DateTime releasedate)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.PostMovie(name, genre, duration, releasedate);
        }

        //Put api
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<MovieItem>> PutMovieItem(string id, string name, string genre, string duration, DateTime releasedate)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.PutMovie(id, name, genre, duration, releasedate);
        }

        //Delete api
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<MovieItem>> DeleteMovieItem(string id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.DeleteMovie(id);
        }
    }
}
