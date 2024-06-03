using System.Text.Json.Serialization;

namespace Integrador.Dal.Entities
{
    public class Camion : ClaseBase
    {
        public string Dominio { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Conductor { get; set; }
        public int Anio { get; set; }
        public string NumeroChasis { get; set; }
        public string NumeroMotor { get; set; }
        [JsonIgnore]
        public List<Viaje> Viajes { get;set; }
    }
}
