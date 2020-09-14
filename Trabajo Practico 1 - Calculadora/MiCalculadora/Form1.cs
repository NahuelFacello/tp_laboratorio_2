using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numero numero1 = new Numero();
            Numero numero2 = new Numero();
            string operador = cmbOperador.Text;

            numero1.SetNumero = txtNum1.Text;
            numero2.SetNumero = txtNum2.Text;

            Calculadora calcular = new Calculadora();

           lblResultado.Text = (calcular.Operar(numero1, numero2, operador)).ToString();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            cmbOperador.Text = "";
            lblResultado.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnABinario_Click(object sender, EventArgs e)
        {
            Numero numeroAConvertir = new Numero();
            if(txtNum1.Text == ""|| txtNum2.Text == ""||cmbOperador.Text == "" || lblResultado.Text == "Realice una operacion")
            {
                lblResultado.Text = "Realice una operacion";
            }
            else
            {
                lblResultado.Text = numeroAConvertir.DecimalBinario(lblResultado.Text);
                
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnADecimal_Click(object sender, EventArgs e)
        {
            Numero numeroAConvertir = new Numero();
            if (txtNum1.Text == "" || txtNum2.Text == "" || cmbOperador.Text == "" || lblResultado.Text == "Realice una operacion")
            {
                lblResultado.Text = "Realice una operacion";
            }
            else
            {
                lblResultado.Text = numeroAConvertir.BinarioDecimal(lblResultado.Text);

            }
        }
    }
}
