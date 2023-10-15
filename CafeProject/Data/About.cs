using System.ComponentModel.DataAnnotations;

namespace CafeProject.Data
{
    public class About
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

    }
}
