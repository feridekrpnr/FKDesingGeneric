using System;
using System.Collections.Generic;
using System.Text;

namespace FKDesignEntities.Models
{
    public class Message:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public string Ip { get; set; }
        public byte Status { get; set; }

    }
}
