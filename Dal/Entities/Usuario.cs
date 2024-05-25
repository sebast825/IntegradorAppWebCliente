using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Integrador.Dal.Entities
{
    public class Usuario : ClaseBase
    { 
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

    }
}
