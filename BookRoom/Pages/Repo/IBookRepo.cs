using BookRoom.Model;

namespace BookRoom.Pages.Repo
{
    public interface IBookRepo
    {

        public List<Booking> GetAll();

        public void Add(Booking booking);


    }
}
