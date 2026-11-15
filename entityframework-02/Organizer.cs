using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace entityframework_02
{
    [Table("Eventorganizers")]
    public class Organizer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(150)]
        public string? CompanyName { get; set; } // Optional

        public bool IsVerified { get; set; }

        // Navigation Properties
        public OrganizerProfile Profile { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
