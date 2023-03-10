using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class SalesRecordService
    {
        private readonly SalesWebMvcContext _context;

        public SalesRecordService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? MinDate, DateTime? MaxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (MinDate.HasValue)
            {
                result = result.Where(x => x.Date >= MinDate.Value);
            }
            if (MaxDate.HasValue)
            {
                result = result.Where(x => x.Date <= MaxDate.Value);
            }
            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
        public async Task<List<IGrouping<Department,SalesRecord>>> FindByDateGroupingAsync(DateTime? MinDate, DateTime? MaxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (MinDate.HasValue)
            {
                result = result.Where(x => x.Date >= MinDate.Value);
            }
            if (MaxDate.HasValue)
            {
                result = result.Where(x => x.Date <= MaxDate.Value);
            }
            var groupedResult = await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .ToListAsync();
            var clientGroupedResult = groupedResult
                .OrderByDescending(x => x.Date)
                .GroupBy(x => x.Seller.Department)
                .AsEnumerable();
            return clientGroupedResult.ToList();
        }
    }
}
