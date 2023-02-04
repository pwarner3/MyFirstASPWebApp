using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASPWebApp.Models
{
    public class FanMailModel
    {
        [Required]
        public string From { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
