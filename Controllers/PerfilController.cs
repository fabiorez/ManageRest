using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ManageRest.Data;
using ManageRest.Models;

namespace ManageRest.Controllers
{
    public class PerfilController : ControllerBase
    {
        private readonly ManageDataContext _context;

        public PerfilController(ManageDataContext context)
        {
            _context = context;
        }

        [Route("v1/perfis")]
        [HttpGet]
        public ActionResult<IEnumerable<Perfil>> Get()
        {
            return _context.Perfis.AsNoTracking().ToList();
        }

        [Route("v1/perfis/{id}")]
        [HttpGet]
        public ActionResult<Perfil> Get(int id)
        {
            return _context.Perfis.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        [Route("v1/perfis/{id}/operadores")]
        [HttpGet]
        public ActionResult<IEnumerable<Operador>> GetOperadores(int id)
        {
            return _context.Operadores.AsNoTracking().Where(x => x.PerfilId == id).ToList();
        }

        [Route("v1/perfis")]
        [HttpPost]
        public ActionResult<Perfil> Post([FromBody]Perfil perfil)
        {
            _context.Perfis.Add(perfil);
            _context.SaveChanges();

            return CreatedAtAction("Get", new { id = perfil.Id }, perfil);
        }

        [Route("v1/perfis")]
        [HttpPut]
        public Perfil Put([FromBody]Perfil perfil)
        {
            _context.Entry<Perfil>(perfil).State = EntityState.Modified;
            _context.SaveChanges();

            return perfil;
        }

        [Route("v1/perfis")]
        [HttpDelete]
        public ActionResult<Perfil> Delete([FromBody]Perfil perfil)
        {
            _context.Perfis.Remove(perfil);
            _context.SaveChanges();

            return perfil;
        }
    }
}