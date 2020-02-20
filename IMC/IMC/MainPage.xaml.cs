using IMC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IMC
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnRevisar.Clicked += BtnRevisar_Clicked;
        }

        async void BtnRevisar_Clicked(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente {
                Nombre = txtNombre.Text,    
                Altura = int.Parse(txtEstatura.Text),
                Peso = float.Parse(txtPeso.Text)
            };
            /*paciente.Nombre = txtNombre.Text;
            paciente.Altura = int.Parse(txtEstatura.Text);
            paciente.Peso = float.Parse(txtPeso.Text);*/
            await Navigation.PushAsync(new Resultado(paciente));
        }
    }
}
