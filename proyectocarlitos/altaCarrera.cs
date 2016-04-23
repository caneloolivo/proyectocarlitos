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
    public partial class altaCarrera : Form
    {
        String periodo;
        carrera carrera;
        public altaCarrera()
        {
            InitializeComponent();
            //periodo = "";
            carrera = new carrera();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void altaCarrera_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           periodo = "Cuatrimestre";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           periodo = "Semestre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDirector.Text != "" && txtNombre.Text != "" && txtFacultad.Text != "" && txtTotalPeriodo.Text != "" && periodo != "" && cbcStatus.Text != "")
            {
                try
                {
                    //int idCarrera = Convert.ToInt32(txtID.Text);
                    //carrera.idCarrera = idCarrera;
                    carrera.director = txtDirector.Text;
                    try
                    {
                       carrera.totalPeriodo = Convert.ToInt32(txtTotalPeriodo.Text);
                       carrera.nombre = txtNombre.Text;
                       carrera.facultad = txtFacultad.Text;
                       carrera.estado = cbcStatus.Text;
                       carrera.tipoPeriodos = periodo;
                        carrera user = new carrera() { director = carrera.director, nombre = carrera.nombre, totalPeriodo = carrera.totalPeriodo, facultad = carrera.facultad, tipoPeriodos = carrera.tipoPeriodos, estado = carrera.estado };
                        if (Datos.instance.carrera(user))
                        {
                            MessageBox.Show("Carrera ha sido agregado exitosamente");
                            txtDirector.Text = "";
                            txtNombre.Text = "";
                            txtTotalPeriodo.Text = "";
                            txtFacultad.Text = "";
                            RBCuatri.Checked =false;
                            RBSemestre.Checked = false;
                            cbcStatus.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Total de periodos es numérico", "¡Alerta!", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("ID de carrera es numérico", "¡Alerta!", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Favor de llenar todos los campos", "¡Alerta!", MessageBoxButtons.OK);
            }
        }
    }
}
