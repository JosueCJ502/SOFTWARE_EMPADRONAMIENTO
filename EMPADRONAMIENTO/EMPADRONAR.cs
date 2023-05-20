using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace EMPADRONAMIENTO
{
    public partial class frmEmpadronar : Form
    {

        

        public frmEmpadronar()
        {
            InitializeComponent();
        }
        //CONEXCION CON BD SQL
        string CONEXION = "Data Source=JOSUECJ;Initial Catalog=EMPADRONATE;Integrated Security=True";

        private void frmEmpadronar_Load(object sender, EventArgs e)
        {

        }
        // ----------------------- BOTON GUARDAR -----------------
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(CONEXION))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO REGISTRO(Id,Primer_Nombre, Segund_Nombre,Tercer_Nombre, Primer_Apellido,Segundo_Apellido,Apellido_Casada,CUI,Fecha_Nacimiento,Nacionalidad,Departamento_Residencia,Municipio_Residencia,Correo_Electronico,Confirmacion_Correo) VALUES ('" + txtId.Text + "', '" + txtNombre1.Text +"', '" + txtNombre2.Text + "', '" +txtNombre3.Text + "', '"+ txtApellido1.Text + "', '" + txtApellido2.Text + "','" + txtCasado.Text + "','" + txtCUI.Text + "','" + txtFecha.Text + "','" + txtPais.Text + "','" + txtDepartamento.Text + "','" + txtMunicipio.Text + "','" + txtCorreo.Text + "','" + txtConfrmacion.Text + "')", cn);
                cmd.CommandType = CommandType.Text;

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Exitoso");
            }
        }

        // --------------------------   BOTON MODIFICAR ------------------------------------
        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(CONEXION))
            {
                SqlCommand cmd = new SqlCommand("UPDATE REGISTRO SET Primer_Nombre = '" + txtNombre1.Text +"', Segund_Nombre = '" + txtNombre2.Text + "',Tercer_Nombre = '" +txtNombre3.Text + "', Primer_Apellido = '"+ txtApellido1.Text + "',Segundo_Apellido = '" + txtApellido2.Text + "',Apellido_Casada = '" + txtCasado.Text + "',CUI = '" + txtCUI.Text + "',Fecha_Nacimiento = '" + txtFecha.Text + "',Nacionalidad = '" + txtPais.Text + "',Departamento_Residencia = '" + txtDepartamento.Text + "',Municipio_Residencia = '" + txtMunicipio.Text + "',Correo_Electronico = '" + txtCorreo.Text + "', Confirmacion_Correo = '" + txtConfrmacion.Text + "' WHERE Id = '" + txtId.Text + "'", cn);


                cmd.CommandType = CommandType.Text;

                cn.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Modificarion Exitoso");
            }
        }




        // ------------------------- BOTON ELIMINAR -----------------------------
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(CONEXION))
            {

                SqlCommand cmd = new SqlCommand(" DELETE FROM REGISTRO WHERE Id = '" +txtId.Text + "' ", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro Eliminado");
            }
        }


        // --------------------- BOTON LIMPIAR --------------------------------------
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {

                if (c is TextBox)
                {
                    c.Text = "";
                    this.txtId.Focus();
                    this.txtNombre1.Focus();
                    this.txtNombre2.Focus();
                    this.txtNombre3.Focus();
                    this.txtApellido1.Focus();
                    this.txtApellido2.Focus();
                    this.txtCasado.Focus();
                    this.txtCUI.Focus();
                    this.txtFecha.Focus();
                    this.txtPais.Focus();
                    this.txtDepartamento.Focus();
                    this.txtMunicipio.Focus();
                    this.txtCorreo.Focus();
                    this.txtConfrmacion.Focus();
                }
            }
        }

        //  --------------------- BOTON REGRESAR ------------------------
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
