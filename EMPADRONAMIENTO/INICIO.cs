using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPADRONAMIENTO
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }


        // --------------- BOTON DE CONSULTAR ------------------------------------------------
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Hide();
            frmConsultar formMain = new frmConsultar();
            formMain.ShowDialog(this);
            Show();
       
        }


        // --------------- BOTON DE EMPADRONAR ------------------------------------------------
        private void btnEmpadronar_Click_1(object sender, EventArgs e)
        {
            Hide();
            frmEmpadronar formMain = new frmEmpadronar();
            formMain.ShowDialog(this);
            Show();

        }



        // --------------- BOTON DE CERAR ------------------------------------------------
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this .Close();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
