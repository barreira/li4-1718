using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Kiddo.Models
{
    public class Requisitador
    {
        [Key]
        public int Id { get; set; }

        //[ForeignKey("ApplicationUserId")]
        //public virtual ApplicationUser ApplicationUser { get; set; }
        //public string ApplicationUserId { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Display(Name = "Contacto telefónico")]
        public string Contact { get; set; }

        [Display(Name = "Dados de pagamento")]
        public string Payment { get; set; }
    }
}