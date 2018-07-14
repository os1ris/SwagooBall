using System;
using System.Collections.Generic;
using System.Linq;
using Swagoos.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Swagoos.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public SwagooRule Get()
        {
            return new SwagooRule
            {
                Difficulty = 0,
                Id = new Guid(),
                LoserGets = "",
                WinnerGets = "",
                RuleExplanation = "",
                RuleName = "",
                RuleTypes = new RuleType
                {
                    EasyRule = false,
                    GroupDrink = false,
                    HardRule = false,
                    MediumRule = false,
                    OkAtBar = false,
                    OkInPublic = false,
                    PropBased = false,
                    SoloDrink = false,
                    TeamBased = false
                }
            };
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
