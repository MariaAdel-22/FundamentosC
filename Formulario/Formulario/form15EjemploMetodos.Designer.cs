
namespace Formulario
{
    partial class form15EjemploMetodos
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnDoble = new System.Windows.Forms.Button();
            this.btnReferencia = new System.Windows.Forms.Button();
            this.btnClaseReferencia = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.txtLetras = new System.Windows.Forms.TextBox();
            this.lblMouse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(178, 52);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 34);
            this.txtNumero.TabIndex = 1;
            // 
            // btnDoble
            // 
            this.btnDoble.Location = new System.Drawing.Point(70, 110);
            this.btnDoble.Name = "btnDoble";
            this.btnDoble.Size = new System.Drawing.Size(208, 56);
            this.btnDoble.TabIndex = 2;
            this.btnDoble.Text = "Doble Valor";
            this.btnDoble.UseVisualStyleBackColor = true;
            this.btnDoble.Click += new System.EventHandler(this.btnDoble_Click);
            // 
            // btnReferencia
            // 
            this.btnReferencia.Location = new System.Drawing.Point(70, 189);
            this.btnReferencia.Name = "btnReferencia";
            this.btnReferencia.Size = new System.Drawing.Size(208, 56);
            this.btnReferencia.TabIndex = 3;
            this.btnReferencia.Text = "Doble Referencia";
            this.btnReferencia.UseVisualStyleBackColor = true;
            this.btnReferencia.Click += new System.EventHandler(this.btnReferencia_Click);
            // 
            // btnClaseReferencia
            // 
            this.btnClaseReferencia.Location = new System.Drawing.Point(70, 274);
            this.btnClaseReferencia.Name = "btnClaseReferencia";
            this.btnClaseReferencia.Size = new System.Drawing.Size(208, 34);
            this.btnClaseReferencia.TabIndex = 4;
            this.btnClaseReferencia.Text = "Método clase referencia";
            this.btnClaseReferencia.UseVisualStyleBackColor = true;
            this.btnClaseReferencia.Click += new System.EventHandler(this.btnClaseReferencia_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblResultado.Location = new System.Drawing.Point(70, 323);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(120, 28);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "lblResultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Números";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Letras";
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(434, 55);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(149, 34);
            this.txtNumeros.TabIndex = 9;
            this.txtNumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // txtLetras
            // 
            this.txtLetras.Location = new System.Drawing.Point(434, 97);
            this.txtLetras.Name = "txtLetras";
            this.txtLetras.Size = new System.Drawing.Size(149, 34);
            this.txtLetras.TabIndex = 11;
            this.txtLetras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetras_KeyPress);
            // 
            // lblMouse
            // 
            this.lblMouse.BackColor = System.Drawing.Color.DarkBlue;
            this.lblMouse.ForeColor = System.Drawing.Color.Red;
            this.lblMouse.Location = new System.Drawing.Point(336, 189);
            this.lblMouse.Name = "lblMouse";
            this.lblMouse.Size = new System.Drawing.Size(247, 172);
            this.lblMouse.TabIndex = 12;
            this.lblMouse.Text = "lblMouse";
            this.lblMouse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMouse_MouseMove);
            // 
            // form15EjemploMetodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 385);
            this.Controls.Add(this.lblMouse);
            this.Controls.Add(this.txtLetras);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnClaseReferencia);
            this.Controls.Add(this.btnReferencia);
            this.Controls.Add(this.btnDoble);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "form15EjemploMetodos";
            this.Text = "form13EjemploMetodos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnDoble;
        private System.Windows.Forms.Button btnReferencia;
        private System.Windows.Forms.Button btnClaseReferencia;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.TextBox txtLetras;
        private System.Windows.Forms.Label lblMouse;
    }
}