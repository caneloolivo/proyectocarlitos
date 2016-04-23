using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectocarlitos
{
    public partial class modificarCarrera : Form
    {
        String periodo;
        public modificarCarrera()
        {
            InitializeComponent();
        }
       

        private void modificarCarrera_Load(object sender, EventArgs e)
        {

        }

        private void buscarCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void rcuatri_CheckedChanged(object sender, EventArgs e)
        {
            periodo = "Cuatrimeste";
        }

        private void rsemestre_CheckedChanged(object sender, EventArgs e)
        {
            periodo = "Semestre";
        }

        private void busquedaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*carrera user = new carrera();
            user.director = txtDirector.Text;
            user.nombre = txtCarrera.Text;
            user.totalPeriodo = Convert.ToInt32(txtTotal.Text);
            user.facultad = lblFacultad.Text;
            user.tipoPeriodos = periodo;
            user.estado = cbcStatus.Text;


            int resultado = Datos.instance.updateAlumno(user);

            if (resultado > 0)
            {
                MessageBox.Show("Alumno Modificado con Exito", "Advertencia!", MessageBoxButtons.OK);
                lblRegistro.Text = "";
                lblNombre.Text = "";
                lblPaterno.Text = "";
                lblMaterno.Text = "";
                txtDomicilio.Text = "";
                txtCorreo.Text = "";
                txtPeriodo.Text = "";
                txtTelefono.Text = "";
                txtPass.Text = "";
                txtContacto.Text = "";
                txtTelEme.Text = "";
                txtCarrera.Text = "";
            }
            else
                MessageBox.Show("Cliente NO Modificado");*/
        }

        private void buscarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void busquedaAlumnoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
        //public carrera clienteActual { get; set; }
        private void busquedaCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*buscarCarrera pbuscar = new buscarCarrera();
            pbuscar.ShowDialog();
            if (pbuscar.carreraseleccionado != null)
            {
                clienteActual = pbuscar.carreraseleccionado;
                txtDirector.Text = pbuscar.carreraseleccionado.director;
                txtCarrera.Text = pbuscar.carreraseleccionado.nombre;
                txtTotal.Text = Convert.ToString(pbuscar.carreraseleccionado.totalPeriodo);
                lblFacultad.Text = pbuscar.carreraseleccionado.facultad;
                periodo = pbuscar.carreraseleccionado.tipoPeriodos;
                cbcStatus.Text = pbuscar.carreraseleccionado.estado;
            }
            //this.Hide();*/
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
