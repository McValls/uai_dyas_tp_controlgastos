namespace TP_DYAS_Control_Gastos_2025
{
    partial class SimuladorPrestamoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.saldoTotalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tipoDeCambio = new System.Windows.Forms.TextBox();
            this.configuracionPrestamoComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.calcularPrestamoMaximoButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tasaInteresTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.montoAPrestarTextBox = new System.Windows.Forms.TextBox();
            this.valorCuotaTextBox = new System.Windows.Forms.TextBox();
            this.cantidadCuotasTextBox = new System.Windows.Forms.TextBox();
            this.totalADevolverTextBox = new System.Windows.Forms.TextBox();
            this.recalcularBtn = new System.Windows.Forms.Button();
            this.solicitarPrestamoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo últimos 12 meses (ingresos - egresos)";
            // 
            // saldoTotalTextBox
            // 
            this.saldoTotalTextBox.Enabled = false;
            this.saldoTotalTextBox.Location = new System.Drawing.Point(294, 29);
            this.saldoTotalTextBox.Name = "saldoTotalTextBox";
            this.saldoTotalTextBox.ReadOnly = true;
            this.saldoTotalTextBox.Size = new System.Drawing.Size(193, 20);
            this.saldoTotalTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de Cambio (USD)";
            // 
            // tipoDeCambio
            // 
            this.tipoDeCambio.Enabled = false;
            this.tipoDeCambio.Location = new System.Drawing.Point(294, 55);
            this.tipoDeCambio.Name = "tipoDeCambio";
            this.tipoDeCambio.ReadOnly = true;
            this.tipoDeCambio.Size = new System.Drawing.Size(80, 20);
            this.tipoDeCambio.TabIndex = 5;
            // 
            // configuracionPrestamoComboBox
            // 
            this.configuracionPrestamoComboBox.FormattingEnabled = true;
            this.configuracionPrestamoComboBox.Location = new System.Drawing.Point(294, 81);
            this.configuracionPrestamoComboBox.Name = "configuracionPrestamoComboBox";
            this.configuracionPrestamoComboBox.Size = new System.Drawing.Size(80, 21);
            this.configuracionPrestamoComboBox.TabIndex = 6;
            this.configuracionPrestamoComboBox.SelectedIndexChanged += new System.EventHandler(this.configuracionPrestamoComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Plazo (Meses)";
            // 
            // calcularPrestamoMaximoButton
            // 
            this.calcularPrestamoMaximoButton.Location = new System.Drawing.Point(294, 139);
            this.calcularPrestamoMaximoButton.Name = "calcularPrestamoMaximoButton";
            this.calcularPrestamoMaximoButton.Size = new System.Drawing.Size(193, 23);
            this.calcularPrestamoMaximoButton.TabIndex = 8;
            this.calcularPrestamoMaximoButton.Text = "Calcular Préstamo Máximo";
            this.calcularPrestamoMaximoButton.UseVisualStyleBackColor = true;
            this.calcularPrestamoMaximoButton.Click += new System.EventHandler(this.calcularPrestamoButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tasa de Interés";
            // 
            // tasaInteresTextBox
            // 
            this.tasaInteresTextBox.Enabled = false;
            this.tasaInteresTextBox.Location = new System.Drawing.Point(294, 108);
            this.tasaInteresTextBox.Name = "tasaInteresTextBox";
            this.tasaInteresTextBox.ReadOnly = true;
            this.tasaInteresTextBox.Size = new System.Drawing.Size(80, 20);
            this.tasaInteresTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Monto a prestar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total a devolver";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Valor cuota";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cantidad de cuotas";
            // 
            // montoAPrestarTextBox
            // 
            this.montoAPrestarTextBox.Location = new System.Drawing.Point(294, 181);
            this.montoAPrestarTextBox.Name = "montoAPrestarTextBox";
            this.montoAPrestarTextBox.Size = new System.Drawing.Size(193, 20);
            this.montoAPrestarTextBox.TabIndex = 15;
            // 
            // valorCuotaTextBox
            // 
            this.valorCuotaTextBox.Enabled = false;
            this.valorCuotaTextBox.Location = new System.Drawing.Point(294, 207);
            this.valorCuotaTextBox.Name = "valorCuotaTextBox";
            this.valorCuotaTextBox.ReadOnly = true;
            this.valorCuotaTextBox.Size = new System.Drawing.Size(193, 20);
            this.valorCuotaTextBox.TabIndex = 16;
            // 
            // cantidadCuotasTextBox
            // 
            this.cantidadCuotasTextBox.Enabled = false;
            this.cantidadCuotasTextBox.Location = new System.Drawing.Point(294, 233);
            this.cantidadCuotasTextBox.Name = "cantidadCuotasTextBox";
            this.cantidadCuotasTextBox.ReadOnly = true;
            this.cantidadCuotasTextBox.Size = new System.Drawing.Size(80, 20);
            this.cantidadCuotasTextBox.TabIndex = 17;
            // 
            // totalADevolverTextBox
            // 
            this.totalADevolverTextBox.Enabled = false;
            this.totalADevolverTextBox.Location = new System.Drawing.Point(294, 259);
            this.totalADevolverTextBox.Name = "totalADevolverTextBox";
            this.totalADevolverTextBox.ReadOnly = true;
            this.totalADevolverTextBox.Size = new System.Drawing.Size(193, 20);
            this.totalADevolverTextBox.TabIndex = 18;
            // 
            // recalcularBtn
            // 
            this.recalcularBtn.Location = new System.Drawing.Point(493, 179);
            this.recalcularBtn.Name = "recalcularBtn";
            this.recalcularBtn.Size = new System.Drawing.Size(88, 22);
            this.recalcularBtn.TabIndex = 19;
            this.recalcularBtn.Text = "Recalcular";
            this.recalcularBtn.UseVisualStyleBackColor = true;
            this.recalcularBtn.Click += new System.EventHandler(this.recalcularBtn_Click);
            // 
            // solicitarPrestamoBtn
            // 
            this.solicitarPrestamoBtn.Location = new System.Drawing.Point(294, 285);
            this.solicitarPrestamoBtn.Name = "solicitarPrestamoBtn";
            this.solicitarPrestamoBtn.Size = new System.Drawing.Size(193, 51);
            this.solicitarPrestamoBtn.TabIndex = 20;
            this.solicitarPrestamoBtn.Text = "Solicitar Préstamo";
            this.solicitarPrestamoBtn.UseVisualStyleBackColor = true;
            this.solicitarPrestamoBtn.Click += new System.EventHandler(this.solicitarPrestamoBtn_Click);
            // 
            // SimuladorPrestamoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.solicitarPrestamoBtn);
            this.Controls.Add(this.recalcularBtn);
            this.Controls.Add(this.totalADevolverTextBox);
            this.Controls.Add(this.cantidadCuotasTextBox);
            this.Controls.Add(this.valorCuotaTextBox);
            this.Controls.Add(this.montoAPrestarTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tasaInteresTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calcularPrestamoMaximoButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.configuracionPrestamoComboBox);
            this.Controls.Add(this.tipoDeCambio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saldoTotalTextBox);
            this.Controls.Add(this.label1);
            this.Name = "SimuladorPrestamoForm";
            this.Text = "SimuladorPrestamo";
            this.Load += new System.EventHandler(this.SimuladorPrestamoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox saldoTotalTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tipoDeCambio;
        private System.Windows.Forms.ComboBox configuracionPrestamoComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calcularPrestamoMaximoButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tasaInteresTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox montoAPrestarTextBox;
        private System.Windows.Forms.TextBox valorCuotaTextBox;
        private System.Windows.Forms.TextBox cantidadCuotasTextBox;
        private System.Windows.Forms.TextBox totalADevolverTextBox;
        private System.Windows.Forms.Button recalcularBtn;
        private System.Windows.Forms.Button solicitarPrestamoBtn;
    }
}