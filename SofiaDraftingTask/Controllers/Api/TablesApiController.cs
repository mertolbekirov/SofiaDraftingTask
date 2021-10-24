using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SofiaDraftingTask.Services;
using SofiaDraftingTask.Services.Models;

namespace SofiaDraftingTask.Controllers.Api
{
    [ApiController]
    public class TablesApiController : ControllerBase
    {
        private readonly ITableService tables;

        public TablesApiController(ITableService tables)
            => this.tables = tables;

        [HttpGet]
        [Route("api/GetPeople")]
        public async Task<IEnumerable<PersonServiceModel>> AllPeople()
        {
            var people = await this.tables.GetPeople();
            return people.OrderBy(x => x.Name);
        }
    }
}
