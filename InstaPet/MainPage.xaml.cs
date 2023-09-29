using Microsoft.Maui.Controls;

namespace InstaPet
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Title = Localization.Resources.Title;
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {

            // Navigate to the login page or perform the desired action
            // when the "¿Ya tienes una cuenta? Inicia sesión." button is clicked
        }
        private void OnCreateAccountTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }


    }
}
