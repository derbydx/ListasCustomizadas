using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListCustLab
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<Perfiles> Datos;
        public MainPage()
        {
            InitializeComponent();

            Datos = new List<Perfiles>();
            Datos.Add(new Perfiles()
            {
                Imagen = "",
                Titulo = "Elecciones en RD van bien ",
                Detalle = "Las elecciones van de viento en POPA..."
            });

            Datos.Add(new Perfiles()
            {
                Imagen = "",
                Titulo = "Siguen los turistas llegando",
                Detalle = "El ministerio de turismo indica que la tasa..."
            });

            Datos.Add(new Perfiles()
            {
                Imagen = "",
                Titulo = "Elecciones en RD",
                Detalle = "Las elecciones van de viento en POPA..."
            });
            ListaPerfiles.ItemsSource = Datos;
        }
    }
}

public class Perfiles
{
    public string Imagen { get; set; }
    public string Titulo { get; set; }
    public string Detalle { get; set; }



}

