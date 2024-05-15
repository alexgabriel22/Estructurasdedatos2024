using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARQUITECTURA
{
    public partial class Form1 : Form
    {
        Empleado myEmpleado = new Empleado();
        Nomina   myNomina = new Nomina();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAlmacenarRegistro_Click(object sender, EventArgs e)
        {
            // valida que se ingrese un dato
            if (txtNombre.Text =="")
            {
                error1.SetError(txtNombre, " debe ingresar un nombre");
                txtNombre.Focus();
                return;
            }
            error1.SetError(txtNombre, "");
            // validar que solo permita ingresar datos numericos
            decimal AsignacionDia;
            if (!Decimal.TryParse(txtAsignacionDia.Text, out AsignacionDia))
            {
                error1.SetError(txtAsignacionDia , " debe ingresar un numero");
                txtNombre.Focus();
                return;
            }
            error1.SetError(txtAsignacionDia, "");

            myEmpleado.Nombre = txtNombre .Text;
            myEmpleado.Identificacion = txtIdentificacion .Text;
            myEmpleado.AsignacionDia = txtAsignacionDia .Text;
            myNomina.DiasLaborados = Convert.ToInt32(txtDiaslaborados .Text);
            MessageBox.Show("SE GUARDO AUTOMATICAMENTE");

        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            txtTotalDevengado.Text = myNomina.CalcularNomina(Convert.ToInt32(myNomina.DiasLaborados),Convert.ToDecimal(myEmpleado.AsignacionDia)).ToString();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtIdentificacion.Clear();
            txtAsignacionDia.Clear();
            txtDiaslaborados.Clear();   
            txtTotalDevengado .Clear();
        }
    }
}
