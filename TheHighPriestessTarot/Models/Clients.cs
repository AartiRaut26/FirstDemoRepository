using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheHighPriestessTarot.Models
{
    public class Clients
    {
        [Key]
        public int Client_Id { get; set; }

        [Required(ErrorMessage ="Please Enter Your Name")]
        public string Client_Name { get; set; }

        [Required(ErrorMessage ="Please Enter Your Email")]
        [DataType(DataType.EmailAddress)]
        public string Client_email { get; set; }


        [Required(ErrorMessage ="Please enter Your Mobile Number")]
        public string Client_Phone { get; set; }

        [Required(ErrorMessage ="Please Enter Your City")]
        public string Client_City { get; set; }


        [Required(ErrorMessage ="Please Enter Your state")]
        public string Client_State { get; set; }


        [Required(ErrorMessage ="Please Enter Your Country")]
        public string Client_Country { get; set; }


        [Required(ErrorMessage ="type Text Here")]
        public string Client_Description { get; set; }

        [NotMapped]
        public string Healing_Department_Name { get; set; }

        public int Healing_Area_Id { get; set; }
    }
}
