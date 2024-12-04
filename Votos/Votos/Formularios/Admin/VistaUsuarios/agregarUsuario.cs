using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Votos.Clases.Logica;

namespace Votos.Formularios.Admin.VistaUsuarios
{
    public partial class agregarUsuario : Form
    {
        bool antecedentes;
        public agregarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) { antecedentes = true; }
            else{antecedentes = false;}


            AdministracionUsuarios.ingresaUsuarios(textBox1.Text,textBox2.Text ,Convert.ToInt32(textBox3.Text),dateTimePicker1.Text,antecedentes);
        }
    }
}
