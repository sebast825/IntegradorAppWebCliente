using Integrador.Dal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Integrador.Dal.Data.DataSeed
{
    public class CamionSeed : IEntityTypeConfiguration<Camion>
    {
        public void Configure(EntityTypeBuilder<Camion> builder)
        {
            builder.HasData(new Camion
            {
                Id = 1,
                Anio = 2000,
                Conductor = "Rossi Leonardo",
                Dominio = "AAA111",
                Marca = "Scania",
                Modelo = "P310",
                NumeroChasis = "12345645",
                NumeroMotor = "9685741"

            },
            new Camion
            {
                Id = 2,
                Anio = 2024,
                Conductor = "Martinez Carlos",
                Dominio = "AA1251BC",
                Marca = "Scania",
                Modelo = "P420",
                NumeroChasis = "9124584",
                NumeroMotor = "987452"
            },
            new Camion
            {
                Id = 3,
                Anio = 2005,
                Conductor = "German Rios",
                Dominio = "BBB123",
                Marca = "Ford",
                Modelo = "F7000",
                NumeroChasis = "963258",
                NumeroMotor = "753159"
            });
        }
    }
}





