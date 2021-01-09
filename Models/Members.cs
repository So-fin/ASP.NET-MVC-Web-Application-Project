using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCWebApp.Models
{
    [Table("User")]
    public class Members
    {
        [Key] public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}