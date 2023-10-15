using System.ComponentModel.DataAnnotations;

namespace CafeProject.Data
{
    public class Fotter
    {
        [Key]
        public int ID { get; set; }
        public string CopyrightText { get; set; }
        public string DesignedName { get; set; }
        public string XUrl { get; set; }
        public string FacebookUrl{ get; set; }
        public string InstagramUrl{ get; set; }
    }
}
