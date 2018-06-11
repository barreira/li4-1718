using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Kiddo.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        public int RequisitadorId { get; set; }
        [ForeignKey("RequisitadorId")]
        public virtual Requisitador Requisitador { get; set; }

        public int BabysitterId { get; set; }
        [ForeignKey("BabysitterId")]
        public virtual Babysitter Babysitter { get; set; }

        [Required]
        [Display(Name = "Data")]
        public DateTime date { get; set; }

        [Required]
        [Display(Name = "Duração")]
        public int duration { get; set; }

        [Required]
        [Display(Name = "Morada")]
        public string location { get; set; }

        [Required]
        [Display(Name = "Número de crianças")]
        public int numberChildren { get; set; }

        [Display(Name = "Informação extra")]
        public string extra { get; set; }
    }
}