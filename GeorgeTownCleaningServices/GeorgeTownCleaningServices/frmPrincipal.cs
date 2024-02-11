namespace GeorgeTownCleaningServices
{
    public partial class frmPrincipal : Form
    {
        //Atributos

        //Constantes para los precios de los items

        const double priceOneShirt = 0.75;
        const double pricePairPants = 2.25;
        const double priceOneDress = 4.36;

        const double ITBIS = 0.18;

        //Variables para almacenar las cantidades de os items
        uint ShirtsQuantity;
        uint PantsQuantity;
        uint DressesQuantity;

        //Variables para almacenar la cantidad de impuestos y los totales netos y brutos
        double totalGros;
        double totalNet;
        double taxes;

        public frmPrincipal()
        {
            InitializeComponent();
            dtpOrderDate.MinDate = DateTime.Today;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Desabilitamos el boton de calcular hasta que se introduzcan cantidades a procesar
            btnCalculate.Enabled = false;

            //Cargamos los precios unitarios de los items
            txtShirtPrice.Text = priceOneShirt.ToString("C");
            txtPantsPrice.Text = pricePairPants.ToString("C");
            txtDressesPrice.Text = priceOneDress.ToString("C");
        }

        //private void frmPrincipal_MouseMove(object sender, MouseEventArgs e)
        //{
        //   this.Text = $"({MousePosition.X}, {MousePosition.Y})";
        // }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Salir de la aplicacion
            Application.Exit();
        }

        private void txtShirtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtShirtQuantity.Text.Length > 0 || txtPantsQuantity.TextLength > 0 || txtDressesQuantity.TextLength > 0)
            {
                btnCalculate.Enabled = true; //habilita el boton porque hay algun valor
            }
            else
            {
                btnCalculate.Enabled = false;
            }
        }

        private void txtShirtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Procesar la orden

            //capturar los datos del cliente
            string customerName = "";
            string customerPhone = "";
            //DateTime orderDate = "";

            double subTotalShirts;
            double subTotalPants = 0;
            double subTotalDresses = 0;

            //Vamos a calcular

            if (txtShirtQuantity.Text == string.Empty)
            {
                txtShirtQuantity.Text = "0";

            }
            if (txtPantsQuantity.Text == string.Empty)
            {
                txtPantsQuantity.Text = "0";
            }
            if (txtDressesQuantity.Text == string.Empty)
            {
                txtDressesQuantity.Text = "0";
            }


            if (txtCustomerName.Text == string.Empty || txtCustomerPhone.Text == string.Empty)
            {
                MessageBox.Show("Debe introducir su nombre y número de teléfono", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                customerName = txtCustomerName.Text;
                customerPhone = txtCustomerPhone.Text;

                ShirtsQuantity = Convert.ToUInt32(txtShirtQuantity.Text);
                PantsQuantity = Convert.ToUInt32(txtPantsQuantity.Text);
                DressesQuantity = Convert.ToUInt32(txtDressesQuantity.Text);

                subTotalShirts = ShirtsQuantity * priceOneShirt;
                txtSubtotalShirts.Text = subTotalShirts.ToString("C");
                subTotalPants = PantsQuantity * pricePairPants;
                txtSubtotalPants.Text = subTotalPants.ToString("C"); 
                subTotalDresses = DressesQuantity * priceOneDress;
                txtSubtotalDresses.Text = subTotalDresses.ToString("C");  

                totalGros = subTotalShirts + subTotalPants + subTotalDresses;
                taxes = totalGros * ITBIS;
                totalNet = totalGros + taxes;

                txtPrintClientName.Text = customerName;
                txtPrintPhone.Text = customerPhone;
                txtPrintShirtsSubtotal.Text = subTotalShirts.ToString("C");
                txtPrintPantsSubtotal.Text = subTotalPants.ToString("C");
                txtPrintDressesSubtotal.Text = subTotalDresses.ToString("C");
                txtPrintGross.Text = totalGros.ToString("C");
                txtPrintTaxes.Text = taxes.ToString("C");
                txtPrintNetTotal.Text = totalNet.ToString("C");
            }




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}

/*
 subTotalShirts = Convert.ToUInt32(txtShirtQuantity.Text) * priceOneShirt;
                //Completar los otros subtotales

                double totalGross = subTotalShirts + subTotalPants + subTotalDresses;

                //calcular el impuesto a pagar
                double taxes = ITBIS * totalGross;

                //Calcular el total neto
                double totalNet = totalGross + taxes;

                //Informar al cliente del total
                MessageBox.Show($"El total de su compra es {totalNet:C}", "Resume", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //pedir el pago
                double payment = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Digite el pago"));

                //Calcular la devuelta
                double difference = payment - totalNet;
 */
