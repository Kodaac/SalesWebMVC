using System.Linq;
using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _contexto;

        public DepartmentService(SalesWebMvcContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _contexto.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
