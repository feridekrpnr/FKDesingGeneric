using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FKDesignEntities.Models
{
    public class User
    {
        public User()
        {
            Comments = new Collection<Comment>();
            Products = new Collection<Product>();
            Orders = new Collection<Order>();
        }



        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string Email { get; set; }
        public int Password { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Order> Orders { get; set; }
        public Profile Profiles { get; set; }
    }
}
