using Integrador.Dal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Integrador.Dal.Data.DataSeed
{
    public class ViajeSeed : IEntityTypeConfiguration<Viaje>
    {
        public void Configure(EntityTypeBuilder<Viaje> builder)
        {
            builder.HasData(new Viaje
            {
                Id = 1,
                IdCamion = 1,
                CiudadDestino = "Buenos Aires",
                CiudadOrigen = "Corrientes",
                kilometraje = 800,
                FechaSalida = new DateTime(2024, 10, 10, 10, 00, 00),
                FechaLLegada = new DateTime(2024, 10, 10, 22, 00, 00),


            }, new Viaje
            {
                Id = 2,
                IdCamion = 2,
                CiudadDestino = "Mendoza",
                CiudadOrigen = "Buenos Aires",
                kilometraje = 1050,
                FechaSalida = new DateTime(2023, 09, 15, 09, 35, 00),
                FechaLLegada = new DateTime(2023, 09, 16, 10, 30, 00),


            }, new Viaje
            {
                Id = 3,
                IdCamion = 3,
                CiudadDestino = "Buenos Aires",
                CiudadOrigen = "Salta",
                kilometraje = 1500,
                FechaSalida = new DateTime(2021, 02, 02, 10, 00, 00),
                FechaLLegada = new DateTime(2021, 02, 04, 22, 30, 00),


            });
        }
    }
}




