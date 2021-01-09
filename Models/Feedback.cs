using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCWebApp.Models
{
    [Table("feedback")]
    public class Feedback
    {
        [Key] public int Eid { get; set; }
        public string name { get; set; }

        public string gender { get; set; }

        public string email { get; set; }

        public string comment { get; set; }
    }
}