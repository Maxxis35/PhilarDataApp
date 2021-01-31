using System;
using System.Collections.Generic;

namespace PhilarDataApp.Models
{
    public class Concert
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateOfThe { get; set; }
        public string ConcertVenue { get; set; }
        public string Soloist { get; set; }
        public string Conductor { get; set; }
        public string Performer { get; set; }
        public string MusicalCompositions { get; set; }
        public string Note { get; set; }
        public int CountCameras { get; set; }
        public string Sound { get; set; }
        
    }
}
