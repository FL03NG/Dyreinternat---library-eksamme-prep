namespace dyreinternat___library.Models
{
    public class Activity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Tilmeldt { get; set; }
        public int ID { get; set; }

        public Activity(string name, string description, DateTime startTime, DateTime endTime, int tilmeldt, int iD)
        {
            Name = name;
            Description = description;
            StartTime = startTime;
            EndTime = endTime;
            Tilmeldt = tilmeldt;
            ID = iD;
        }
        public Activity()
        {

        }
    }
}
