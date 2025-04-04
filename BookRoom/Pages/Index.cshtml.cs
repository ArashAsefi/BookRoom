using BookRoom.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookRoom.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private BookingService _petService;

        public List<Booking> Booing { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IndexModel(ILogger<IndexModel> logger, BookingService bs)
        {
            _logger = logger;
            Booking = bs.GetAll();
            _bookingService = bs;
        }

        public void OnGet()
        {

        }
    }
}
