using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kiddo.Models
{
    public class Requisitador
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nome { get; set; }
        public string Foto { get; set; }
        public string Localizacao { get; set; }
        public string Contacto { get; set; }
        public string Pagamento { get; set; }
    }
}
