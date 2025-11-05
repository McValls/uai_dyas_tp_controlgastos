using System;

namespace TP_DYAS_Control_Gastos_2025
{
    partial class MovimientoForm
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
            this.monedaComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ingresoRadioButton = new System.Windows.Forms.RadioButton();
            this.gastoRadioButton = new System.Windows.Forms.RadioButton();
            this.guardarButton = new System.Windows.Forms.Button();
            this.movimientosDataGridView = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.saldoActualTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.monedaSaldoActualComboBox = new System.Windows.Forms.ComboBox();
            this.montoTextBox = new TP_DYAS_Control_Gastos_2025.UserControls.NumeroDecimal();
            this.descripcionTextBox = new TP_DYAS_Control_Gastos_2025.TextoNoVacio();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movimientosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Moneda";
            // 
            // monedaComboBox
            // 
            this.monedaComboBox.FormattingEnabled = true;
            this.monedaComboBox.Location = new System.Drawing.Point(206, 49);
            this.monedaComboBox.Name = "monedaComboBox";
            this.monedaComboBox.Size = new System.Drawing.Size(121, 21);
            this.monedaComboBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ingresoRadioButton);
            this.groupBox1.Controls.Add(this.gastoRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 117);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de movimiento";
            // 
            // ingresoRadioButton
            // 
            this.ingresoRadioButton.AutoSize = true;
            this.ingresoRadioButton.Location = new System.Drawing.Point(9, 63);
            this.ingresoRadioButton.Name = "ingresoRadioButton";
            this.ingresoRadioButton.Size = new System.Drawing.Size(60, 17);
            this.ingresoRadioButton.TabIndex = 1;
            this.ingresoRadioButton.TabStop = true;
            this.ingresoRadioButton.Text = "Ingreso";
            this.ingresoRadioButton.UseVisualStyleBackColor = true;
            // 
            // gastoRadioButton
            // 
            this.gastoRadioButton.AutoSize = true;
            this.gastoRadioButton.Location = new System.Drawing.Point(9, 28);
            this.gastoRadioButton.Name = "gastoRadioButton";
            this.gastoRadioButton.Size = new System.Drawing.Size(53, 17);
            this.gastoRadioButton.TabIndex = 0;
            this.gastoRadioButton.TabStop = true;
            this.gastoRadioButton.Text = "Gasto";
            this.gastoRadioButton.UseVisualStyleBackColor = true;
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(206, 106);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(121, 23);
            this.guardarButton.TabIndex = 5;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_click);
            // 
            // movimientosDataGridView
            // 
            this.movimientosDataGridView.AllowUserToAddRows = false;
            this.movimientosDataGridView.AllowUserToDeleteRows = false;
            this.movimientosDataGridView.AllowUserToResizeRows = false;
            this.movimientosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.movimientosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movimientosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Descripcion,
            this.Monto});
            this.movimientosDataGridView.Location = new System.Drawing.Point(12, 149);
            this.movimientosDataGridView.Name = "movimientosDataGridView";
            this.movimientosDataGridView.Size = new System.Drawing.Size(691, 256);
            this.movimientosDataGridView.TabIndex = 6;
            this.movimientosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movimientosDataGridView_CellContentClick);
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "monto";
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Saldo actual";
            // 
            // saldoActualTextBox
            // 
            this.saldoActualTextBox.Location = new System.Drawing.Point(195, 425);
            this.saldoActualTextBox.Name = "saldoActualTextBox";
            this.saldoActualTextBox.Size = new System.Drawing.Size(174, 20);
            this.saldoActualTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descripción";
            // 
            // monedaSaldoActualComboBox
            // 
            this.monedaSaldoActualComboBox.FormattingEnabled = true;
            this.monedaSaldoActualComboBox.Location = new System.Drawing.Point(90, 424);
            this.monedaSaldoActualComboBox.Name = "monedaSaldoActualComboBox";
            this.monedaSaldoActualComboBox.Size = new System.Drawing.Size(99, 21);
            this.monedaSaldoActualComboBox.TabIndex = 11;
            this.monedaSaldoActualComboBox.SelectedValueChanged += new System.EventHandler(this.MonedaSaldoActualComboBox_SelectedValueChanged);
            // 
            // montoTextBox
            // 
            this.montoTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.montoTextBox.Location = new System.Drawing.Point(206, 22);
            this.montoTextBox.Name = "montoTextBox";
            this.montoTextBox.Size = new System.Drawing.Size(121, 23);
            this.montoTextBox.TabIndex = 12;
            this.montoTextBox.TextBox = "";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.descripcionTextBox.Location = new System.Drawing.Point(206, 79);
            this.descripcionTextBox.MinimumSize = new System.Drawing.Size(10, 10);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(121, 21);
            this.descripcionTextBox.TabIndex = 13;
            this.descripcionTextBox.TextBox = "";
            // 
            // MovimientoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 463);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.montoTextBox);
            this.Controls.Add(this.monedaSaldoActualComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saldoActualTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.movimientosDataGridView);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monedaComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MovimientoForm";
            this.Text = "Movimientos";
            this.Load += new System.EventHandler(this.MovimientoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movimientosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox monedaComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ingresoRadioButton;
        private System.Windows.Forms.RadioButton gastoRadioButton;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.DataGridView movimientosDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox saldoActualTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox monedaSaldoActualComboBox;
        private UserControls.NumeroDecimal montoTextBox;
        private TextoNoVacio descripcionTextBox;
    }
}