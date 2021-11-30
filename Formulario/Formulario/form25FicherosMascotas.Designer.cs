
namespace Formulario
{
    partial class form25FicherosMascotas
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Raza = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lsMascotas = new System.Windows.Forms.ListBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(21, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(147, 34);
            this.txtNombre.TabIndex = 1;
            // 
            // Raza
            // 
            this.Raza.AutoSize = true;
            this.Raza.Location = new System.Drawing.Point(21, 136);
            this.Raza.Name = "Raza";
            this.Raza.Size = new System.Drawing.Size(53, 28);
            this.Raza.TabIndex = 2;
            this.Raza.Text = "Raza";
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(21, 179);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(147, 34);
            this.txtRaza.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mascotas";
            // 
            // lsMascotas
            // 
            this.lsMascotas.FormattingEnabled = true;
            this.lsMascotas.ItemHeight = 28;
            this.lsMascotas.Location = new System.Drawing.Point(278, 69);
            this.lsMascotas.Name = "lsMascotas";
            this.lsMascotas.Size = new System.Drawing.Size(317, 368);
            this.lsMascotas.TabIndex = 5;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(21, 243);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(147, 67);
            this.btnRegistro.TabIndex = 6;
            this.btnRegistro.Text = "Nuevo Registro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(21, 335);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(147, 46);
            this.btnLeer.TabIndex = 7;
            this.btnLeer.Text = "Leer Registros";
            this.btnLeer.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(21, 410);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(147, 71);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar Registros";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // form25FicherosMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 493);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.lsMascotas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.Raza);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "form25FicherosMascotas";
            this.Text = "form25FicherosMascotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label Raza;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lsMascotas;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnGuardar;
    }
}