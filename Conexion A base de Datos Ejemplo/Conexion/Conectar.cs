using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Conexion
{
   public class Conectar
    {

        public SqlConnection connect = new SqlConnection();
       
        public Conectar(String user,String pass)
        {
            try
            {

                connect = new SqlConnection("Server = tcp:OMARSANDOVAL\\SQLEXPRESS,1433;Database = Ejemplo; UID=" + user + ";PWD=" + pass);
                connect.Open();
            }
            catch (Exception)
            {
              
                
            }
        }

        public void listarClientes(DataGridView tabla)
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataReader leer;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_VCliente";
            cmd.Connection = connect;


            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            tabla.DataSource = dt;

        }

        public void editarCliente(DataGridView tabla, int id, string pnombre, string snombre, string pApellido, string sapellido, string direccion, string tel)
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@PN", SqlDbType.NVarChar);
            param[1].Value = pnombre;

            param[2] = new SqlParameter("@SN", SqlDbType.NVarChar);
            param[2].Value = snombre;

            param[3] = new SqlParameter("@PA", SqlDbType.NVarChar);
            param[3].Value = pApellido;

            param[4] = new SqlParameter("@SA", SqlDbType.NVarChar);
            param[4].Value = sapellido;

            param[5] = new SqlParameter("@DC", SqlDbType.NVarChar);
            param[5].Value = direccion;

            param[6] = new SqlParameter("@TC", SqlDbType.Char);
            param[6].Value = tel;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_UPCliente";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);
        }

        public void eliminarCliente(int id)
        {
            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_DBCliente";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);
        }

        public void insertarCliente(string pnombre, string snombre, string pApellido, string sapellido, string direccion, string tel)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[6];
                param[0] = new SqlParameter("@PN", SqlDbType.NVarChar);
                param[0].Value = pnombre;

                param[1] = new SqlParameter("@SN", SqlDbType.NVarChar);
                param[1].Value = snombre;

                param[2] = new SqlParameter("@PA", SqlDbType.NVarChar);
                param[2].Value = pApellido;

                param[3] = new SqlParameter("@SA", SqlDbType.NVarChar);
                param[3].Value = sapellido;

                param[4] = new SqlParameter("@DC", SqlDbType.NVarChar);
                param[4].Value = direccion;

                param[5] = new SqlParameter("@TC", SqlDbType.Char);
                param[5].Value = tel;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_INCliente";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en la insercion");
                MessageBox.Show(e.Message);
                return;
            }
        }

    }
}
