using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MusicHistory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicHistory.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [EnableCors("AllowDevelopmentEnvironment")]

    public class TrackController : Controller
    {
        private MusicHistoryContext _context;

        public TrackController(MusicHistoryContext context)
        {
            _context = context;
        }

        //GET: api/mytracks
        // without passing any arguments through the Get method,
        // you will get everything back. If you limit it with [FromQuery]
        // arguments you will only be able to use that data.

        [HttpGet]
        public IActionResult Get()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IQueryable<Track> favorites = from t in _context.Track
                                          select t;
                                     
            

            return Ok(favorites);
        }




    }
}
