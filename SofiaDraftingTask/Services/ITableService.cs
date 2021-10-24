using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SofiaDraftingTask.Services.Models;

namespace SofiaDraftingTask.Services
{
    public interface ITableService
    {
        public Task<IEnumerable<PersonServiceModel>> GetPeople();
    }
}
