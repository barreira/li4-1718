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

        private string Email { get; set; }
        public string Contact { get; set; }
        public string Payment { get; set; }
    }
}