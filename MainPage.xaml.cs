using System.ComponentModel.DataAnnotations;
using Microsoft.Maui.Controls;

namespace FormsMaui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();
            
        }

        private void OnSubmitClicked(object sender, EventArgs e)
        {
            var viewModel = BindingContext as ViewModel;
            if (viewModel != null && ValidateForm(viewModel.Trip))
            {
                DisplayAlert("Success", "Form submitted successfully!", "OK");
            }
            else
            {
                DisplayAlert("Error", "Please fill in all required fields.", "OK");
            }
        }

        private bool ValidateForm(TripInfo trip)
        {
            var context = new ValidationContext(trip);
            var results = new List<ValidationResult>();
            return Validator.TryValidateObject(trip, context, results, true);
        }

        private void OnEditClicked(object sender, EventArgs e)
        {
            
            DisplayAlert("Edit", "Edit button clicked", "OK");
        }

        
        private void OnDeleteClicked(object sender, EventArgs e)
        {
            DisplayAlert("Delete", "Delete button clicked", "OK");
        }

        private async void OnPlanTripClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TripPlannerPage());
        }



    }
}
