using Clases;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;

namespace Manejador_Archivo
{
    public static class Serializadora
    {
        public static void EscribirXML(string path, List<Empleado> lista)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Empleado>));
                ser.Serialize(streamWriter, lista);
            }
        }
        public static List<Empleado> LeerXML(string path)
        {
            List<Empleado> lista = null;
            using (StreamReader sr = new StreamReader(path))
            {
                XmlSerializer des = new XmlSerializer(typeof(List<Empleado>));
                lista = (List<Empleado>)des.Deserialize(sr);// new List<Empleado>();
            }
            return lista;
        }   
        public static void EscririJSON(string path,List<Empleado> lista)
        {
            try
            {                
                string json = JsonConvert.SerializeObject(lista,Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(path, json);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Empleado> LeerJson(string path)
        {
            List<Empleado> lista = null;
            try
            {
                string json = File.ReadAllText(path);

                lista = JsonConvert.DeserializeObject<List<Empleado>>(json);//<List<Empleado>>json;
            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }        
    }
}