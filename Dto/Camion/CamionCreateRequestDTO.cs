namespace Integrador.Dto.Camion
{
    public class CamionCreateRequestDTO
    {
        public string Dominio { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public string Conductor { get; set; }
        public string NumeroChasis { get; set; }
        public string NumeroMotor { get; set; }

    }
}
