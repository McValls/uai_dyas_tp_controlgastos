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
            this.label2 = new System.Windows.Forms.Label();
            this.promedioGastos = new System.Windows.Forms.TextBox();
            this.promedioIngresos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tipoDeCambio = new System.Windows.Forms.TextBox();
            this.configuracionPrestamoComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.calcularPrestamoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Promedio de Gastos mensual de los últimos 12 meses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Promedio de Ingresos mensual de los últimos 12 meses";
            // 
            // promedioGastos
            // 
            this.promedioGastos.Enabled = false;
            this.promedioGastos.Location = new System.Drawing.Point(294, 29);
            this.promedioGastos.Name = "promedioGastos";
            this.promedioGastos.ReadOnly = true;
            this.promedioGastos.Size = new System.Drawing.Size(193, 20);
            this.promedioGastos.TabIndex = 2;
            // 
            // promedioIngresos
            // 
            this.promedioIngresos.Enabled = false;
            this.promedioIngresos.Location = new System.Drawing.Point(294, 65);
            this.promedioIngresos.Name = "promedioIngresos";
            this.promedioIngresos.ReadOnly = true;
            this.promedioIngresos.Size = new System.Drawing.Size(193, 20);
            this.promedioIngresos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de Cambio (USD)";
            // 
            // tipoDeCambio
            // 
            this.tipoDeCambio.Enabled = false;
            this.tipoDeCambio.Location = new System.Drawing.Point(294, 100);
            this.tipoDeCambio.Name = "tipoDeCambio";
            this.tipoDeCambio.ReadOnly = true;
            this.tipoDeCambio.Size = new System.Drawing.Size(193, 20);
            this.tipoDeCambio.TabIndex = 5;
            // 
            // configuracionPrestamoComboBox
            // 
            this.configuracionPrestamoComboBox.FormattingEnabled = true;
            this.configuracionPrestamoComboBox.Location = new System.Drawing.Point(294, 144);
            this.configuracionPrestamoComboBox.Name = "configuracionPrestamoComboBox";
            this.configuracionPrestamoComboBox.Size = new System.Drawing.Size(121, 21);
            this.configuracionPrestamoComboBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Plazo";
            // 
            // calcularPrestamoButton
            // 
            this.calcularPrestamoButton.Location = new System.Drawing.Point(294, 184);
            this.calcularPrestamoButton.Name = "calcularPrestamoButton";
            this.calcularPrestamoButton.Size = new System.Drawing.Size(193, 23);
            this.calcularPrestamoButton.TabIndex = 8;
            this.calcularPrestamoButton.Text = "Calcular Préstamo";
            this.calcularPrestamoButton.UseVisualStyleBackColor = true;
            this.calcularPrestamoButton.Click += new System.EventHandler(this.calcularPrestamoButton_Click);
            // 
            // SimuladorPrestamoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calcularPrestamoButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.configuracionPrestamoComboBox);
            this.Controls.Add(this.tipoDeCambio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.promedioIngresos);
            this.Controls.Add(this.promedioGastos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SimuladorPrestamoForm";
            this.Text = "SimuladorPrestamo";
            this.Load += new System.EventHandler(this.SimuladorPrestamoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox promedioGastos;
        private System.Windows.Forms.TextBox promedioIngresos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tipoDeCambio;
        private System.Windows.Forms.ComboBox configuracionPrestamoComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calcularPrestamoButton;
    }
}