namespace FormsMaui
{
    public partial class SavedTripsPage : ContentPage
    {
        public SavedTripsPage()
        {
            InitializeComponent();
        }

        private async void OnEditClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var trip = button?.BindingContext as TripInfo;

            if (trip != null)
            {
               
                await Navigation.PushAsync(new TripPlannerPage());
            }
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var trip = button?.BindingContext as TripInfo;

            if (trip != null)
            {
           
                var viewModel = BindingContext as ViewModel;
                viewModel?.Trips.Remove(trip);
            }
        }
    }
}
