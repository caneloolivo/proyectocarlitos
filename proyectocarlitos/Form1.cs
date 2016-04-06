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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void modificarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarAlumno form = new modificarAlumno();
            form.Show(this);
        }

        private void altaDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altaAlumno form = new altaAlumno();
            form.Show(this);
           
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Login form = new Login();
            form.Show(this);

            this.Hide();
            
        }

        private void altaRepresentanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altaRepresentante form = new altaRepresentante();
            form.Show(this);
        }

        private void altaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altaEmpresa form = new altaEmpresa();
            form.Show(this);
        }

        private void modificarRepresentanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarRepresentante form = new modificarRepresentante();
            form.Show(this);
        }

        private void modificarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarEmpresa form = new modificarEmpresa();
            form.Show(this);
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes form = new Reportes();
            form.Show(this);
        }
    }
}
