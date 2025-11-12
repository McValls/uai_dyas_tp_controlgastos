namespace TP_DYAS_Control_Gastos_2025
{
    partial class ResumenMovimientoForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.acumuladoPesosTextBox = new System.Windows.Forms.TextBox();
            this.acumuladoDolaresTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mesesComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aniosComboBox = new System.Windows.Forms.ComboBox();
            this.aplicarButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.monedaComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Monto,
            this.Descripcion});
            this.dataGridView.Location = new System.Drawing.Point(21, 79);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(746, 172);
            this.dataGridView.TabIndex = 0;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "monto";
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dólares";
            // 
            // acumuladoPesosTextBox
            // 
            this.acumuladoPesosTextBox.Location = new System.Drawing.Point(86, 33);
            this.acumuladoPesosTextBox.Name = "acumuladoPesosTextBox";
            this.acumuladoPesosTextBox.Size = new System.Drawing.Size(184, 20);
            this.acumuladoPesosTextBox.TabIndex = 3;
            // 
            // acumuladoDolaresTextBox
            // 
            this.acumuladoDolaresTextBox.Location = new System.Drawing.Point(86, 74);
            this.acumuladoDolaresTextBox.Name = "acumuladoDolaresTextBox";
            this.acumuladoDolaresTextBox.Size = new System.Drawing.Size(184, 20);
            this.acumuladoDolaresTextBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.acumuladoPesosTextBox);
            this.groupBox1.Controls.Add(this.acumuladoDolaresTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 127);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acumulado por Moneda";
            // 
            // mesesComboBox
            // 
            this.mesesComboBox.FormattingEnabled = true;
            this.mesesComboBox.Location = new System.Drawing.Point(107, 38);
            this.mesesComboBox.Name = "mesesComboBox";
            this.mesesComboBox.Size = new System.Drawing.Size(121, 21);
            this.mesesComboBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Año";
            // 
            // aniosComboBox
            // 
            this.aniosComboBox.FormattingEnabled = true;
            this.aniosComboBox.Location = new System.Drawing.Point(107, 11);
            this.aniosComboBox.Name = "aniosComboBox";
            this.aniosComboBox.Size = new System.Drawing.Size(121, 21);
            this.aniosComboBox.TabIndex = 8;
            // 
            // aplicarButton
            // 
            this.aplicarButton.Location = new System.Drawing.Point(648, 36);
            this.aplicarButton.Name = "aplicarButton";
            this.aplicarButton.Size = new System.Drawing.Size(75, 23);
            this.aplicarButton.TabIndex = 9;
            this.aplicarButton.Text = "Aplicar";
            this.aplicarButton.UseVisualStyleBackColor = true;
            this.aplicarButton.Click += new System.EventHandler(this.aplicarButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Moneda";
            // 
            // monedaComboBox
            // 
            this.monedaComboBox.FormattingEnabled = true;
            this.monedaComboBox.Location = new System.Drawing.Point(313, 11);
            this.monedaComboBox.Name = "monedaComboBox";
            this.monedaComboBox.Size = new System.Drawing.Size(121, 21);
            this.monedaComboBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Descripción";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(313, 38);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(300, 20);
            this.descripcionTextBox.TabIndex = 13;
            // 
            // ResumenMovimientoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.monedaComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.aplicarButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aniosComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mesesComboBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "ResumenMovimientoForm";
            this.Text = "ResumenMovimientoForm";
            this.Load += new System.EventHandler(this.ResumenMovimientoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox acumuladoPesosTextBox;
        private System.Windows.Forms.TextBox acumuladoDolaresTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox mesesComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox aniosComboBox;
        private System.Windows.Forms.Button aplicarButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox monedaComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox descripcionTextBox;
    }
}