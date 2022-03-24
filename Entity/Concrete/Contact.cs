﻿

using System;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
