

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SeoTags { get; set; }
        public bool Status { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
