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

            if (txtNombre.Text!="" && txtPaterno.Text != "" && txtMaterno.Text != "" && txtCarrera.Text != "" && txtRegistro.Text != ""
                && txtDomicilio.Text != "" && txtPeriodo.Text != "" && txtCorreo.Text != "" && txtTelefono.Text != "" && txtContacto.Text != ""
                && txtNumCon.Text != "")
            {
                try
                {
                    int registro = Convert.ToInt32(txtRegistro.Text);
                    alumno.registro = registro;
                    alumno.nombre = txtNombre.Text;
                    alumno.aPaterno = txtPaterno.Text;
                    alumno.aMaterno = txtMaterno.Text;
                    alumno.domicilio = txtDomicilio.Text;
                    if (Regex.IsMatch(txtCorreo.Text, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")) {
                        alumno.correo = txtCorreo.Text;
                        alumno.carrera = txtCarrera.Text;
                        try
                        {
                            int periodo = Convert.ToInt32(txtPeriodo.Text);
                            alumno.periodo = periodo;
                            try
                            {
                                double telefono = Convert.ToInt64(txtTelefono.Text);
                                alumno.telefono = (int)telefono;
                                alumno.contactoemergencia = txtContacto.Text;
                                alumno.contrasena = txtPass.Text;
                                try
                                {
                                    double telefonoE = Convert.ToInt64(txtNumCon.Text);
                                    alumno.numemergencia =(int) telefonoE;
                                    alumno user = new alumno() { registro = alumno.registro, nombre = alumno.nombre, aPaterno = alumno.aPaterno, aMaterno = alumno.aMaterno, domicilio = alumno.domicilio, correo = alumno.correo, periodo = alumno.periodo, telefono = alumno.telefono, contrasena = alumno.contrasena, contactoemergencia = alumno.contactoemergencia, numemergencia = alumno.numemergencia, carrera = alumno.carrera};
                                    if (datos.instance.alumno(user))
                                    {
                                        MessageBox.Show("Usuario ha sido agregado exitosamente");
                                        txtRegistro.Text = " ";
                                        txtNombre.Text = " ";
                                        txtPaterno.Text = "";
                                        txtMaterno.Text = "";
                                        txtDomicilio.Text = "";
                                        txtCorreo.Text = "";
                                        txtPeriodo.Text = "";
                                        txtTelefono.Text = "";
                                        txtPass.Text = "";
                                        txtContacto.Text = "";
                                        txtNumCon.Text = "";
                                        txtCarrera.Text = "";
                                    }

                                    
                                }
                                catch(Exception ex)
                                {
                                    MessageBox.Show("El teléfono de Emergencia es numérico", "¡Advertencia!", MessageBoxButtons.OK);
                                    Console.Out.WriteLine(ex.Message);
                                }

                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show("El teléfono es numérico", "¡Advertencia!", MessageBoxButtons.OK);
                                Console.Out.WriteLine(ex.Message);
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Periodo numérico, ejemplo 201601", "¡Advertencia!", MessageBoxButtons.OK);
                            Console.Out.WriteLine(ex.Message);
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
                }
                
            }
            else
            {
                MessageBox.Show("Favor de llenar todos los campos", "¡Alerta!", MessageBoxButtons.OK);
            }

        }
    }
}
