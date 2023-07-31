using App.Data;
using App.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PersonaController : ControllerBase
{

    private readonly ApplicationDbContext _context;

    public PersonaController(ApplicationDbContext context)
    {
        _context = context;
    }




    [HttpGet]
    public async Task<ActionResult<List<Persona>>> GetPersonas (){

       
        var personas = await _context.Personas.Include(p=> p.Direccion).ToListAsync();
        if (personas == null)
        {
            personas = new List<Persona>();
            return personas;
        }
        return personas;

    }
}
