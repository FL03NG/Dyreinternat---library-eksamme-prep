namespace dyreinternat___library.Models
{
    public class Booking
    {
        public int AnimalID { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string User {  get; set; }
        public string Description { get; set; }

        public Booking(int animalID, string name, DateTime startTime, DateTime endTime, string user, string description)
        {
            AnimalID = animalID;
            Name = name;
            StartTime = startTime;
            EndTime = endTime;
            User = user;
            Description = description;
        }
        public Booking()
        {

        }
    }
}
