namespace CalculatorAPI.Models
{
    public class EnvelopeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal ValuU { get; set; }
        public List<MaterialDto> Materials { get; set; }
    }
}
