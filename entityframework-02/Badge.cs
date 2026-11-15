using System;
using System.Collections.Generic;
using System.Text;

namespace entityframework_02
{
    public class Badge
    {
        public int Id { get; set; }
        public string CredentialNumber { get; set; }
        public DateTime IssuedDate { get; set; }
        public string Tier { get; set; } 

        // Foreign Key & Navigation Property
        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; }
    }
}
