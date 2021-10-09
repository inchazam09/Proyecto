using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Negocio;

namespace Sistema.UI
{
    public partial class IngresarTorneos : Form
    {
        private Funcionario funcionarito;

        public IngresarTorneos()
        {
            InitializeComponent();
        }

        private void rdbEstudiante_Click(object sender, EventArgs e)
        {
            // COMPONENTES DE ESTUDIANTE
            this.lblCantidadMaterias.Enabled = true;
            this.mskCantidadMaterias.Enabled = true;
            this.lblpremio.Enabled = true;
            this.lblDolarEstudiante.Enabled = true;
            this.txtPago.Enabled = true;

            // COMPONENTES DEL FUNCIONARIO
            this.lblPerfil.Enabled = false;
            this.cmbPerfil.Enabled = false;
            this.lblSalario.Enabled = false;
            this.lblDolarFuncionario.Enabled = false;
            this.txtSalario.Enabled = false;
            limpiar();
        }

        private void rdbFuncionario_Click(object sender, EventArgs e)
        {
            // COMPONENTES DEL FUNCIONARIO
            this.lblPerfil.Enabled = true;
            this.cmbPerfil.Enabled = true;
            this.lblSalario.Enabled = true;
            this.lblDolarFuncionario.Enabled = true;
            this.txtSalario.Enabled = true;

            // COMPONENTES DE ESTUDIANTE
            this.lblCantidadMaterias.Enabled = false;
            this.mskCantidadMaterias.Enabled = false;
            this.lblpremio.Enabled = false;
            this.lblDolarEstudiante.Enabled = false;
            this.txtPago.Enabled = false;
            limpiar();
        }

        public void limpiar() {
            this.mskCantidadMaterias.Clear();
            this.txtPago.Clear();
            this.cmbPerfil.SelectedIndex = -1;
            this.txtSalario.Clear();
        }

        private void mskCantidadMaterias_TextChanged(object sender, EventArgs e)
        {
            if (this.mskCantidadMaterias.Text != "")
                this.txtPago.Text = (125 * int.Parse(this.mskCantidadMaterias.Text)).ToString();
            else this.txtPago.Clear();
        }

        private void cmbPerfil_TextChanged(object sender, EventArgs e)
        {
            if (this.cmbPerfil.Text == "Plataforma")
                this.txtSalario.Text = "500";
            else if (this.cmbPerfil.Text == "Docente")
                this.txtSalario.Text = "1000";
            else if (this.cmbPerfil.Text == "Administrativo")
                this.txtSalario.Text = "1200";
            else if (this.cmbPerfil.Text == "Director")
                this.txtSalario.Text = "2000";
            else this.txtSalario.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.rdbEstudiante.Checked)
                agregarEstudiante();
            else if (this.rdbFuncionario.Checked)
                agregarFuncionario();
            else MessageBox.Show("Debe seleccionar un tipo");
        }

        private void agregarFuncionario()
        {
            try
            {
                funcionarito = new Funcionario(this.txtNombre.Text, this.mskCedula.Text, this.dtpfechatorneo.Value,
                   this.cmbPerfil.Text, double.Parse(this.txtSalario.Text));
                Gestor.agregarFuncionario(funcionarito);
                MessageBox.Show("Funcionario agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void agregarEstudiante()
        {
            
        }
    }
}
