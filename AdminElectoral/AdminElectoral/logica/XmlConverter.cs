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
                XElement persona = new XElement("Persona",
                    new XAttribute("Cedula", Int32.Parse(line[0])),
                    new XAttribute("Provincia", prov),
                    new XAttribute("Canton", cant),
                    new XAttribute("Distrito", dist),
                    new XAttribute("Sexo", line[2]),
                    new XAttribute("FechaCad", line[3]),
                    new XAttribute("Junta", line[4]),
                    new XAttribute("Nombre", line[5].Replace(" ", "")),
                    new XAttribute("Apellido1", line[6].Replace(" ", "")),
                    new XAttribute("Apellido2", line[7].Replace(" ", ""))
                    );
                personas.Add(persona);
            }
            personas.Save("prueba.xml");
        }

    }
}
