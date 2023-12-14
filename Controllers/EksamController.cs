using Jalgrattaeksam.Data;
using Jalgrattaeksam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Jalgrattaeksam.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EksamController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public EksamController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Eksam> GetEksams()
        {
            var eksams = _context.Eksam.ToList();
            return eksams;
        }

        [HttpPost("lisa/")]
        public ActionResult<List<Eksam>> PostEksam([FromBody] Eksam eksams)
        {
            _context.Eksam.Add(eksams);
            _context.SaveChanges();

            return Ok(_context.Eksam);
        }

        [HttpDelete("kustuta/{id}")]
        public List<Eksam> DeleteEksam(int id)
        {
            var Eksam = _context.Eksam.Find(id);

            if (Eksam == null)
            {
                return _context.Eksam.ToList();
            }

            _context.Eksam.Remove(Eksam);
            _context.SaveChanges();
            return _context.Eksam.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Eksam> GetEksam(int id)
        {
            var Eksam = _context.Eksam.Find(id);

            if (Eksam == null)
            {
                return NotFound();
            }

            return Eksam;
        }

        [HttpPut("muuda/{id}")]
        public ActionResult<List<Eksam>> PutEksam(int id, [FromBody] Eksam updatedEksam)
        {
            var eksam = _context.Eksam.Find(id);

            if (eksam == null)
            {
                return NotFound();
            }

            eksam.Koha = updatedEksam.Koha;
            eksam.Eksamineerija = updatedEksam.Eksamineerija;

            _context.Eksam.Update(eksam);
            _context.SaveChanges();

            return Ok(_context.Eksam.ToList());
        }
    }
}
