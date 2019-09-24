using AdminElectoral.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminElectoral
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            fileSelection.ShowDialog();
            string archivo = fileSelection.FileName;
            XmlConverter conversor = new XmlConverter();
            conversor.generarXML(archivo);
            ConexionSQL prueba = new ConexionSQL("WINDOWS-SOLPA6D", "SISTEMA", "", "");
            prueba.CargaMasiva();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fileSelection.ShowDialog();
            string archivo = fileSelection.FileName;
            XmlConverter conversor = new XmlConverter();
            conversor.generarXML(archivo);
            ConexionOracle prueba = new ConexionOracle("192.168.0.3", "db19", "system", "admin", 1519);
            //textBox1.Text = (prueba.Conectar2());
            //prueba.CargaMasiva();

        }

    }
}
