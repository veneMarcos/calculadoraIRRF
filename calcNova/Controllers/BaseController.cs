using FluentValidator;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace calcNova.Controllers
{
    public class BaseController : Controller
    {
        public async Task<IActionResult> Response(object result, IEnumerable<Notification> notifications)
        {
            if (!notifications.Any())
            {
                return Ok(new
                {
                    sucess = true,
                    data = result
                });
            }
            else 
            {
                return BadRequest(new
                {
                    sucess = false,
                    data = notifications
                });
            }
        }
    }
}
