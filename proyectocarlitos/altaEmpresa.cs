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
            if(txtDireccion.Text!="" && txtRFC.Text!="" && txtNombre.Text != "" && txtDescripcion.Text != "" && txtGiro.Text != "" && txtRepresentante.Text != ""
                && txtAreas.Text != "" && txtTelefono.Text != "" && cbcStatus.Text != "" && txtHorario.Text != "")
            {
                empresa.rfc = txtRFC.Text;
                empresa.nombre = txtNombre.Text;
                empresa.giro = txtGiro.Text;
                empresa.representantelegal = txtRepresentante.Text;
                empresa.direccion = txtDireccion.Text;
                
                try {
                    empresa.telefono = Convert.ToInt64(txtTelefono.Text);
                    empresa.areastrabajo = txtAreas.Text;
                    empresa.descripcion = txtDescripcion.Text;
                    empresa.horario = txtHorario.Text;
                    empresa.status = cbcStatus.Text;
                    empresa user = new empresa() { rfc = empresa.rfc, nombre = empresa.nombre, giro = empresa.giro, representantelegal = empresa.representantelegal, direccion = empresa.direccion, telefono = empresa.telefono, areastrabajo = empresa.areastrabajo, horario = empresa.horario, descripcion = empresa.descripcion, status = empresa.status};
                    if (Datos.instance.empresa(user))
                    {
                        MessageBox.Show("Empresa ha sido agregado exitosamente");
                        txtRFC.Text = "";
                        txtNombre.Text = "";
                        txtGiro.Text = "";
                        txtRepresentante.Text = "";
                        txtDireccion.Text = "";
                        txtTelefono.Text = "";
                        txtAreas.Text = "";
                        txtHorario.Text = "";
                        txtDescripcion.Text = "";
                        cbcStatus.Text = "";
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("El telefono es numérico", "¡Alerta!", MessageBoxButtons.OK);
                    Console.Out.WriteLine(ex.Message);
                    Console.Out.Write(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Favor de llenar todos los campos", "¡Alerta!", MessageBoxButtons.OK);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
