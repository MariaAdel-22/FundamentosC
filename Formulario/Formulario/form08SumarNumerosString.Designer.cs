
namespace Formulario
{
    partial class form08SumarNumerosString
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
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca números:";
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(67, 98);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(224, 34);
            this.txtNumeros.TabIndex = 1;
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(67, 159);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(224, 55);
            this.btnResultado.TabIndex = 2;
            this.btnResultado.Text = "Sumar números";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblResultado.Location = new System.Drawing.Point(67, 273);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(120, 28);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "lblResultado";
            // 
            // form08SumarNumerosString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 323);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "form08SumarNumerosString";
            this.Text = "form08SumarNumerosString";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}