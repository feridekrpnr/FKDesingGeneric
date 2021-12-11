using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FKDesignEntities.Models
{
    public class Profile : BaseEntity
    {
        [Key]
        public int ProfileId { get; set; }

        public string Image { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }

        //Hangi tabloyla ilişki kuracak
        //user:1 profile:1
        [ForeignKey("User")]
        public int User_Id { get; set; }
        public User User { get; set; }
    }
}
