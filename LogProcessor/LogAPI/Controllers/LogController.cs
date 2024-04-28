using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LogAPI.Controllers
{
    [Route("api/v1/[Controllers]")]
    [ApiController]


    public class LogController : Controller
    {
        SQL _sql;
        public LogController(SQL sql)
        {
           this._sql = sql;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll() 
        {
            try
            {
                return Ok(this._sql.LogEntries);
            }
            catch (Exception ex) 
            {
            return BadRequest($"Hiba: {ex.Message}");
            }
        }

        [HttpGet("Get")]
        public IActionResult Get(int id) 
        {
            if(this._sql.LogEntries.Any(a => a.Id == id))
            {
                return Ok(this._sql.LogEntries.Single(a => a.Id == id));
            }
            return BadRequest("Nincs ilyen osztály az adatbázisban");
        }

        [HttpPut("Add")]
        public async Task<IActionResult> Add([FromBody] LogEntry logentry)
        {
            try
            {
                if(!this._sql.LogEntries.Any(a => a.Id == logentry.Id))
                {
                    var t = this._sql.LogEntries.Add(logentry);
                    await this._sql.SaveChangesAsync();
                    return Ok();
                }
                else
                {
                    return BadRequest("A megadott id már használatban van!");
                }
            }
            catch (OverflowException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("SearchLogEntry")]
        public IActionResult SearchLogEntry(string searchText)
        {
            try
            {
                var result = this._sql.LogEntries.Where(log =>
                    log.DataUtc.ToString().Contains(searchText) ||
                    log.Message.Contains(searchText) ||
                    log.Level.Contains(searchText) ||
                    log.Exception.Contains(searchText)
                ).ToList();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Hiba: {ex.Message}");
            }
        }
    }
}