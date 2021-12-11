using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FKDesignEntities.Models
{
    public class Comment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentId { get; set; }
        [Required]
        [StringLength(50)]
        public string CommentName { get; set; }

        public int Rate { get; set; }
       
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product product { get; set; }
        //Category ilişki user:1-commentt:N
        [ForeignKey("User")]
        public int UserId { get; set; }

        public User user { get; set; }
    }
}
