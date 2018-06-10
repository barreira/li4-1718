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

        public string Email { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Photo { get; set; }
        public string City { get; set; }
        public decimal PricePerHour { get; set; }
    }
}