using CalculatorAPI.Entity;
using Microsoft.EntityFrameworkCore;

namespace CalculatorAPI.Services
{
    public class CalculatorService
    {
        private readonly CalculatorDbContext _dbContext;
        public CalculatorService(CalculatorDbContext dbContext) 
        {
               _dbContext = dbContext;
        }
        public IEnumerable<StructureWall> GetAll()
        {
            var structureWall = _dbContext.StructureWalls.ToList();
            return structureWall;
        }
    }
}
