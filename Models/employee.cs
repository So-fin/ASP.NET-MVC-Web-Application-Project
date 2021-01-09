using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCWebApp.Models
{
    [Table("employee")]
    public class employee
    {

        [Key] public int EmpId { get; set; }
        public string Name { get; set; }
        public string gender { get; set; }
        public string Email { get; set; }


    }
}