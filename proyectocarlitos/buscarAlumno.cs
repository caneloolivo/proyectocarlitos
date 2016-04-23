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
    public partial class buscarAlumno : Form
    {
        
        public buscarAlumno()
        {
            InitializeComponent();
        }
        public alumno alumnoseleccionado { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            dataAlumno.DataSource = Datos.instance.buscarAlumnos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataAlumno.SelectedRows.Count == 1)
            {
                Int32 registro = Convert.ToInt32(dataAlumno.CurrentRow.Cells[0].Value);
                alumnoseleccionado = Datos.instance.ObtenerAlumno(registro);
                this.Close();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun Usuario");
            }
        }

        private void dataAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
