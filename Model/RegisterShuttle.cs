namespace CampusShuttleAPI.Model
{
    public class RegisterShuttle
    {
        public int Id { get; set; }

        public int  UserId { get; set; }
        public User User { get; set; }

        public int ShuttleId { get; set; }  
        public Shuttle Shuttle { get; set; }
    }
}
