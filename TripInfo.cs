using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsMaui
{
    public class TripInfo
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Trip Name is required")]
        public string TripName { get; set; }

        [Required(ErrorMessage = "Date of the trip is required")]
        public DateTime? DateOfTrip { get; set; }

        [Required(ErrorMessage = "Time of the trip is required")]
        public TimeSpan? TimeOfTrip { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Location is required")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Duration is required")]
        public TimeSpan? DurationTill { get; set; }

        public string Title { get; set; }
        public string Date { get; set; }


        public string Description { get; set; }

       
    }
}
