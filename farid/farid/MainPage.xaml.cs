using System;
using Xamarin.Forms;

namespace farid
{
    public partial class MainPage : ContentPage
    {
        Entry kgEntry, litrosEntry, celsiusEntry;
        Label resultadoLibrasLabel, resultadoGalonesLabel, resultadoFahrenheitLabel;

        public MainPage()
        {
            InitializeComponent();

            // Crear elementos de interfaz de usuario
            kgEntry = new Entry { Placeholder = "Ingrese kg" };
            resultadoLibrasLabel = new Label();

            litrosEntry = new Entry { Placeholder = "Ingrese litros" };
            resultadoGalonesLabel = new Label();

            celsiusEntry = new Entry { Placeholder = "Ingrese °C" };
            resultadoFahrenheitLabel = new Label();

            Button convertButton = new Button { Text = "Convertir" };
            convertButton.Clicked += OnConvertClicked;

            // Crear diseño de la página
            StackLayout stackLayout = new StackLayout
            {
                Padding = new Thickness(20),
                Children = {
                    new Label { Text = "Convertidor de Unidades", FontSize = 20, HorizontalOptions = LayoutOptions.CenterAndExpand, Margin = new Thickness(0, 0, 0, 20) },

                    new Label { Text = "Peso (kg)" },
                    kgEntry,
                    resultadoLibrasLabel,

                    new Label { Text = "Volumen (litros)" },
                    litrosEntry,
                    resultadoGalonesLabel,

                    new Label { Text = "Temperatura (°C)" },
                    celsiusEntry,
                    resultadoFahrenheitLabel,

                    convertButton
                }
            };

            Content = stackLayout;
        }

        private void OnConvertClicked(object sender, EventArgs e)
        {
            // Conversión de peso (kg) a libras
            if (double.TryParse(kgEntry.Text, out double kg))
            {
                double libras = kg * 2.20462;
                resultadoLibrasLabel.Text = string.Format("Resultado en Libras: {0:F2} libras", libras);
            }
            else
            {
                resultadoLibrasLabel.Text = "Resultado en Libras: Ingrese un valor válido";
            }

            // Conversión de volumen (litros) a galones
            if (double.TryParse(litrosEntry.Text, out double litros))
            {
                double galones = litros * 0.264172;
                resultadoGalonesLabel.Text = string.Format("Resultado en Galones: {0:F2} galones", galones);
            }
            else
            {
                resultadoGalonesLabel.Text = "Resultado en Galones: Ingrese un valor válido";
            }

            // Conversión de temperatura (°C) a Fahrenheit
            if (double.TryParse(celsiusEntry.Text, out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                resultadoFahrenheitLabel.Text = string.Format("Resultado en Fahrenheit: {0:F2} °F", fahrenheit);
            }
            else
            {
                resultadoFahrenheitLabel.Text = "Resultado en Fahrenheit: Ingrese un valor válido";
            }
        }
    }
}

