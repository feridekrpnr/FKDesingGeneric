using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FKDesignEntities.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        [Required]
        [StringLength(50)]
        public string RolName { get; set; }
       
    }
}
