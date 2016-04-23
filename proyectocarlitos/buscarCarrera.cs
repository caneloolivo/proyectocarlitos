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
    public partial class buscarCarrera : Form
    {
        public buscarCarrera()
        {
            InitializeComponent();
        }
        public carrera carreraseleccionado { get; set; }
        private void dataAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataCarrera.DataSource = Datos.instance.buscarAlumnos();
        }
    }
}
