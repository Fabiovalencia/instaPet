using Microsoft.Maui.Controls;

namespace InstaPet
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // Aquí implementa la lógica para verificar las credenciales del usuario en la base de datos.
            // Debes comparar los datos ingresados con los registros en la base de datos y manejar el inicio de sesión.
        }
    }
}
