using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Kiddo.Models
{
    public class Babysitter
    {
        [Key]
        public int Id { get; set; }
        //[ForeignKey("ApplicationUserId")]
        //public virtual ApplicationUser ApplicationUser { get; set; }
        //public string ApplicationUserId { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Idade")]
        public int Age { get; set; }

        [Display(Name = "Foto")]
        public string Photo { get; set; }

        [Display(Name = "Localização")]
        public string City { get; set; }

        [Display(Name = "Preço/hora")]
        public decimal PricePerHour { get; set; }
    }
}