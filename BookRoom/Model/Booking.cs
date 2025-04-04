namespace BookRoom.Model
{
    public class Booking
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public string GuestName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Purpose { get; set; }

        public Booking()
        {
        }//defult constructor   
       public Booking(int id, int roomId, string guestName, DateTime startTime, DateTime endTime, string purpose)
        {
            Id = id;
            RoomId = roomId;
            GuestName = guestName;
            StartTime = startTime;
            EndTime = endTime;
            Purpose = purpose;

       }

        public override string ToString()
        {
            return $"Booking ID: {Id}, Room ID: {RoomId}, Guest Name: {GuestName}, Start Time: {StartTime}, End Time: {EndTime}, Purpose: {Purpose}";
        }
    }
}
