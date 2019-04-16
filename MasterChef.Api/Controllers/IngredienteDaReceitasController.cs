using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MasterChefCore.Contexts;
using MasterChefCore.Models;

namespace MasterChef.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredienteDaReceitasController : ControllerBase
    {
        private readonly MasterChefContext _context;

        public IngredienteDaReceitasController(MasterChefContext context)
        {
            _context = context;
        }

        // GET: api/IngredienteDaReceitas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IngredienteDaReceita>>> GetIngredientesDaReceita()
        {
            return await _context.IngredientesDaReceita.ToListAsync();
        }

        // GET: api/IngredienteDaReceitas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IngredienteDaReceita>> GetIngredienteDaReceita(int id)
        {
            var ingredienteDaReceita = await _context.IngredientesDaReceita.FindAsync(id);

            if (ingredienteDaReceita == null)
            {
                return NotFound();
            }

            return ingredienteDaReceita;
        }

        // PUT: api/IngredienteDaReceitas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIngredienteDaReceita(int id, IngredienteDaReceita ingredienteDaReceita)
        {
            if (id != ingredienteDaReceita.Id)
            {
                return BadRequest();
            }

            _context.Entry(ingredienteDaReceita).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IngredienteDaReceitaExists(id))
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

        // POST: api/IngredienteDaReceitas
        [HttpPost]
        public async Task<ActionResult<IngredienteDaReceita>> PostIngredienteDaReceita(IngredienteDaReceita ingredienteDaReceita)
        {
            _context.IngredientesDaReceita.Add(ingredienteDaReceita);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIngredienteDaReceita", new { id = ingredienteDaReceita.Id }, ingredienteDaReceita);
        }

        // DELETE: api/IngredienteDaReceitas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<IngredienteDaReceita>> DeleteIngredienteDaReceita(int id)
        {
            var ingredienteDaReceita = await _context.IngredientesDaReceita.FindAsync(id);
            if (ingredienteDaReceita == null)
            {
                return NotFound();
            }

            _context.IngredientesDaReceita.Remove(ingredienteDaReceita);
            await _context.SaveChangesAsync();

            return ingredienteDaReceita;
        }

        private bool IngredienteDaReceitaExists(int id)
        {
            return _context.IngredientesDaReceita.Any(e => e.Id == id);
        }
    }
}
