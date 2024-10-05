namespace MELIPARCIAL.Models
{
    public class Remesa
    {
        public int Id { get; set; } 
        public string NombreRemitente { get; set; } 
        public string NombreDestinatario { get; set; } 
        public string PaisOrigen { get; set; } 
        public string PaisDestino { get; set; } 
        public decimal MontoEnviado { get; set; } // Monto enviado en USD o BTC
        public string Moneda { get; set; } // Moneda ("USD" o "BTC")
        public decimal TasaCambio { get; set; } 
        public decimal MontoFinal { get; set; } 
        public string EstadoTransaccion { get; set; } // Estado de la transacción (e.g., "Completada", "Pendiente")
    }
}
