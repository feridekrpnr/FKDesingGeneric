using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FKDesignEntities.Models
{
    public class Product
    {
        public Product()
        {
            Comments = new Collection<Comment>();
        }
        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public char Keywords { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        //Category ilişki category:1-product:N
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public Category category { get; set; }

        //Comment ilişki product:1-comment:N
        public ICollection<Comment> Comments { get; set; }
        //User ilişki user:1-product:N
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
