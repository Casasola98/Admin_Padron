using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdminElectoral.logica
{
    class XmlConverter
    {

        public void generarXML(string direccion)
        {
            XElement personas = new XElement("Personas");
            string[] lineas = File.ReadAllLines(direccion);
            foreach(string linea in lineas)
            {
                string[] line = linea.Split(',');
                string codelec = line[1];
                char[] codeChar = codelec.ToCharArray();
                string provincia = Char.ToString(codeChar[0]);
                string canton = new string(new char[] { codeChar[1], codeChar[2] });
                string distrito = new string(new char[] { codeChar[3], codeChar[4], codeChar[5] });
                int prov = Int32.Parse(provincia);
                int cant = Int32.Parse(canton);
                int dist = Int32.Parse(distrito);
                string nombre = line[5];
                XElement persona = new XElement("Persona",
                    new XAttribute("Cedula", Int32.Parse(line[0])),
                    new XAttribute("Provincia", prov),
                    new XAttribute("Canton", cant),
                    new XAttribute("Distrito", dist),
                    new XAttribute("Sexo", line[2]),
                    new XAttribute("FechaCad", line[3]),
                    new XAttribute("Junta", line[4]),
                    new XAttribute("Nombre", nombre.TrimEnd(' ')),
                    new XAttribute("Apellido1", line[6].Replace(" ", "")),
                    new XAttribute("Apellido2", line[7].Replace(" ", ""))
                    );
                personas.Add(persona);
            }
            personas.Save("prueba.xml");
        }

        /*
        public void generarDistelec(string direccion)
        {
            string provs = "0";
            string cants = "0";
            string dists = "0";
            XElement pais = new XElement("Pais");
            string[] lineas = File.ReadAllLines(direccion);
            XElement provinciaX = new XElement("Provincia");
            XElement cantonX = new XElement("Canton");
            XElement distritoX = new XElement("Distrito");
            foreach (string linea in lineas)
            {
                string[] line = linea.Split(',');
                string codelec = line[0];
                char[] codeChar = codelec.ToCharArray();
                string provincia = Char.ToString(codeChar[0]);
                string canton = new string(new char[] { codeChar[1], codeChar[2] });
                string distrito = new string(new char[] { codeChar[3], codeChar[4], codeChar[5] });
                string distName = line[3];
                distName = distName.TrimEnd(' ');
                int prov = Int32.Parse(provincia);
                int cant = Int32.Parse(canton);
                int dist = Int32.Parse(distrito);
                if (provs == "0") {
                    provs = provincia;
                    provinciaX = new XElement("Provincia", new XAttribute("Id", prov), new XAttribute("Nombre", line[1]));
                    cants = canton;
                    cantonX = new XElement("Canton", new XAttribute("Id", cant), new XAttribute("Nombre", line[2]));
                }
                else
                {
                    if(provs != provincia)
                    {
                        provinciaX.Add(cantonX);
                        pais.Add(provinciaX);
                        provs = provincia;
                        provinciaX = new XElement("Provincia", new XAttribute("Id", prov), new XAttribute("Nombre", line[1]));
                        cants = canton;
                        cantonX = new XElement("Canton", new XAttribute("Id", cant), new XAttribute("Nombre", line[2]));

                    }
                }
                if (cants != canton)
                {
                    provinciaX.Add(cantonX);
                    cants = canton;
                    cantonX = new XElement("Canton", new XAttribute("Id", cant), new XAttribute("Nombre", line[2]));
                }

                distritoX = new XElement("Distrito", new XAttribute("Id", dist), new XAttribute("Nombre", distName));
                cantonX.Add(distritoX);

            }
            provinciaX.Add(cantonX);
            pais.Add(provinciaX);
            pais.Save("distelec.xml");
        }
        */
    }
}
