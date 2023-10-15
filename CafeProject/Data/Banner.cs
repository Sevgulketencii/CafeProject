using System.ComponentModel.DataAnnotations;

namespace CafeProject.Data
{
    public class Banner
    {
        [Key]
        public int ID { get; set; }
        public string BannerImgUrl { get; set; }
        public bool Status { get; set; }
    }
}
