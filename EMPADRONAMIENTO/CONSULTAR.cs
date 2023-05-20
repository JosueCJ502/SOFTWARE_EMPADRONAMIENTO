using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//LIBRERIA PARA SQL
using System.Data.SqlClient;

namespace EMPADRONAMIENTO
{
    public partial class frmConsultar : Form
    {
        public frmConsultar()
        {
            InitializeComponent();
        }
        //CONEXCION CON BD SQL
        string CONEXION = "Data Source=JOSUECJ;Initial Catalog=EMPADRONATE;Integrated Security=True";
        private void frmConsultar_Load(object sender, EventArgs e)
        {

        }

        // ---------------------------- BOTON REGRESAR --------------------------------------
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ----------------- BOTON MOSTRAR REGISTROS ------------------------------------------
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(CONEXION))
            {

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM REGISTRO", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dgvRegistros.DataSource = dt;

            }

        }
        // ----------------------  CONSULTA POR ID ----------------------
        private void btnConId_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(CONEXION))
            {

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM REGISTRO WHERE Id = '" + txtConsulta.Text + "'", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dgvRegistros.DataSource = dt;

            }
        }

        // ---------------------------------  CONSULTA POR NOMBRE --------------------------------------
        private void btnConNombre_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(CONEXION))
            {

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM REGISTRO WHERE Primer_Nombre LIKE '%' + '" + txtConsulta.Text + "' + '%' OR Segund_Nombre LIKE '%' + '" + txtConsulta + "' + '%' OR Tercer_Nombre LIKE '%' + '" + txtConsulta.Text + "' + '%'",  cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dgvRegistros.DataSource = dt;

            }
        }

        // ---------------------------------  CONSULTA POR APELLIDO --------------------------------------
        private void btnConApellido_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(CONEXION))
            {

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM REGISTRO WHERE Primer_Apellido LIKE '%' + '" + txtConsulta.Text + "' + '%' OR Segundo_Apellido LIKE '%' + '" + txtConsulta + "' + '%' ", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dgvRegistros.DataSource = dt;

            }

        }


        // ---------------------------------  CONSULTA POR CUI --------------------------------------
        private void btnConCUI_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(CONEXION))
            {

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM REGISTRO WHERE CUI LIKE '%' + '" + txtConsulta.Text + "' + '%'", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dgvRegistros.DataSource = dt;

            }

        }

        // ---------------------------------  CONSULTA POR MUNICIPIO --------------------------------------
        private void btnConMunicipio_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(CONEXION))
            {

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM REGISTRO WHERE Municipio_Residencia = '" + txtConsulta.Text + "'", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dgvRegistros.DataSource = dt;

            }

        }

        // ---------------------------------  CONSULTA POR DEPARTAMENTO --------------------------------------
        private void btnConDepartamento_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(CONEXION))
            {

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM REGISTRO WHERE Departamento_Residencia = '" + txtConsulta.Text + "'", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dgvRegistros.DataSource = dt;

            }
        }

        // ---------------------------------  CONSULTA POR CORREO --------------------------------------
        private void btnConCorreo_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(CONEXION))
            {

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM REGISTRO WHERE Correo_Electronico = '" + txtConsulta.Text + "'", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dgvRegistros.DataSource = dt;

            }
        }

        private void btnConPais_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(CONEXION))
            {

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM REGISTRO WHERE Nacionalidad LIKE '%' + '" + txtConsulta.Text + "' + '%'", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dgvRegistros.DataSource = dt;

            }

        }
    }
}
