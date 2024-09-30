namespace CampusShuttleAPI.Model
{
    public class Booking
    {

        public int Id { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public string Direction { get; set; }

        public int Userid { get; set; }
        public User User { get; set; }

    }
}
