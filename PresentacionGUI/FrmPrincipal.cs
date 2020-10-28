using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroPersona frmRegistroPersona = new FrmRegistroPersona();
            frmRegistroPersona.Show();
        }
    }
}
