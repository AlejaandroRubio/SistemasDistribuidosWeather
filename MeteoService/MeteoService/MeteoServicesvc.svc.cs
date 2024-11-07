using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System;
using System.Collections.Generic;
using System.IO;



namespace MeteoService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "MeteoServicesvc" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione MeteoServicesvc.svc o MeteoServicesvc.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class MeteoServicesvc : IMeteoServicesvc
    {
        

        CondicionesActuales  IMeteoServicesvc.GetCondicionesActuales(string ciudad)
        {
            /*
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, ("https://goweather.herouapp.com/weather/{"+ciudad+"}"));

            var response = client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var graphicJson = response.Content.ReadAsStringAsync();
            */
            
            return HardCodeCiudad(ciudad);



        }

        private CondicionesActuales HardCodeCiudad(string ciudad) {

            if (ciudad == "Madrid")
            {
               CondicionesActuales condicionesActuales = new CondicionesActuales();
                condicionesActuales.Description = "Partly cloudy";
                condicionesActuales.Temperature = "+8 ºC";
                condicionesActuales.Wind = "28 km/h";

                return condicionesActuales;
            }else if (ciudad == "Santander")
            {
                CondicionesActuales condicionesActuales = new CondicionesActuales();
                condicionesActuales.Description = "Sunny";
                condicionesActuales.Temperature = "-10 ºC";
                condicionesActuales.Wind = "50 km/h";

                return condicionesActuales;
            }else if (ciudad == "Tatooine") {
                CondicionesActuales condicionesActuales = new CondicionesActuales();
                condicionesActuales.Description = "Sand Storm";
                condicionesActuales.Temperature = "35 ºC";
                condicionesActuales.Wind = "200 km/h";
                return condicionesActuales;
            }else {

                CondicionesActuales condicionesActuales = new CondicionesActuales();
                condicionesActuales.Description = "DescriptionNotFound";
                condicionesActuales.Temperature = "TemperatureNotFound";
                condicionesActuales.Wind = "WindNotFound";

                return condicionesActuales;

            }
        }

        /*
         
        private async void GET(ActionType action, int index) {

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44366/api/Graphic2D");

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var graphicJson = await response.Content.ReadAsStringAsync();

            List<GraphicData2D> graphicList = JsonConvert.DeserializeObject<List<GraphicData2D>>(graphicJson);

            UpdateChart(graphicList, action, index);

        }
         
         */
    }
}
