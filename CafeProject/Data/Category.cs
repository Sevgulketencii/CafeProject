using System.ComponentModel.DataAnnotations;

namespace CafeProject.Data
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Menu> Menu { get; set; }
        public bool Status { get; set; }
    }
}
