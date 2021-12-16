using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intern.Services;
using Intern.Models;

namespace Intern.Controllers
{
    [ApiController]
    [Route("/")]
    public class CountriesController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPath([FromRoute] string id)
        {
            Country current = CountryService.countries.Find(c => c.Id.Equals("USA"));
            List<string> path = new List<string> { current.Id };
            Country target = CountryService.countries.Find(c => c.Id.Equals(id));

            if (CountryService.countries.Exists(s => s.Id.Equals(id)))
            {
                if (!id.Equals("USA"))
                {
                    while (!current.Id.Equals(target.Id))
                    {
                        if (current.Neighbours.Contains(target.Id))
                        {
                            path.Add(target.Id);
                            current = target;
                        }
                        else if (target.Score > current.Score)
                        {
                            
                            current = CountryService.countries.Where(c => current.Score < c.Score && (c.Score - current.Score > 5)).OrderBy(c => c.Score).First();
                            path.Add(current.Id);
                        }
                    }

                    return Ok(path);

                }
                return NoContent();
            }
            return NoContent();
        }
    }
    
}
