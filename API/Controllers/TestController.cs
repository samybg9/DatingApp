using API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class TestController : BaseApiController
    {
        private readonly DataContext _context;
        private readonly IConfiguration _config;

        public TestController(DataContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<string>> GetSecret()
        {
            return _config["TokenKey"];
        }

    }
}
