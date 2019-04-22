using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using dotnetangular.Controllers.Resources;
using dotnetangular.Models;
using dotnetangular.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnetangular.Controllers
{
    public class MakeController : Controller
    {

        private readonly MyDbContext context;
        private readonly IMapper mapper;
        public MakeController(MyDbContext ctx,IMapper mapper)
        {
            this.context = ctx;
            this.mapper = mapper;
        }
        [HttpGet("api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMake(){
            var makes = await context.Makes.Include(m=>m.Models).ToListAsync();
            return mapper.Map<List<Make>,List<MakeResource>>(makes);
        }
    }
}