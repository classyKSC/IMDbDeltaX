using IMDbDeltaX.Models;
using IMDbDeltaX.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IMDbDeltaX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IMDbAPIController : ControllerBase
    {
        private IDeltaXRepository _repository;

        public IMDbAPIController(IDeltaXRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<IMDbAPIController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<IMDbAPIController>/lucy
        [HttpGet("{name}")]
        public ActionResult<Movie> Get(string name)
        {
            var movie = _repository.GetMovieFromName(name);
            return Ok(movie);
        }

        // POST api/<IMDbAPIController>
        [HttpPost]
        public async Task<ActionResult<string>> CreateMovie([FromBody] Movie movie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Ok(_repository.CreateMovie(movie).Result);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return new NoContentResult();
            }
        }

        // PUT api/<IMDbAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<IMDbAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
