using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace deber2AlexisSigcha
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class vista_dos : ContentPage
    {
        public vista_dos(string user)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario activo: " + user;
        }

        private void btnResultado_Clicked(object sender, EventArgs e)
        {
            double ex1 = Convert.ToDouble(txtEx1.Text);
            double ex2 = Convert.ToDouble(txtEx2.Text);
            double seg1 = Convert.ToDouble(txtSeg1.Text);
            double seg2 = Convert.ToDouble(txtSeg2.Text);

            double par1 = (ex1 * 0.2) + (seg1 * 0.3);
            lblResultado1.Text = par1.ToString();
            double par2 = (ex2 * 0.2) + (seg2 * 0.3);
            lblResultado2.Text = par2.ToString();
            double final = par1 + par2;
            lblFinal.Text = final.ToString();
            if (final >= 7)
            {
                lblFinalRes.Text = "Aprovado";
            }

            if (final >= 5 && final <= 6.9)
            {
                lblFinalRes.Text = "Complementario";
            }

            if (final < 5)
            {
                lblFinalRes.Text = "Reprovado";
            }

        }
    }
}