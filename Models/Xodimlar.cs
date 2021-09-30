using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace xodimlar.Models
{
    [Table("person")]
    public class Xodimlar
    {
        [Column("id")]
        [Required]
        public int Id { get; set; }
        [Column("firstname")]
        public string  FirstName { get; set; }
        [Column("lastname")]
        public string  LastName { get; set; }
        [Column("username")]
        public string UserName { get; set; }
        [Column("phone")]
        [MaxLength(20)]
        public string Phone { get; set; }   

    }
}
