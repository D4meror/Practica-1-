using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Votos.Formularios.Usuario
{
    public partial class PanelDeVotacion : Form
    {
        private int y = 50;
        private int count = 1;
        public PanelDeVotacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void handlerComun_Click(object sender , EventArgs e)
        {
            Console.Beep(((Button)sender).Location.Y*10,100);
        }


        private void crearBoton()
        {
            Button temp = new Button();

            temp.Height = 23;
            temp.Width = 200;
            temp.Location = new Point(50, y);
            y += 25;
            temp.Name = base.Name;
            temp.Text = "Boton"+count;
            count++;

            temp.Click += new EventHandler(handlerComun_Click);

            Controls.Add(temp);
        }

    }
}
