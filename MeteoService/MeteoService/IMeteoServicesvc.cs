using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MeteoService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IMeteoServicesvc" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IMeteoServicesvc
    {
        [OperationContract]
         CondicionesActuales  GetCondicionesActuales(string ciudad);

        
    }

    [DataContract]
    public class CondicionesActuales
    {
        string description;
        string temperature;
        string wind;

        [DataMember]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        [DataMember]
        public string Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

        [DataMember]
        public string Wind
        {
            get { return wind; }
            set { wind = value; }
        }
    }
}
