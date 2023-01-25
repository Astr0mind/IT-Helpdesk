using System.ComponentModel.DataAnnotations;

namespace Help_Desk_new.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string EmployeeName { get; set; }

        [Required]
        public string Importance { get; set; }

        [Required]
        [DataType(DataType.Date)]

        public DateTime Dateissued { get; set; }

        [Required]
        public string Issue { get; set; }

        [DataType(DataType.Date)]
        public DateTime? SignOffdate { get; set; }

        [Required]
        public bool isActive { get; set; }



    }
}
