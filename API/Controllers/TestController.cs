using API.Data;
using API.DTOs;
using API.Entities;
using AutoMapper;
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
        private readonly IMapper _mapper;

        public TestController(DataContext context, IConfiguration config, IMapper mapper)
        {
            _context = context;
            _config = config;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<string>> GetSecret()
        {
            return _config["TokenKey"];
        }


    }
}
