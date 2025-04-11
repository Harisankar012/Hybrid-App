using System.Collections.ObjectModel;

namespace FormsMaui
{
    public class ViewModel
    {
        public TripInfo Trip { get; set; }

        public ObservableCollection<string> Mushrooms { get; set; }

        // Declare Trips as a public property
        public ObservableCollection<TripInfo> Trips { get; set; }

        public ViewModel()
        {
            this.Trip = new TripInfo();
            this.Trips = new ObservableCollection<TripInfo>();
            Mushrooms = new ObservableCollection<string>
            {
                "Shiitake",
                "Portobello",
                "White Button",
                "Oyster",
                "Cremini"
            };

            // Initialize Trips with static data
            Trips = new ObservableCollection<TripInfo>
            {
                new TripInfo { Title = "Happy Trip", Date = "2nd December 2024" },
                new TripInfo { Title = "Hiking Everest", Date = "5th June 2024" },
                new TripInfo { Title = "Safari in Africa", Date = "20th July 2024" },
                new TripInfo { Title = "Vilage tour Bali", Date = "15th October 2024" }
            };


        }


    }

}
