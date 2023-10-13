using Microsoft.AspNetCore.Mvc;
using MyWebAppTK.Data;
using MyWebAppTK.Models;

namespace MyWebAppTK.Controllers
{
    public class BookingsController : Controller
    {
        private  MyWebAppTKDBContext _myWebAppTKDBContext;

        public BookingsController(MyWebAppTKDBContext myWebAppTKDBContext)
        {
            _myWebAppTKDBContext = myWebAppTKDBContext;
        }

        public IActionResult Index()
        {
            IEnumerable<BookingsModel> bookings = _myWebAppTKDBContext.bookings;
            return View(bookings);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BookingsModel bookings)
        {
            if(ModelState.IsValid)
            {
                _myWebAppTKDBContext.bookings.Add(bookings);
                TempData["success"]= "Booking Added successfully";
                _myWebAppTKDBContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookings);
        }

        //---------------------------------------------------------------------------------

        //Code for Edit Data

        [HttpGet]
        public IActionResult Edit(int? id)
        {
           

            var booking = _myWebAppTKDBContext.bookings.Find(id);

            if (booking == null)
            {
                return NotFound();

            }

            return View(booking);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

		
		public IActionResult Edit(int id, BookingsModel updatedBooking)
		{
			if (ModelState.IsValid)
			{
				// Retrieve the existing booking from the database
				var existingBooking = _myWebAppTKDBContext.bookings.Find(id);

				if (existingBooking == null)
				{
					return NotFound();
				}

				// Update the existing booking with the new values
				//existingBooking.Booking_Id = updatedBooking.Booking_Id; // Replace with actual property names
				existingBooking.Client_Name = updatedBooking.Client_Name; // Replace with actual property names
				existingBooking.DateOfBirth = updatedBooking.DateOfBirth;
				existingBooking.Email = updatedBooking.Email;
				existingBooking.Client_City = updatedBooking.Client_City;
				existingBooking.Display_Booking = updatedBooking.Display_Booking;
				existingBooking.Booking_Date = updatedBooking.Booking_Date;

				_myWebAppTKDBContext.SaveChanges();
				TempData["success"] = "Booking Updated successfully";

				return RedirectToAction("Index");
			}

			return View(updatedBooking);
		}

		/*  public IActionResult Edit(int id, BookingsModel updatebooking)
		  {
			  if (ModelState.IsValid)
			  {
				  _myWebAppTKDBContext.bookings.Update(updatebooking);
				  _myWebAppTKDBContext.SaveChanges();
				  return RedirectToAction("Index");
			  }

			  return RedirectToAction("Index", new { id = updatebooking.Booking_Id });
		  } */




		//------------------------------------------------------------------------------------------
		//Delete data code

		[HttpGet]
        public IActionResult Delete(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var booking = _myWebAppTKDBContext.bookings.Find(id);
            if(booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteData(int? id)
        {
            var booking = _myWebAppTKDBContext.bookings.Find(id);
            if(booking == null)
            {
                return NotFound();
            }

            _myWebAppTKDBContext.bookings.Remove(booking);
            _myWebAppTKDBContext.SaveChanges();
            TempData["success"] = "Booking Deleted successfully";

            return RedirectToAction("Index");

            
        }

    }


}
