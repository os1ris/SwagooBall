using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swagoos.Models;

namespace Swagoos.Controllers
{
    public class RulesController : Controller
    {
        public SwagooRule GetSwagooRule()
        {
            return new SwagooRule();
        }
    }
}