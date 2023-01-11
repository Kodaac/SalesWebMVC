using System.Linq;
using SalesWebMvc.Models;
using System.Collections.Generic;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _contexto;

        public DepartmentService(SalesWebMvcContext contexto)
        {
            _contexto = contexto;
        }

        public List<Department> FindAll()
        {
            return _contexto.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
