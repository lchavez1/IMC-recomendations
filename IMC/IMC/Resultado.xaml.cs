using IMC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IMC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resultado : ContentPage
    {
        public Resultado(Paciente paciente)
        {
            InitializeComponent();
            float metros = paciente.Altura / 100.0f;
            float imc = paciente.Peso / (metros * metros);
            lblNombre.Text = paciente.Nombre;
            if (imc < 18.5)
            {
                imgResultado.Source = "https://animeipics.files.wordpress.com/2014/01/madaras-old-age.png";
                lblIMC.Text = "Insuficiencia";
                lblRecomendation.Text = "Se recomienda hacer como mínimo 5-6 comidas con el fin de no guardar largos ayunos y no llegar con hambre a las comidas";
            } else if (imc >= 18.5 & imc < 25)
            {
                imgResultado.Source = "http://3.bp.blogspot.com/-s-E1zYKNzBs/T7q6tlvYXNI/AAAAAAAACnQ/rKJMfhEpcZs/s1600/Shikamaru-Nara-shikamaru-18617305-855-480.jpg";
                lblIMC.Text = "Normal";
                lblRecomendation.Text = "Sigue alimentandote de una buena manera, realiza ejercicio y duerme bien";
            } else if(imc >= 25 & imc < 30)
            {
                imgResultado.Source = "https://vignette.wikia.nocookie.net/sabinsharma/images/e/e1/Asuma-Sarutobi-asuma-sarutobi-18981597-1280-720.jpg";
                lblIMC.Text = "Sobrepeso";
                lblRecomendation.Text = "Disponer de un método o dieta confiable y respetuoso con el que poder manejar los alimentos y las raciones, hacer ejercicio y dormir bien";
            } else if(imc >= 30 & imc < 35)
            {
                imgResultado.Source = "http://images2.fanpop.com/image/photos/11500000/Kankuro-naruto-11510380-640-480.jpg";
                lblIMC.Text = "Obesidad 1";
                lblRecomendation.Text = "Elegir alimentos de baja densidad energética: frutas con mucha agua, pescado, verduras… ademas de realizar 20 min de ejercicio diariamente";
            } else if(imc >= 35 & imc < 40)
            {
                imgResultado.Source = "http://vignette2.wikia.nocookie.net/naruto/images/7/73/Chiyo.png";
                lblIMC.Text = "Obesidad 2";
                lblRecomendation.Text = "Cocinar con aceite de oliva utilizando la cantidad adecuada sin abusar, no comer mucha harina, realizar ejercicio y dormir bien";
            } else if(imc >= 40)
            {
                imgResultado.Source = "http://vignette3.wikia.nocookie.net/naruto/images/e/ec/Ch%C5%8Dji_Part_II.png";
                lblIMC.Text = "Obesidad 3";
                lblRecomendation.Text = "Come frutas y verduras regularmente, acude con un nutriologo profesional y no consumas alimentos grasos exesivos. Ademas realiza ejercicio diariamente";
            }

        }

    }
}