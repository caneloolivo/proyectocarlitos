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
    public partial class altaEmpresa : Form
    {
        empresa empresa;
        public altaEmpresa()
        {
            InitializeComponent();
            empresa = new empresa();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //hola putos

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="" && textBox2.Text!="" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != ""
                && textBox7.Text != "" && textBox8.Text != "" )
            {
                empresa.rfc = textBox2.Text;
                empresa.nombre = textBox3.Text;
                empresa.giro = textBox5.Text;
                empresa.representanteLegal = textBox6.Text;
                empresa.direccion = textBox1.Text;
                try {
                    int telefono=Convert.ToInt32(textBox8.Text);
                    empresa.telefono = telefono;
                    empresa.areaTrabajo = textBox7.Text;
                    empresa.descripcion = textBox4.Text;
                    MessageBox.Show("Empresa Agregada", "¡Alerta!", MessageBoxButtons.OK);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                }
                catch(Exception ex)
                {
                    MessageBox.Show("El telefono es numérico", "¡Alerta!", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Favor de llenar todos los campos", "¡Alerta!", MessageBoxButtons.OK);
            }
        }
    }
}
