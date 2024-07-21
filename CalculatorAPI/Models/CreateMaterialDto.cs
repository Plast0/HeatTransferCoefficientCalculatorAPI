namespace CalculatorAPI.Models
{
    public class CreateMaterialDto
    {
        public string Name { get; set; }
        public decimal Lambda { get; set; }
        public int Thicness { get; set; }
        public int EnvelopeId { get; set; }
    }
}
