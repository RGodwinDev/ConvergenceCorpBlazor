using ConvergenceCorpBlazor.Classes.Model;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;
using System.Collections;

namespace ConvergenceCorpBlazor.Classes.API
{
    [ApiController]
    [Route("/api/groups")]
    public class GroupController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(Groups.getAllGroupIDs());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetGroup(int id)
        {
            Group? g = Groups.getGroupbyID(id);

            if (g == null)
            {
                return BadRequest("Bad Request: No Group was found with id: " + id);
            }

            JsonObject o = new JsonObject();
            o.Add("id", g.Id);
            o.Add("logo", g.Logo); 
            o.Add("name", g.Name);
            o.Add("tag", g.GuildTag);
            
            //if we dont do this, the links don't show up
            if (g.Links != null)
            {
                JsonObject l = new JsonObject();
                int i = 0;
                foreach (var link in g.Links)
                {
                    i++;
                    l.Add("link"+i, link.Item1);
                    l.Add("linktype"+i, link.Item2);
                }

                o.Add("links", l);
            }
            return Ok(o);
        }
    }
}
