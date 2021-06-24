using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using TestJustForTest.Contracts;
using TestJustForTest.Entities;

namespace TestJustForTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IPieceRepository _repository;
        private readonly ILogger<ValuesController> _logger;

        public ValuesController(IPieceRepository repository, ILogger<ValuesController> logger)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        // GET api/values
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Piece>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Piece>>> Get()
        {
            var pieces = await _repository.GetPieces();
            return Ok(pieces);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
