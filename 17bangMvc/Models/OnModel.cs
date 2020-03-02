using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _17bangMvc.Models
{
    public class OnModel
    {
        [Required]
        public string Name { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string SecurityCode { get; set; }
    }
}