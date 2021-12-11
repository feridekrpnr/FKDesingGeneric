using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FKDesignEntities.Models
{
    public class Category
    {
        public Category()
        {
            Products = new Collection<Product>();
        }
        [Key]
        public int CategoryId { get; set; }
        [Required]

        public int ParentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string Image { get; set; }
        public ICollection<Product> Products { get; set; }

       
    }
}
