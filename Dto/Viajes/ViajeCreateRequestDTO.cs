namespace Integrador.Dto.Viajes
{
    public class ViajeCreateRequestDTO
    {
        public string Dominio { get; set; }
        public string CiudadOrigen { get; set; }
        public string CiudadDestino { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaLlegada { get; set; }
        public int Distancia { get; set; }

    }
}
