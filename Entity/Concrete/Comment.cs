

using System;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
