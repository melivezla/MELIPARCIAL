namespace MELIPARCIAL.Models
{
    public class ConversionHistorial
    {
        public int Id { get; set; } 
        public decimal MontoOriginal { get; set; } 
        public string MonedaOriginal { get; set; } // Moneda original (e.g., "USD" o "BTC")
        public decimal MontoConvertido { get; set; } 
        public string MonedaConvertida { get; set; } 
        public decimal TasaCambio { get; set; } 
        public DateTime FechaConversion { get; set; } 
    }
}
