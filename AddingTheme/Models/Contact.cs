using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AddingTheme.Models
{    [Table("contact")]
    public class Contact
    {
        public int Id { get; set; }
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        [StringLength(100)]
        [Required]
        public string Email { get; set; }
        [StringLength(100)]
        [Required]
        public string Subject { get; set; }
        [StringLength(1000)]
        [Required]
        public string Message { get; set; }
        [StringLength(20)]
        [Required]
        public string PhoneNumber { get; set; }
    }
}