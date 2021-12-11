using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FKDesignEntities.Models
{
    public class Faq
    {
        [Key]
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
