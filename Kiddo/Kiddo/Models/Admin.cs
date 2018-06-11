using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kiddo.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }
    }
}