using CalculatorAPI.Entity;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [Route("api/calculator")]
    public class CalculatorController : ControllerBase
    {
        private readonly CalculatorDbContext _dbContext;

        public CalculatorController(CalculatorDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("wallstructure")]
        public ActionResult<IEnumerable<StructureWall>> GetWallStructure()
        {
            var structureWall = _dbContext.StructureWalls.ToList();
            return Ok(structureWall);
        }

        [HttpGet("wallinsulation")]

        public ActionResult<IEnumerable<StructureWall>> GetWallInsulation()
        {
            var structureWall = _dbContext.InsulationWalls.ToList();
            return Ok(structureWall);
        }

        [HttpGet("wallexteriorfinishing")]
        public ActionResult<IEnumerable<StructureWall>> GetWallExteriorFinishing()
        {
            var structureWall = _dbContext.FinishingExteriorWalls.ToList();
            return Ok(structureWall);
        }

    }
}
