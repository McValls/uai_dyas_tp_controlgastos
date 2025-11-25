using System.Windows.Forms;

namespace TP_DYAS_Control_Gastos_2025
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmarBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.crearAdministradorButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new TP_DYAS_Control_Gastos_2025.TextoNoVacio();
            this.passwordTextBox = new TP_DYAS_Control_Gastos_2025.UserControls.TextoPassword();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // confirmarBtn
            // 
            this.confirmarBtn.Location = new System.Drawing.Point(120, 86);
            this.confirmarBtn.Name = "confirmarBtn";
            this.confirmarBtn.Size = new System.Drawing.Size(126, 23);
            this.confirmarBtn.TabIndex = 4;
            this.confirmarBtn.Text = "Ingresar";
            this.confirmarBtn.UseVisualStyleBackColor = true;
            this.confirmarBtn.Click += new System.EventHandler(this.confirmarBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // crearAdministradorButton
            // 
            this.crearAdministradorButton.Location = new System.Drawing.Point(120, 115);
            this.crearAdministradorButton.Name = "crearAdministradorButton";
            this.crearAdministradorButton.Size = new System.Drawing.Size(126, 23);
            this.crearAdministradorButton.TabIndex = 6;
            this.crearAdministradorButton.Text = "Crear Admin";
            this.crearAdministradorButton.UseVisualStyleBackColor = true;
            this.crearAdministradorButton.Visible = false;
            this.crearAdministradorButton.Click += new System.EventHandler(this.crearAdministradorButton_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usernameTextBox.Location = new System.Drawing.Point(92, 9);
            this.usernameTextBox.MinimumSize = new System.Drawing.Size(10, 10);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(235, 25);
            this.usernameTextBox.TabIndex = 7;
            this.usernameTextBox.TextBox = "";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AutoSize = true;
            this.passwordTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.passwordTextBox.Location = new System.Drawing.Point(92, 43);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(235, 23);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.TextBox = "";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 198);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.crearAdministradorButton);
            this.Controls.Add(this.confirmarBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirmarBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button crearAdministradorButton;
        private TextoNoVacio usernameTextBox;
        private UserControls.TextoPassword passwordTextBox;
    }
}