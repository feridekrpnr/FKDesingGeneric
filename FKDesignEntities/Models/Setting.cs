using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FKDesignEntities.Models
{
    public class Setting
       
    {
       
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SettingId { get; set; }

        [Required]
        [StringLength(50)]
        public string SettingName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public char Keywords { get; set; }
        public string Adress { get; set; }
        public char Phone { get; set; }
        public string Email { get; set; }

    }
}
