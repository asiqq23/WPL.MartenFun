namespace WPL.MartenFun.Controllers
{
    using System;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    public class HealthController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("I'm alive");
        }

        [HttpGet]
        [Route("Error")]
        public IActionResult Error()
        {
            throw new Exception("Can you see me?");
        }
    }
}