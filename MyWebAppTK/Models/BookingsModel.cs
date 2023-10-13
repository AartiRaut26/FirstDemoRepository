using System.ComponentModel.DataAnnotations;

namespace MyWebAppTK.Models
{
    public class BookingsModel
    {
        [Key]
        public int Booking_Id { get; set; }
        //-----------------------------------------

        [Required]
        [Display(Name =" Enter Your  Full Name")]
        public string Client_Name { get; set; }
        //-------------------------------------------

        [Required(ErrorMessage ="Enter Your Date Of Birth")]
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }
        //----------------------------------------------

        [EmailAddress]
        
        [Required(ErrorMessage ="Please Enter Your Email Address")]
        public string Email { get; set; }
        //-----------------------------------------------

        [Required(ErrorMessage ="Enter Your City")]
        public string Client_City { get; set; }
        //-------------------------------------------------

        [Required(ErrorMessage ="Enter Your Bookings")]
        public int Display_Booking { get; set; }
        //--------------------------------------------------

        [Required]
        [DataType(DataType.DateTime)]

        public DateTime Booking_Date { get; set; } = DateTime.Now;

        //-------------------------------------------------------

    }
}
