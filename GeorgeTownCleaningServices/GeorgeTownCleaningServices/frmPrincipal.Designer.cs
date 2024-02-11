namespace GeorgeTownCleaningServices
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dtpOrderDate = new DateTimePicker();
            txtCustomerPhone = new TextBox();
            txtCustomerName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtSubtotalDresses = new TextBox();
            txtSubtotalPants = new TextBox();
            txtSubtotalShirts = new TextBox();
            label10 = new Label();
            txtDressesPrice = new TextBox();
            txtPantsPrice = new TextBox();
            txtShirtPrice = new TextBox();
            label9 = new Label();
            txtDressesQuantity = new TextBox();
            txtPantsQuantity = new TextBox();
            txtShirtQuantity = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnCalculate = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            label11 = new Label();
            groupBox3 = new GroupBox();
            label14 = new Label();
            txtPrintPhone = new Label();
            label13 = new Label();
            txtPrintClientName = new Label();
            label12 = new Label();
            txtPrintShirtsSubtotal = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            txtPrintTotalGross = new Label();
            label18 = new Label();
            txtPrintTaxes = new Label();
            label19 = new Label();
            txtPrintTotalNet = new Label();
            txtPrintPantsSubtotal = new Label();
            txtPrintDressesSubtotal = new Label();
            txtPrintGross = new Label();
            txtPrintTaxesInvoice = new Label();
            txtPrintNetTotal = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpOrderDate);
            groupBox1.Controls.Add(txtCustomerPhone);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(28, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(525, 159);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Information";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(161, 100);
            dtpOrderDate.MinDate = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(295, 26);
            dtpOrderDate.TabIndex = 5;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Location = new Point(162, 68);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(294, 26);
            txtCustomerPhone.TabIndex = 4;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(161, 30);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(295, 26);
            txtCustomerName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F);
            label3.Location = new Point(20, 100);
            label3.Name = "label3";
            label3.Size = new Size(86, 18);
            label3.TabIndex = 1;
            label3.Text = "Order Date:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F);
            label2.Location = new Point(20, 65);
            label2.Name = "label2";
            label2.Size = new Size(126, 18);
            label2.TabIndex = 2;
            label2.Text = "Customer's Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F);
            label1.Location = new Point(20, 33);
            label1.Name = "label1";
            label1.Size = new Size(125, 18);
            label1.TabIndex = 1;
            label1.Text = "Customer's Name";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSubtotalDresses);
            groupBox2.Controls.Add(txtSubtotalPants);
            groupBox2.Controls.Add(txtSubtotalShirts);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtDressesPrice);
            groupBox2.Controls.Add(txtPantsPrice);
            groupBox2.Controls.Add(txtShirtPrice);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtDressesQuantity);
            groupBox2.Controls.Add(txtPantsQuantity);
            groupBox2.Controls.Add(txtShirtQuantity);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(28, 258);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(525, 172);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Items";
            // 
            // txtSubtotalDresses
            // 
            txtSubtotalDresses.Location = new Point(367, 131);
            txtSubtotalDresses.Name = "txtSubtotalDresses";
            txtSubtotalDresses.RightToLeft = RightToLeft.Yes;
            txtSubtotalDresses.Size = new Size(78, 26);
            txtSubtotalDresses.TabIndex = 15;
            txtSubtotalDresses.TextChanged += textBox3_TextChanged;
            // 
            // txtSubtotalPants
            // 
            txtSubtotalPants.Location = new Point(367, 93);
            txtSubtotalPants.Name = "txtSubtotalPants";
            txtSubtotalPants.RightToLeft = RightToLeft.Yes;
            txtSubtotalPants.Size = new Size(78, 26);
            txtSubtotalPants.TabIndex = 14;
            // 
            // txtSubtotalShirts
            // 
            txtSubtotalShirts.Location = new Point(367, 58);
            txtSubtotalShirts.Name = "txtSubtotalShirts";
            txtSubtotalShirts.RightToLeft = RightToLeft.Yes;
            txtSubtotalShirts.Size = new Size(78, 26);
            txtSubtotalShirts.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(367, 36);
            label10.Name = "label10";
            label10.Size = new Size(79, 18);
            label10.TabIndex = 12;
            label10.Text = "SubTotal:";
            label10.Click += label10_Click;
            // 
            // txtDressesPrice
            // 
            txtDressesPrice.Location = new Point(254, 131);
            txtDressesPrice.Name = "txtDressesPrice";
            txtDressesPrice.RightToLeft = RightToLeft.Yes;
            txtDressesPrice.Size = new Size(78, 26);
            txtDressesPrice.TabIndex = 11;
            // 
            // txtPantsPrice
            // 
            txtPantsPrice.Location = new Point(254, 93);
            txtPantsPrice.Name = "txtPantsPrice";
            txtPantsPrice.RightToLeft = RightToLeft.Yes;
            txtPantsPrice.Size = new Size(78, 26);
            txtPantsPrice.TabIndex = 10;
            // 
            // txtShirtPrice
            // 
            txtShirtPrice.Location = new Point(254, 58);
            txtShirtPrice.Name = "txtShirtPrice";
            txtShirtPrice.RightToLeft = RightToLeft.Yes;
            txtShirtPrice.Size = new Size(78, 26);
            txtShirtPrice.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(254, 36);
            label9.Name = "label9";
            label9.Size = new Size(87, 18);
            label9.TabIndex = 8;
            label9.Text = "Unit Price:";
            // 
            // txtDressesQuantity
            // 
            txtDressesQuantity.Location = new Point(126, 131);
            txtDressesQuantity.Name = "txtDressesQuantity";
            txtDressesQuantity.Size = new Size(78, 26);
            txtDressesQuantity.TabIndex = 7;
            txtDressesQuantity.TextChanged += txtShirtQuantity_TextChanged;
            txtDressesQuantity.KeyPress += txtShirtQuantity_KeyPress;
            // 
            // txtPantsQuantity
            // 
            txtPantsQuantity.Location = new Point(126, 93);
            txtPantsQuantity.Name = "txtPantsQuantity";
            txtPantsQuantity.Size = new Size(78, 26);
            txtPantsQuantity.TabIndex = 6;
            txtPantsQuantity.TextChanged += txtShirtQuantity_TextChanged;
            txtPantsQuantity.KeyPress += txtShirtQuantity_KeyPress;
            // 
            // txtShirtQuantity
            // 
            txtShirtQuantity.Location = new Point(126, 58);
            txtShirtQuantity.Name = "txtShirtQuantity";
            txtShirtQuantity.Size = new Size(78, 26);
            txtShirtQuantity.TabIndex = 5;
            txtShirtQuantity.TextChanged += txtShirtQuantity_TextChanged;
            txtShirtQuantity.KeyPress += txtShirtQuantity_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(126, 36);
            label8.Name = "label8";
            label8.Size = new Size(78, 18);
            label8.TabIndex = 4;
            label8.Text = "Quantity:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 36);
            label7.Name = "label7";
            label7.Size = new Size(51, 18);
            label7.TabIndex = 3;
            label7.Text = "Items";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 139);
            label6.Name = "label6";
            label6.Size = new Size(65, 18);
            label6.TabIndex = 2;
            label6.Text = "Dresses:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 101);
            label5.Name = "label5";
            label5.Size = new Size(49, 18);
            label5.TabIndex = 1;
            label5.Text = "Pants:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 66);
            label4.Name = "label4";
            label4.Size = new Size(48, 18);
            label4.TabIndex = 0;
            label4.Text = "Shirts:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(27, 471);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(146, 53);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(223, 471);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(146, 53);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(407, 471);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(146, 53);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(223, 9);
            label11.Name = "label11";
            label11.Size = new Size(847, 64);
            label11.TabIndex = 5;
            label11.Text = "GeorgeTown Cleaning Services";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtPrintNetTotal);
            groupBox3.Controls.Add(txtPrintTaxesInvoice);
            groupBox3.Controls.Add(txtPrintGross);
            groupBox3.Controls.Add(txtPrintDressesSubtotal);
            groupBox3.Controls.Add(txtPrintPantsSubtotal);
            groupBox3.Controls.Add(txtPrintTotalNet);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(txtPrintTaxes);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(txtPrintTotalGross);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(txtPrintShirtsSubtotal);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(txtPrintPhone);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(txtPrintClientName);
            groupBox3.Controls.Add(label12);
            groupBox3.Location = new Point(604, 87);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(372, 374);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Invoice";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(15, 82);
            label14.Name = "label14";
            label14.Size = new Size(105, 18);
            label14.TabIndex = 4;
            label14.Text = "Shirts Subtotal:";
            // 
            // txtPrintPhone
            // 
            txtPrintPhone.AutoSize = true;
            txtPrintPhone.Location = new Point(68, 57);
            txtPrintPhone.Name = "txtPrintPhone";
            txtPrintPhone.Size = new Size(18, 18);
            txtPrintPhone.TabIndex = 3;
            txtPrintPhone.Text = "  ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 57);
            label13.Name = "label13";
            label13.Size = new Size(53, 18);
            label13.TabIndex = 2;
            label13.Text = "Phone:";
            // 
            // txtPrintClientName
            // 
            txtPrintClientName.AutoSize = true;
            txtPrintClientName.Location = new Point(68, 30);
            txtPrintClientName.Name = "txtPrintClientName";
            txtPrintClientName.Size = new Size(13, 18);
            txtPrintClientName.TabIndex = 1;
            txtPrintClientName.Text = " ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 30);
            label12.Name = "label12";
            label12.Size = new Size(47, 18);
            label12.TabIndex = 0;
            label12.Text = "Client:";
            // 
            // txtPrintShirtsSubtotal
            // 
            txtPrintShirtsSubtotal.AutoSize = true;
            txtPrintShirtsSubtotal.Location = new Point(166, 82);
            txtPrintShirtsSubtotal.Name = "txtPrintShirtsSubtotal";
            txtPrintShirtsSubtotal.Size = new Size(13, 18);
            txtPrintShirtsSubtotal.TabIndex = 5;
            txtPrintShirtsSubtotal.Text = " ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(15, 109);
            label15.Name = "label15";
            label15.Size = new Size(106, 18);
            label15.TabIndex = 6;
            label15.Text = "Pants Subtotal:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(16, 133);
            label16.Name = "label16";
            label16.Size = new Size(122, 18);
            label16.TabIndex = 7;
            label16.Text = "Dresses Subtotal:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(19, 172);
            label17.Name = "label17";
            label17.Size = new Size(88, 18);
            label17.TabIndex = 8;
            label17.Text = "Total Gross:";
            // 
            // txtPrintTotalGross
            // 
            txtPrintTotalGross.AutoSize = true;
            txtPrintTotalGross.Location = new Point(166, 172);
            txtPrintTotalGross.Name = "txtPrintTotalGross";
            txtPrintTotalGross.Size = new Size(13, 18);
            txtPrintTotalGross.TabIndex = 9;
            txtPrintTotalGross.Text = " ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(19, 214);
            label18.Name = "label18";
            label18.Size = new Size(54, 18);
            label18.TabIndex = 10;
            label18.Text = "Taxes:";
            // 
            // txtPrintTaxes
            // 
            txtPrintTaxes.AutoSize = true;
            txtPrintTaxes.Location = new Point(166, 214);
            txtPrintTaxes.Name = "txtPrintTaxes";
            txtPrintTaxes.Size = new Size(13, 18);
            txtPrintTaxes.TabIndex = 11;
            txtPrintTaxes.Text = " ";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(19, 250);
            label19.Name = "label19";
            label19.Size = new Size(74, 18);
            label19.TabIndex = 12;
            label19.Text = "Net Total:";
            // 
            // txtPrintTotalNet
            // 
            txtPrintTotalNet.AutoSize = true;
            txtPrintTotalNet.Location = new Point(166, 250);
            txtPrintTotalNet.Name = "txtPrintTotalNet";
            txtPrintTotalNet.Size = new Size(13, 18);
            txtPrintTotalNet.TabIndex = 13;
            txtPrintTotalNet.Text = " ";
            // 
            // txtPrintPantsSubtotal
            // 
            txtPrintPantsSubtotal.AutoSize = true;
            txtPrintPantsSubtotal.Location = new Point(166, 109);
            txtPrintPantsSubtotal.Name = "txtPrintPantsSubtotal";
            txtPrintPantsSubtotal.Size = new Size(13, 18);
            txtPrintPantsSubtotal.TabIndex = 14;
            txtPrintPantsSubtotal.Text = " ";
            // 
            // txtPrintDressesSubtotal
            // 
            txtPrintDressesSubtotal.AutoSize = true;
            txtPrintDressesSubtotal.Location = new Point(166, 133);
            txtPrintDressesSubtotal.Name = "txtPrintDressesSubtotal";
            txtPrintDressesSubtotal.Size = new Size(13, 18);
            txtPrintDressesSubtotal.TabIndex = 15;
            txtPrintDressesSubtotal.Text = " ";
            // 
            // txtPrintGross
            // 
            txtPrintGross.AutoSize = true;
            txtPrintGross.Location = new Point(166, 171);
            txtPrintGross.Name = "txtPrintGross";
            txtPrintGross.Size = new Size(13, 18);
            txtPrintGross.TabIndex = 16;
            txtPrintGross.Text = " ";
            // 
            // txtPrintTaxesInvoice
            // 
            txtPrintTaxesInvoice.AutoSize = true;
            txtPrintTaxesInvoice.Location = new Point(166, 214);
            txtPrintTaxesInvoice.Name = "txtPrintTaxesInvoice";
            txtPrintTaxesInvoice.Size = new Size(13, 18);
            txtPrintTaxesInvoice.TabIndex = 17;
            txtPrintTaxesInvoice.Text = " ";
            // 
            // txtPrintNetTotal
            // 
            txtPrintNetTotal.AutoSize = true;
            txtPrintNetTotal.Location = new Point(166, 250);
            txtPrintNetTotal.Name = "txtPrintNetTotal";
            txtPrintNetTotal.Size = new Size(13, 18);
            txtPrintNetTotal.TabIndex = 18;
            txtPrintNetTotal.Text = " ";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 641);
            Controls.Add(groupBox3);
            Controls.Add(label11);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnCalculate);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPrincipal";
            Text = "GeorgeTown Cleaning Services";
            Load += frmPrincipal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtCustomerName;
        private DateTimePicker dtpOrderDate;
        private TextBox txtCustomerPhone;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label10;
        private TextBox txtDressesPrice;
        private TextBox txtPantsPrice;
        private TextBox txtShirtPrice;
        private Label label9;
        private TextBox txtDressesQuantity;
        private TextBox txtPantsQuantity;
        private TextBox txtShirtQuantity;
        private TextBox txtSubtotalDresses;
        private TextBox txtSubtotalPants;
        private TextBox txtSubtotalShirts;
        private Button btnCalculate;
        private Button btnCancel;
        private Button btnExit;
        private Label label11;
        private GroupBox groupBox3;
        private Label label12;
        private Label txtPrintClientName;
        private Label txtPrintPhone;
        private Label label13;
        private Label label14;
        private Label txtPrintShirtsSubtotal;
        private Label label16;
        private Label label15;
        private Label txtPrintTotalNet;
        private Label label19;
        private Label txtPrintTaxes;
        private Label label18;
        private Label txtPrintTotalGross;
        private Label label17;
        private Label txtPrintGross;
        private Label txtPrintDressesSubtotal;
        private Label txtPrintPantsSubtotal;
        private Label txtPrintNetTotal;
        private Label txtPrintTaxesInvoice;
    }
}
