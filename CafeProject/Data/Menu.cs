using System.ComponentModel.DataAnnotations;

namespace CafeProject.Data
{
    public class Menu
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string İmageUrl { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public bool SpecialFood { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public bool Status { get; set; }

    }
}
