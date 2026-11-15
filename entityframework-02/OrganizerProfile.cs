using System;
using System.Collections.Generic;
using System.Text;

namespace entityframework_02
{
    public class OrganizerProfile
    {
        public int Id { get; set; }
        public string Biography { get; set; }
        public string WebsiteUrl { get; set; }
        public string LogoUrl { get; set; }

        // Foreign Key & Navigation Property
        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; }
    }
}
