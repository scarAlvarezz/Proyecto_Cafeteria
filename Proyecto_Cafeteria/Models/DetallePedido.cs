namespace CafeteriaWeb.Models
{
    public class DetallePedido
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public Pedido? Pedido { get; set; }
        public int PlatilloApiId { get; set; }
        public string NombrePlatillo { get; set; } = "";
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}