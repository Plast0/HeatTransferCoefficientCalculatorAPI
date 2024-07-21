namespace CalculatorAPI.Entity
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Lambda { get; set; }
        public int Thicness { get; set; }
        public int EnvelopeId { get; set; }
        public virtual Envelope Envelope { get; set; }
    }

}
