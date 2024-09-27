using CampusShuttleAPI.Data;
using CampusShuttleAPI.Model;
using CampusShuttleAPI.Model.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace CampusShuttleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShuttleController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public ShuttleController(AppDbContext AppDbContext)
        {
            _appDbContext = AppDbContext;   
        }

        [HttpPost]
        public async Task<IActionResult> AddShuttle([FromBody] ShuttleDTO model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var shuttle = new Shuttle
            {
                DepartureTime = model.DepartureTime,
                Destination = model.Destination,
            };

            await _appDbContext.Shuttles.AddAsync(shuttle);
            await _appDbContext.SaveChangesAsync();

            return Ok(shuttle);
        }

        [HttpGet]
        public async Task<IActionResult> GetShuttle()
        {
            var allshuttle = await _appDbContext.Shuttles.ToListAsync();
            return Ok(allshuttle);
        }




    }
}
