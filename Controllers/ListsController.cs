using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TwoListAPI.Models;
using twolistapi;

namespace dotnet_sdg_template.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ListController : ControllerBase
  {
    private DatabaseContext _context;

    public ListController()
    {
      this._context = new DatabaseContext();
    }

    // GET: api/List
    [HttpGet]
    public async Task<ActionResult<IEnumerable<List>>> GetLists()
    {
      return await _context.Lists.ToListAsync();
    }

    // GET: api/List/5
    [HttpGet("{id}")]
    public async Task<ActionResult<List>> GetList(int id)
    {
      var list = await _context.Lists.FindAsync(id);

      if (list == null)
      {
        return NotFound();
      }

      return list;
    }

    // PUT: api/List/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutList(int id, List list)
    {
      if (id != list.Id)
      {
        return BadRequest();
      }

      _context.Entry(list).State = EntityState.Modified;

      try
      {
        await _context.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ListExists(id))
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

    // POST: api/List
    [HttpPost]
    public async Task<ActionResult<List>> PostList(List list)
    {
      _context.Lists.Add(list);
      await _context.SaveChangesAsync();

      return CreatedAtAction("GetList", new { id = list.Id }, list);
    }

    // DELETE: api/List/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<List>> DeleteList(int id)
    {
      var list = await _context.Lists.FindAsync(id);
      if (list == null)
      {
        return NotFound();
      }

      _context.Lists.Remove(list);
      await _context.SaveChangesAsync();

      return list;
    }

    private bool ListExists(int id)
    {
      return _context.Lists.Any(e => e.Id == id);
    }
  }
}
