using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Vehicle_Rental_management.DAL.API;
using Online_Vehicle_Rental_management.Entities.API;

namespace Online_Vehicle_Rental_management.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Booking_DetailsAPIController : ControllerBase
    {
        private readonly OVRMDbContext _context;

        public Booking_DetailsAPIController(OVRMDbContext context)
        {
            _context = context;
        }

        // GET: api/Booking_DetailsAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Booking_Details>>> GetBooking_Details()
        {
            return await _context.Booking_Details.ToListAsync();
        }

        // GET: api/Booking_DetailsAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Booking_Details>> GetBooking_Details(int id)
        {
            var booking_Details = await _context.Booking_Details.FindAsync(id);

            if (booking_Details == null)
            {
                return NotFound();
            }

            return booking_Details;
        }

        // PUT: api/Booking_DetailsAPI/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooking_Details(int id, Booking_Details booking_Details)
        {
            if (id != booking_Details.Booking_id)
            {
                return BadRequest();
            }

            _context.Entry(booking_Details).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Booking_DetailsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Booking_DetailsAPI
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Booking_Details>> PostBooking_Details(Booking_Details booking_Details)
        {
            _context.Booking_Details.Add(booking_Details);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Booking_DetailsExists(booking_Details.Booking_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBooking_Details", new { id = booking_Details.Booking_id }, booking_Details);
        }

        // DELETE: api/Booking_DetailsAPI/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Booking_Details>> DeleteBooking_Details(int id)
        {
            var booking_Details = await _context.Booking_Details.FindAsync(id);
            if (booking_Details == null)
            {
                return NotFound();
            }

            _context.Booking_Details.Remove(booking_Details);
            await _context.SaveChangesAsync();

            return booking_Details;
        }

        private bool Booking_DetailsExists(int id)
        {
            return _context.Booking_Details.Any(e => e.Booking_id == id);
        }
    }
}
