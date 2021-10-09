using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.UI
{
    public partial class Principal : Form
    {
        private IngresarJugadores registrarJugadores;
        private MostrarJugadores mostrarJugadores;
        private IngresarEquipo ingresarEquipo;
        private MostrarEquipo mostrarEquipo;
        private IngresarTorneos ingresarTorneos;
        private MostrarTorneos mostrarTorneos;
        private IngresarUsuarios ingresarUsuarios;
        private MostrarUsuarios mostrarUsuarios;
        private Acercade Acercade;

        public Principal()
        {
            InitializeComponent();
        }

       

        private void reIngresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void mostrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ingresarTorneos = new IngresarTorneos();
            ingresarTorneos.MdiParent = this;
            ingresarTorneos.Show();
        }

        private void mostrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            mostrarTorneos = new MostrarTorneos();
            mostrarTorneos.MdiParent = this;
            mostrarTorneos.Show();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ingresarUsuarios = new IngresarUsuarios();
            ingresarUsuarios.MdiParent = this;
            ingresarUsuarios.Show();
        }

        private void mostrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            mostrarUsuarios = new MostrarUsuarios();
            mostrarTorneos.MdiParent = this;
            mostrarTorneos.Show();
        }

        private void AcercadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Acercade = new Acercade();
            Acercade.MdiParent = this;
            Acercade.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
