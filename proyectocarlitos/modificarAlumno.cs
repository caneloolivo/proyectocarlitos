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
    public partial class modificarAlumno : Form
    {
        
        public modificarAlumno()
        {
            InitializeComponent();
        }
        public alumno clienteActual { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            //:3 Fuck u
        }

        private void busquedaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarAlumno pbuscar = new buscarAlumno();
            pbuscar.ShowDialog();
            if (pbuscar.alumnoseleccionado != null)
            {
                clienteActual = pbuscar.alumnoseleccionado;
                lblRegistro.Text = Convert.ToString(pbuscar.alumnoseleccionado.registro);
                lblNombre.Text = pbuscar.alumnoseleccionado.nombre;
                lblPaterno.Text = pbuscar.alumnoseleccionado.aPaterno;
                lblMaterno.Text = pbuscar.alumnoseleccionado.aMaterno;
                txtDomicilio.Text = pbuscar.alumnoseleccionado.domicilio;
                txtCorreo.Text = pbuscar.alumnoseleccionado.correo;
                txtPeriodo.Text = Convert.ToString(pbuscar.alumnoseleccionado.periodo);
                txtTelefono.Text = Convert.ToString(pbuscar.alumnoseleccionado.telefono);
                txtPass.Text = pbuscar.alumnoseleccionado.contrasena;
                txtContacto.Text = pbuscar.alumnoseleccionado.contactoemergencia;
                txtTelEme.Text = Convert.ToString(pbuscar.alumnoseleccionado.numemergencia);
                txtCarrera.Text = pbuscar.alumnoseleccionado.carrera;
               
            }
            //this.Hide();
        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show(this);
        }

        private void modificarAlumno_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void lblMaterno_Click(object sender, EventArgs e)
        {

        }

        private void lblPaterno_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            alumno user = new alumno();
            user.registro = Convert.ToInt32(lblRegistro.Text);
            user.nombre = lblNombre.Text;
            user.aPaterno = lblPaterno.Text;
            user.aMaterno = lblMaterno.Text;
            user.domicilio = txtDomicilio.Text;
            user.correo = txtCorreo.Text;
            user.periodo = Convert.ToInt32(txtPeriodo.Text);
            user.telefono = Convert.ToInt32(txtTelefono.Text);
            user.contrasena = txtPass.Text;
            user.contactoemergencia = txtContacto.Text;
            user.numemergencia = Convert.ToInt64(txtTelEme.Text);
            user.carrera = txtCarrera.Text;

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
                MessageBox.Show("Cliente NO Modificado");
        }

        private void txtTelEme_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPeriodo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtDomicilio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtCarrera_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
