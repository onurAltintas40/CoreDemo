

using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Subscriber
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
    }
}
