namespace CalculatorAPI.Entity
{
    public class Envelope
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal ValuU { get; set; }
        public int UserID { get; set; }
        public virtual User? User { get; set; }
        public virtual List<Material>? Materials { get; set; }
    }
}
