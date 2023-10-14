using System.ComponentModel.DataAnnotations;

namespace TheHighPriestessTarot.Models
{
    public class Healing_Dept
    {
        [Key]
        public int Healing_Area_Id { get; set; }

        [Required]
        public string Healing_Department_Name { get; set; }
    }
}
