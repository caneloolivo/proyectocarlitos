using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectocarlitos
{
    public partial class altaAlumno : Form
    {
        alumno alumno;
        public altaAlumno()
        {
            InitializeComponent();
            alumno = new alumno();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //hola
        }

        private void altaAlumno_Load(object sender, EventArgs e)
        {
            // no sirve
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text!="" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != ""
                && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != ""
                && textBox11.Text != "")
            {

                try
                {
                    int registro = Convert.ToInt32(textBox5.Text);
                    alumno.registro = registro;
                    alumno.nombre = textBox1.Text;
                    alumno.aPaterno = textBox2.Text;
                    alumno.aMaterno = textBox3.Text;
                    alumno.domicilio = textBox6.Text;
                    if (Regex.IsMatch(textBox8.Text, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")) {
                        alumno.correo = textBox8.Text;
                        alumno.carrera = textBox4.Text;
                        try
                        {
                            int periodo = Convert.ToInt32(textBox7.Text);
                            alumno.periodo = periodo;
                            try
                            {
                                double telefono = Convert.ToInt64(textBox9.Text);
                                alumno.telefono = (int)telefono;
                                alumno.contactoemergencia = textBox10.Text;
                                try
                                {
                                    double telefonoE = Convert.ToInt64(textBox11.Text);
                                    alumno.telefonoContacto = (int)telefonoE;
                                    MessageBox.Show("Usuario Agregado", "¡Alerta!", MessageBoxButtons.OK);
                                    textBox1.Text = "";
                                    textBox2.Text = "";
                                    textBox3.Text = "";
                                    textBox4.Text = "";
                                    textBox5.Text = "";
                                    textBox6.Text = "";
                                    textBox7.Text = "";
                                    textBox8.Text = "";
                                    textBox9.Text = "";
                                    textBox10.Text = "";
                                    textBox11.Text = "";
                                }
                                catch(Exception ex)
                                {
                                    MessageBox.Show("El teléfono de Emergencia es numérico", "¡Advertencia!", MessageBoxButtons.OK);
                                    Console.Out.Write(ex.Message);
                                }

                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show("El teléfono es numérico", "¡Advertencia!", MessageBoxButtons.OK);
                                Console.Out.Write(ex.Message);
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Periodo numérico, ejemplo 201601", "¡Advertencia!", MessageBoxButtons.OK);
                            Console.Out.Write(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Favor de introudcir un correo válido", "¡Advertencia!");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("El registro es numérico","¡Alerta!",MessageBoxButtons.OK);
                    Console.Out.Write(ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Favor de llenar todos los campos", "¡Alerta!", MessageBoxButtons.OK);
            }
        }
    }
}
