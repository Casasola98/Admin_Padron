
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace AdminElectoral.logica
{
    public class ConexionSQL
    {
        private string server;
        private string dataBase;
        private string userId;
        private string password;

        public ConexionSQL(string s, string d, string u, string p)
        {
            /*this.server = "192.168.100.9, 6060";
            this.dataBase = "SISTEMA";
            this.userId = "casa";
            this.password = "admin";
            */
            this.server = "localhost";
            this.dataBase = "SISTEMA";
            this.userId = "";
            this.password = "";
        }

        private string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(userId) || userId.Trim().Equals(string.Empty))
                {
                    return string.Format("Data Source={0};Initial Catalog={1};Integrated Security=yes", server, dataBase);
                }
                else
                {
                    return string.Format("Data Source={0};Initial Catalog={1};User ID={2};Pwd={3}", server, dataBase, userId, password);
                }

            }
        }

        public void CargaMasiva()
        {
            string direccionP = Path.GetFullPath("prueba.xml");
            string contenido = File.ReadAllText(direccionP);
            contenido = contenido.Replace("'", "''");
            SqlConnection cn = new SqlConnection(ConnectionString);
            string statement = string.Format("DECLARE @XML XML \n" +
                    "DECLARE @handle INT \n" +
                    "DECLARE @PrepareXmlStatus INT \n" +
                    "SET @XML = '{0}'\n" +
                    "EXEC @PrepareXmlStatus = sp_xml_preparedocument @handle OUTPUT, @XML \n" +
                    "INSERT Persona(Cedula, IdProvincia, IdCanton, IdDistrito, Sexo, FechaCaducidad, CodigoJunta, Nombre, Apellido1, Apellido2) \n" +
                    "SELECT Cedula, Provincia, Canton, Distrito, Sexo, FechaCad \n" +
                    ", Junta, Nombre, Apellido1, Apellido2 \n" +
                    "FROM OPENXML(@handle, 'Personas/Persona') WITH \n" +
                    "(Cedula bigint '@Cedula', Provincia smallint, Canton smallint, Distrito smallint, Sexo int, FechaCad date, \n" +
                    "Junta int, Nombre varchar(50) '@Nombre', Apellido1 varchar(50), Apellido2 varchar(50))", contenido);
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand(statement);
                cm.CommandType = System.Data.CommandType.Text;
                cm.Connection = cn;
                cm.CommandTimeout = 0;
                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        public bool TestConnection()
        {
            SqlConnection cn;
            cn = new SqlConnection(ConnectionString);
            try
            {
                cn.Open();
                if (cn != null)
                {
                    cn.Close();
                    return true;
                }
                else
                {
                    cn.Close();
                    return false;
                }
            }
            catch
            {
                cn.Close();
                return false;
            }
        }
    }
}
