﻿
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaVistas.CapaDatos
{
    public class ConexionDB
    {
        public SqlConnection flujo = new SqlConnection();

        public ConexionDB(string user, string pass)
        {
            try
            {
                flujo = new SqlConnection("tcp:OMARSANDOVAL\\SQLEXPRESS,1433;Database=Ejemplo;UID=" + user + ";PWD=" + pass);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void listarCliente(DataGridView tabla)
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataReader leer;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MostrarUsuarios";
            cmd.Connection = ConexionDB;


            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;

        }

        public void editarCliente(DataGridView GridView1, int id, String tel, String dir)
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@tel", SqlDbType.Char);
            param[1].Value = tel;
            param[2] = new SqlParameter("@dir", SqlDbType.VarChar);
            param[2].Value = dir;


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "editUsuario";
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
            cmd.CommandText = "eliminarUsuario";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);
        }

        public void insertarCliente(String nombre, String apellido, String contra, String tel, String dir)
        {

            Console.WriteLine(contra);

            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("@Pnombre", SqlDbType.VarChar);
                param[0].Value = nombre;
                param[1] = new SqlParameter("@Papellido", SqlDbType.VarChar);
                param[1].Value = apellido;
                param[2] = new SqlParameter("@contra", SqlDbType.VarChar);
                param[2].Value = contra;
                param[3] = new SqlParameter("@direccion", SqlDbType.VarChar);
                param[3].Value = dir;
                param[4] = new SqlParameter("@telefono", SqlDbType.Char);
                param[4].Value = tel;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertarUsuario";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la insercion");
                return;
            }
        }

        }//-------
    }//-----------
