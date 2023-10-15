using System.ComponentModel.DataAnnotations;

namespace CafeProject.Data
{
    public class Chefs
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string imageUrl { get; set; }
        public string ChefArea { get; set; }
        public string ChefInstagram { get; set; }
        public string ChefX { get; set; }
        public string ChefFacebook { get; set; }
        public bool Status { get; set; }

    }
}
