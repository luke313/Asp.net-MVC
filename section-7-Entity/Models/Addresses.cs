using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace section_7_Entity.Models
{
    [Table("Addresses")]
    public class Addresses
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(200)]
        public string AddressDesc { get; set; }
        public virtual Users User { get; set; }


    }
}