using CalculatorAPI.Entity;

namespace CalculatorAPI
{
    public class CalculatorSeeder
    {
        private CalculatorDbContext _dbContext;

        public CalculatorSeeder(CalculatorDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.InsulationCeiling.Any())
                {
                    var insulationCeiling = GetCeilingInsulation();
                    _dbContext.InsulationCeiling.AddRange(insulationCeiling);
                    _dbContext.SaveChanges();
                }
                if (!_dbContext.InsulationFoundation.Any())
                {
                    var insulationFoundation = GetFoundationInsulation();
                    _dbContext.InsulationFoundation.AddRange(insulationFoundation);
                    _dbContext.SaveChanges();
                }
                if (!_dbContext.InsulationWalls.Any())
                {
                    var insulationWall = GetWallInsulation();
                    _dbContext.InsulationWalls.AddRange(insulationWall);
                    _dbContext.SaveChanges();
                }
                if (!_dbContext.StructureWalls.Any())
                {
                    var structureWall = GetWallStructure();
                    _dbContext.StructureWalls.AddRange(structureWall);
                    _dbContext.SaveChanges();
                }
                if (!_dbContext.FinishingExteriorWalls.Any())
                {
                    var finsihingExteriorWall = GetExteriorWallFinishing();
                    _dbContext.FinishingExteriorWalls.AddRange(finsihingExteriorWall);
                    _dbContext.SaveChanges();
                }
                if (!_dbContext.FinishingInteriorWalls.Any())
                {
                    var finsihingInteriorWall = GetInteriorWallsFinishing();
                    _dbContext.FinishingInteriorWalls.AddRange(finsihingInteriorWall);
                    _dbContext.SaveChanges();
                }
            }
        }
        private IEnumerable<InsulationCeiling> GetCeilingInsulation()
        {
            var insulationCeiling = new List<InsulationCeiling>() {
                new InsulationCeiling()
                {
                    Name = "Styropian EPS 100 031",
                    Lambda = 0.031M,
                },
                new InsulationCeiling()
                {
                    Name = "Styropian EPS 100 036",
                    Lambda = 0.036M,
                }
            };
            return insulationCeiling;
        }
        private IEnumerable<InsulationFoundation> GetFoundationInsulation()
        {
            var insulationFundation = new List<InsulationFoundation>()
            {
                new InsulationFoundation()
                {
                    Name = "Styropian XPS 100 031",
                    Lambda = 0.031M,
                }
            };
            return insulationFundation;
        }
        private IEnumerable<InsulationWall> GetWallInsulation()
        {
            var insulationWall = new List<InsulationWall>()
            {
                new InsulationWall()
                {
                    Name = "Styropian EPS 80 031",
                    Lambda = 0.031M,
                }
            };
            return insulationWall;
        }
        private IEnumerable<StructureWall> GetWallStructure()
        {
            var structureWall = new List<StructureWall>()
            {
                new StructureWall()
                {
                    Name = "Silka E15",
                    Lambda = 0.50M,
                    Thicness = 15,
                },
                new StructureWall()
                {
                    Name = "Porotherm 25 P+W",
                    Lambda = 0.316M,
                    Thicness = 25,
                }

            };
            return structureWall;
        }
        private IEnumerable<FinishingExteriorWall> GetExteriorWallFinishing()
        {
            var finishingExteriorWall = new List<FinishingExteriorWall>()
            {
                new FinishingExteriorWall()
                {
                    Name = "Tynk mineralny",
                    Lambda = 0.8M,
                }
            };
            return finishingExteriorWall;
        }
        private IEnumerable<FinishingInteriorWall> GetInteriorWallsFinishing()
        {
            var finishingInteriorWall = new List<FinishingInteriorWall>()
            {
                new FinishingInteriorWall()
                {
                    Name = "Tynk cementowo-wapienny",
                    Lambda = 0.82M,
                }
            };
            return finishingInteriorWall;
        }   
    }
}


