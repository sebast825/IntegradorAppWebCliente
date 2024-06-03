namespace Integrador.Dto.Viajes
{
    public class ViajeReponseDTO
    {
        public string Dominio { get; set; }
        public string Conductor { get; set; }
        public string CiudadOrigen { get; set; }
        public string CiudadDestino { get; set; }
        public string FechaHoraSalida { get; set; }
        public string FechaHoraLlegada { get; set; }
        public string Distancia { get; set; }
        public decimal DuracionViaje { get; set; }

    }
}


