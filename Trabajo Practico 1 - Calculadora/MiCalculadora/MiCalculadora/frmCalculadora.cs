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
    public partial class frmCalculadora : Form
    {
        
        public frmCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cierro el formulario previo a preguntar al usuario si desea cerrarlo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }


        }
        /// <summary>
        /// Valido que solo se escriban numeros en el text box 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '-' || e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo puede ingresar numeros!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// Valido que solo se escriban numeros en el text box 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '-' || e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo puede ingresar numeros y borrar con la opcion limpiar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
        /// <summary>
        /// Realiza la operacion y la muestra por el lael de resultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            

            if(cmbOperador.Items != null && !string.IsNullOrEmpty(txbNumero1.Text) && !string.IsNullOrEmpty(txbNumero2.Text))
            {
                Numero numero1 = new Numero(txbNumero1.Text);
                Numero numero2 = new Numero(txbNumero2.Text);
                this.lblResultado.Text = String.Format("{0:###,###,###,###.00}",Calculadora.Operar(numero1, numero2, cmbOperador.SelectedItem.ToString()));
            }
            else
            {
                MessageBox.Show("No puede haber casilleros vacios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        /// <summary>
        /// Limpia el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txbNumero1.Clear();
            this.txbNumero2.Clear();
            this.lblResultado.ResetText();
            this.cmbOperador.ResetText();

        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            double resultado;
            if(double.TryParse(lblResultado.Text, out resultado))
            {
                this.lblResultado.ResetText();
                this.lblResultado.Text = Numero.DecimalBinario(resultado);
            }

        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string strResultado;
            double resultado;
            if (!string.IsNullOrEmpty(lblResultado.Text) && !double.TryParse(lblResultado.Text, out resultado))
            {
                strResultado = lblResultado.Text.ToString();
                this.lblResultado.ResetText();
                this.lblResultado.Text = Numero.BinarioDecimal(strResultado).ToString();

                
            }
            
        }
    }
}