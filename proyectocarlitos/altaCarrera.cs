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
            try
            {
                int idCarrera = Convert.ToInt32(textBox5.Text);
                carrera.idCarrera = idCarrera;
                carrera.nombre = textBox1.Text;
                try
                {
                    
                }
                catch(Exception ex)
                {

                }
            }catch(Exception ex)
            {
                MessageBox.Show("ID de carrera es numerico")
            }
        }
    }
}
