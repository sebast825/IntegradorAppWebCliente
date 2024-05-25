using System.ComponentModel.DataAnnotations.Schema;

namespace Integrador.Dal.Entities
{
    public class Viaje :ClaseBase
    {
        [ForeignKey(nameof(Camion))]
        public int IdCamion { get; set; }
        public Camion Camion { get; set; }
        public string  CiudadOrigen { get; set; }
        public string  CiudadDestino { get; set; }
        public decimal kilometraje { get; set; }
        public DateTime FechaSalida { get; set; }
            public DateTime FechaLLegada { get; set; }
    }
}
