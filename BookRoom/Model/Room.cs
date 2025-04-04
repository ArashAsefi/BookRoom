namespace BookRoom.Model
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }
        public bool HasProjector { get; set; }

        public Room()
        {
        }//defult constructor   
        public Room(int id, string name, int capacity, string description, bool hasProjector)
        {
            Id = id;
            Name = name;
            Capacity = capacity;
            Description = description;
            HasProjector = hasProjector;
        }


    }
}
