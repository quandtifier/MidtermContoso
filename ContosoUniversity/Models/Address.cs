using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Address
    {
        [Key]
        [ForeignKey("Person")]
        public int PersonID { get; set; }
        [EmailAddress(ErrorMessage ="Not a valid email.")]
        public string Email { get; set; }

        public virtual Person Person { get; set; }
    }
}