using CampusShuttleAPI.Data;
using CampusShuttleAPI.Model;
using CampusShuttleAPI.Model.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace CampusShuttleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BookingController(AppDbContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> PostBooking([FromBody] BookingDTO bookingDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userEmail = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var user = await _context.Users.Where(e => e.Email == userEmail).FirstOrDefaultAsync();

            if (user == null)
            {
                return BadRequest(ModelState);
            }

            var userId = user.Id;

            var booking = new Booking
            {
                Userid = user.Id,
                Day = bookingDTO.Day,
                Time = bookingDTO.Time, 
                Direction = bookingDTO.Direction,
            };

            await _context.Bookings.AddAsync(booking);
            await _context.SaveChangesAsync();
        
              return Ok(booking);
        }


    }
}
