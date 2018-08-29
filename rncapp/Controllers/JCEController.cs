using Microsoft.AspNetCore.Mvc;
using rncapp.Repository;
using System.Collections.Generic;

namespace rncapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JCEController : ControllerBase
    {
        private readonly FileRepository _repo;

        public JCEController()
        {
            _repo = new FileRepository();
        }

        // GET: api/JCE
        [HttpGet]
        public List<Persona> Get()
        {
            return _repo.GetPersonas();
        }

        // GET: api/JCE/5
        [HttpGet("{rnc}", Name = "Get")]
        public Persona Get(string rnc)
        {
            return _repo.GetPersona(rnc);
        }
    }
}