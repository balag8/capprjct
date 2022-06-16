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
    public class Active_BookingAPIController : ControllerBase
    {
        private readonly OVRMDbContext _context;

        public Active_BookingAPIController(OVRMDbContext context)
        {
            _context = context;
        }

        // GET: api/Active_BookingAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Active_Booking>>> GetActive_Bookings()
        {
            return await _context.Active_Bookings.ToListAsync();
        }

        // GET: api/Active_BookingAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Active_Booking>> GetActive_Booking(int id)
        {
            var active_Booking = await _context.Active_Bookings.FindAsync(id);

            if (active_Booking == null)
            {
                return NotFound();
            }

            return active_Booking;
        }

        // PUT: api/Active_BookingAPI/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActive_Booking(int id, Active_Booking active_Booking)
        {
            if (id != active_Booking.Booking_id)
            {
                return BadRequest();
            }

            _context.Entry(active_Booking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Active_BookingExists(id))
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

        // POST: api/Active_BookingAPI
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Active_Booking>> PostActive_Booking(Active_Booking active_Booking)
        {
            _context.Active_Bookings.Add(active_Booking);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Active_BookingExists(active_Booking.Booking_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetActive_Booking", new { id = active_Booking.Booking_id }, active_Booking);
        }

        // DELETE: api/Active_BookingAPI/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Active_Booking>> DeleteActive_Booking(int id)
        {
            var active_Booking = await _context.Active_Bookings.FindAsync(id);
            if (active_Booking == null)
            {
                return NotFound();
            }

            _context.Active_Bookings.Remove(active_Booking);
            await _context.SaveChangesAsync();

            return active_Booking;
        }

        private bool Active_BookingExists(int id)
        {
            return _context.Active_Bookings.Any(e => e.Booking_id == id);
        }
    }
}
