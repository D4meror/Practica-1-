using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Votos.Formularios.Admin.VistaUsuarios;

namespace Votos.Formularios.Admin
{
    public partial class PanelAdmin : Form
    {
        public PanelAdmin()
        {
            InitializeComponent();
        }

        private void PanelAdmin_Load(object sender, EventArgs e)
        {
            Form frmPanelUsuarios = prepareTab(new PanelUsuarios());
            tabPage1.Controls.Add(frmPanelUsuarios);
        }
    
    private Form prepareTab(Form frm)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Visible = true;
            return frm;
        } 
    }
}
