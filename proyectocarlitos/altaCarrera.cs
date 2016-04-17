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
            periodo = "";
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
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && periodo != "")
            {
                try
                {
                    int idCarrera = Convert.ToInt32(textBox5.Text);
                    carrera.idCarrera = idCarrera;
                    carrera.director = textBox1.Text;
                    try
                    {
                        int periodos = Convert.ToInt32(textBox4.Text);
                        carrera.totalPeriodo = periodos;
                        carrera.nombre = textBox2.Text;
                        carrera.facultad = textBox3.Text;
                        carrera.tipoPeriodos = periodo;
                        MessageBox.Show("Carrera Agregada", "¡Alerta!", MessageBoxButtons.OK);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        periodo = "";
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Total de periodos es numérico", "¡Alerta!", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ID de carrera es numérico", "¡Alerta!", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Favor de llenar todos los campos", "¡Alerta!", MessageBoxButtons.OK);
            }
        }
    }
}
