using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FKDesignEntities.Models
{
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        [Required]
        [StringLength(50)]
        public string OrderName { get; set; }
        public string OrderSurname { get; set; }
        public string Email { get; set; }
        //1-N User:1 Order:N
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
