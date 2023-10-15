namespace CafeProject.Models
{
    public class ReservationModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Guest { get; set; }
        public DateTime Date { get; set; }

        public string Time { get; set; }
        public string Message { get; set; }
    }
}
