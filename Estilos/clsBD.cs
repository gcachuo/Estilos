using System.Data;
using System.Data.SqlClient;

namespace Estilos
{
    class clsBD
    {
        string
                dataSource = "localhost",
                bd = "ESTILOS",
                user = "sa",
                pass = "sqlserver";
        SqlConnection conexion;

        public clsBD()
        {
            conexion = conectarBD();
        }

        public SqlConnection conectarBD()
        {
            var conexion = new SqlConnection(
                "Data Source=" + dataSource + ";" +
                "Initial Catalog=" + bd + ";" +
                "Persist Security Info=True;" +
                "User ID=" + user + ";" +
                "Password=" + pass);

            return conexion;
        }
        public DataTable select(string campos, string nombreTabla, string where = "")
        {
            var cmd = new SqlDataAdapter("SELECT " + campos + "FROM " + nombreTabla + " " + where, conexion);
            var ds = new DataSet();

            using (conexion)
            {
                cmd.Fill(ds);
            }

            var tabla = ds.Tables[0];
            return tabla;
        }
        public bool insert(string table, string nombresCampos, string campos)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into " + table + "(" + nombresCampos + ") values(" + campos + ")";
            cmd.Connection = conexion;

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();

            return true;
        }
    }
}

