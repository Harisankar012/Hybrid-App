namespace FormsMaui
{
    public partial class TripPlannerPage : ContentPage
    {
        public TripPlannerPage()
        {
            InitializeComponent();
        }

        //private async void OnSaveClicked(object sender, EventArgs e)
        //{
           
        //    await DisplayAlert("Success", "Trip details saved successfully!", "OK");
        //    await Navigation.PushAsync(new TripPlannerPage());

        //}

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            
            await DisplayAlert("Success", "Saved successfully!", "OK");
            //save
            if (BindingContext is ViewModel viewModel)
            {
                viewModel.Trips.Add(new TripInfo
                {
                    TripName = viewModel.Trip.TripName,
                    DateOfTrip = viewModel.Trip.DateOfTrip,
                    TimeOfTrip = viewModel.Trip.TimeOfTrip,
                    Location = viewModel.Trip.Location,
                    DurationTill = viewModel.Trip.DurationTill,
                    Description = viewModel.Trip.Description
                });
            }

            // Navigate to the saved trips page
            await Navigation.PushAsync(new SavedTripsPage());
        }

    }

}
