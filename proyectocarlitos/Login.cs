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
    public partial class Login : Form
    {
     
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "" && textBox2.Text !="")
            {
                Form1 form = new Form1();
                form.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Favor de Poner Usuario Contraseña", "¡Advertencia!", MessageBoxButtons.OK);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

    }
}
