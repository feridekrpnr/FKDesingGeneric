using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FKDesignEntities.Models
{
    public class Image:BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int  ProductId{ get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
    }
}
