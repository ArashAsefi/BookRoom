using BookRoom.Model;
using BookRoom.Pages.Repo;

namespace BookRoom
{
    public class BookingService
    {
        private readonly IBookRepo _bookRepo;

        public BookingService(IBookRepo bookRepo)
        {
            _bookRepo = bookRepo;
        }

        // Add your service methods here
    }



}
