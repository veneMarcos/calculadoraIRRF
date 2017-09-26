using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IRRF.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace calcNova.Controllers
{
	[Route("api/[controller]")]
	public class IRRFController : Controller
    {
        private readonly IIRRFService _irrfService;

        public IRRFController(IIRRFService irrfService)
        {
            _irrfService = irrfService;
        }

        // GET api/values
        [HttpGet]
		public double Get(double salario)
		{
			return _irrfService.CalculaImposto(salario);
		}
    }
}
