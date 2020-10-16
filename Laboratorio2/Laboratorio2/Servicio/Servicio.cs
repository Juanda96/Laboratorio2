using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    class Servicio
    {
        private static string rutaProvinicias = @"JSon\provincias.json";
        private static string rutaAlajuela = @"JSon\Alajuela\Cantones.json";
        private static string rutaSanCarlos = @"JSon\Alajuela\SanCarlos\distrito.json";
        List<string> _SanCarlos = new List<string> {"Quesada","Florencia","Pital"};
        List<string> _Alajuela = new List<string> { "SanCarlos", "Zarcero", "Naranjo" };
        List<string> Provincias = new List<string> { "Alajuela", "Cartago", "Limon", "Puntarenas", "Guanacaste", "San José", "Heredia" };

        public void Crearprovincias() {
            String provinciasJson = JsonConvert.SerializeObject(Provincias.ToArray(), Formatting.Indented);
            File.WriteAllText(rutaProvinicias,provinciasJson);
        }

        public void CrearAlajuela()
        {
            String alajuelaJson = JsonConvert.SerializeObject(_Alajuela.ToArray(), Formatting.Indented);
            File.WriteAllText(rutaAlajuela, alajuelaJson);
        }

        public void CrearSanCarlos()
        {
            String SanCarlosJson = JsonConvert.SerializeObject(_SanCarlos.ToArray(), Formatting.Indented);
            File.WriteAllText(rutaSanCarlos, SanCarlosJson);
        }

        public List<string> consultarProvincias() 
        {
            String Provincias;
            List<string> provincias = new List<string>();
            using (StreamReader reader = new StreamReader(rutaProvinicias))
            {
                Provincias = reader.ReadToEnd();
                provincias = JsonConvert.DeserializeObject<List<string>>(Provincias);
                return provincias;
            }
        }

        public List<string> consultarCantones(String Provincia)
        {
            String Provincias;
            List<string> provincias = new List<string>();
            using (StreamReader reader = new StreamReader(String.Format(@"JSon\{0}\Cantones.json",Provincia)))
            {
                Provincias = reader.ReadToEnd();
                provincias = JsonConvert.DeserializeObject<List<string>>(Provincias);
                return provincias;
            }
        }

        public List<string> consultarDistritos(String Provincia,String canton)
        {
            String Provincias;
            List<string> provincias = new List<string>();
            using (StreamReader reader = new StreamReader(String.Format(@"JSon\{0}\{1}\distrito.json", Provincia,canton)))
            {
                Provincias = reader.ReadToEnd();
                provincias = JsonConvert.DeserializeObject<List<string>>(Provincias);
                return provincias;
            }
        }


    }
}
