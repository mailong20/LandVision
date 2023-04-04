using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LandVisionAPI.Data;

namespace LandVisionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeUsersController : ControllerBase
    {
        private readonly LandvisionContext _context;

        public TypeUsersController(LandvisionContext context)
        {
            _context = context;
        }

        // GET: api/TypeUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TypeUser>>> GetTypeUsers()
        {
          if (_context.TypeUsers == null)
          {
              return NotFound();
          }
            return await _context.TypeUsers.ToListAsync();
        }

        // GET: api/TypeUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TypeUser>> GetTypeUser(int id)
        {
          if (_context.TypeUsers == null)
          {
              return NotFound();
          }
            var typeUser = await _context.TypeUsers.FindAsync(id);

            if (typeUser == null)
            {
                return NotFound();
            }

            return typeUser;
        }

        // PUT: api/TypeUsers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTypeUser(int id, TypeUser typeUser)
        {
            if (id != typeUser.TypeUserId)
            {
                return BadRequest();
            }

            _context.Entry(typeUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeUserExists(id))
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

        // POST: api/TypeUsers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TypeUser>> PostTypeUser(TypeUser typeUser)
        {
          if (_context.TypeUsers == null)
          {
              return Problem("Entity set 'LandvisionContext.TypeUsers'  is null.");
          }
            _context.TypeUsers.Add(typeUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTypeUser", new { id = typeUser.TypeUserId }, typeUser);
        }

        // DELETE: api/TypeUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTypeUser(int id)
        {
            if (_context.TypeUsers == null)
            {
                return NotFound();
            }
            var typeUser = await _context.TypeUsers.FindAsync(id);
            if (typeUser == null)
            {
                return NotFound();
            }

            _context.TypeUsers.Remove(typeUser);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TypeUserExists(int id)
        {
            return (_context.TypeUsers?.Any(e => e.TypeUserId == id)).GetValueOrDefault();
        }
    }
}
