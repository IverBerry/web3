namespace web3.Models
{
    public class Reporte
    {
        public string? Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Descripcion { get; set; } = string.Empty;
        public int VehiculosInvolucrados { get; set; }
        public int Muertos { get; set; }
        public int Heridos { get; set; }
        public decimal CostoEstimado { get; set; }
    }
}




