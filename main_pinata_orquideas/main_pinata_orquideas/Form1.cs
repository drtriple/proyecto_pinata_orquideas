using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libOpeDescVta;

namespace main_pinata_orquideas
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Methods Me
        private void mensaje(string txt)
        { 
            if (txt == null)
            {
                MessageBox.Show(txt);
            }
        }

        private void llenarCombo()
        {
            this.cmbProducto.Items.Add("Seleccione un producto"); // Index = 0
            this.cmbProducto.Items.Add("Producto 1"); // Index = 1
            this.cmbProducto.Items.Add("Producto 2"); // Index = 2
            this.cmbProducto.Items.Add("Producto 3"); // Index = 3
            this.cmbProducto.Items.Add("Producto 4"); // Index = 4
            this.cmbProducto.Items.Add("Producto 5"); // Index = 5
            this.cmbProducto.Items.Add("Producto 6"); // Index = 6
            this.cmbProducto.SelectedIndex = 0;
        }
        #endregion

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                int intCanti, intCodi;
                float fltVrD, fltVI;

                intCanti = Convert.ToInt32(this.txtCant.Text);

                int i = cmbProducto.SelectedIndex;

                switch (i)
                {
                    case 1:
                        intCodi = 110; break;
                    case 2:
                        intCodi = 115; break;
                    case 3:
                        intCodi = 120; break;
                    case 4:
                        intCodi = 125; break;
                    case 5:
                        intCodi = 130; break;
                    case 6:
                        intCodi = 135; break;
                     default:
                        mensaje("Codigo del producto no válido");
                        return;
                }

                fltVrD = Convert.ToSingle(this.txtVDocena.Text);
                fltVI = Convert.ToSingle(this.txtIVA.Text);

                clsOpeDescVta op = new clsOpeDescVta();
                op.Codigo = intCodi;
                op.Cantidad = intCanti;
                op.vrDocena = fltVrD;
                op.porcIva = fltVI;

                //Invocacion Tto de Error
                if (!op.Facturar())
                {
                    mensaje(op.Error);
                    op = null;
                    return;
                }
                this.lblSubtotal.Text = op.subTotal.ToString();
                this.lblPorcDscto.Text = op.porcDscto.ToString();
                this.lblVrDscto.Text = op.vrDscto.ToString();
                this.lblVrIVA.Text = op.vrIVA.ToString();
                this.lblTotAPag.Text = op.totalAPagar.ToString();
                
                // Hacer visible el GroupBox
                this.grpAPagar.Visible = true;
                op = null;
            }
            catch (Exception ex)
            {
                mensaje(ex.Message);
                throw;
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Restablecer ComboBox al primer elemento
            cmbProducto.SelectedIndex = 0;

            // Limpiar los TextBox
            txtVDocena.Clear();
            txtCant.Clear();
            txtIVA.Clear();

            // Enviar el foco al ComboBox
            cmbProducto.Focus();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            llenarCombo();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbProducto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            float fltVrD = 0;
            int i = cmbProducto.SelectedIndex;

            switch (i)
            {
                case 1:
                    fltVrD = 1500; break;
                case 2:
                    fltVrD = 5000; break;
                case 3:
                    fltVrD = 1100; break;
                case 4:
                    fltVrD = 1000; break;
                case 5:
                    fltVrD = 3000; break;
                case 6:
                    fltVrD = 1750; break;
            }
            this.txtVDocena.Text = Convert.ToString(fltVrD * 12f);
        }
    }
}
