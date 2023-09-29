using Microsoft.Maui.Controls;
using System;

namespace InstaPet
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Contenido de la página principal
            var label = new Label
            {
                Text = "¡Hola, mundo!",
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            };

            Content = new Grid
            {
                Children = { label }
            };
        }

        // Agrega el evento OnCounterClicked
        private void OnCounterClicked(object sender, EventArgs e)
        {
            // Lógica que se ejecutará cuando se haga clic en el evento
        }
    }
}
