using System;
using Xamarin.Forms;

namespace deber2AlexisSigcha
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            if ((user == "Gabriel") && (pass == "Gabo123"))
            {
                await Navigation.PushAsync(new vista_dos(user));

            }
            else
            {
                await DisplayAlert("Alerta", "Credenciales Incorectas", "cerrar");
            }
        }
    }
}
