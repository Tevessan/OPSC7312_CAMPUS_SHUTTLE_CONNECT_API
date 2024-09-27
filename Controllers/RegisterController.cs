using Azure.Core;
using CampusShuttleAPI.Data;
using CampusShuttleAPI.Migrations;
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
    public class RegisterController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public RegisterController(AppDbContext AppDbContext)
        {
            _appDbContext = AppDbContext;   
        }

        [Authorize]
        [HttpPost]
       public async Task<IActionResult> RegisterForShuttle([FromBody] RegisterShuttleDTO model)
       {
            if (!ModelState.IsValid) { 
                return BadRequest(ModelState);  
            }

            var userEmail = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var user = await _appDbContext.Users.Where(e => e.Email == userEmail).FirstOrDefaultAsync();

            if (user == null)
            {
                return BadRequest(ModelState);  
            }

            var userId = user.Id;


            var registerShuttel = new RegisterShuttle
            {
                  ShuttleId = model.ShuttleId,  
                    UserId = userId         
            };

            await _appDbContext.RegisterShuttles.AddAsync(registerShuttel); 
            await _appDbContext.SaveChangesAsync(); 

            return Ok("Register Sucessfully.");    
       }
    }
}
