using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        //estrutura de dependencia com o _context do EF
        private readonly SalesWebMvcContext _context;
        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
