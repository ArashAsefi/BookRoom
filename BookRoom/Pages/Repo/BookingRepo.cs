using BookRoom.Model;

namespace BookRoom.Pages.Repo
{
    public class BookingRepo : IBookRepo
    {

        List<Booking> _booking = new List<Booking>();

        public void Add(Booking booking)
        {
            _booking.Add(booking);
        }
        public List<Booking> GetAll()
        {
            return _booking;
        }

      

        public BookingRepo()
        {
            _booking.Add(new Booking());
         

        }






    }
}
